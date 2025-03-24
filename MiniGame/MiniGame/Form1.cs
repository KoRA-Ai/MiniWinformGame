using Characters;
using DataManagement;
using GameLogic;
using GameLogic.BattleSystem;
using GameLogic.Characters;
using GameLogic.ResourceManagement;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Form1 : Form
    {
        private GameConfiguration initConfiguration;
        private ResourceManager resourceManager;
        private CharacterManager characterManager;
        private BattleSystem battaleSystem;
        private StringBuilder sblog = new StringBuilder();
        private int _currentRound = 0;

        private int currentRound
        {
            get { return _currentRound; }
            set
            {
                _currentRound = value;
                Task.Run(async () =>
                {
                    switch (_currentRound)
                    {
                        case 2://消耗
                            Invoke((Action)(() => lbNowRound.Text = "消耗"));
                            await Task.Delay(500);
                            Invoke((Action)(() => { 消耗(); }));

                            break;

                        case 3://戰鬥
                            Invoke((Action)(() => lbNowRound.Text = "戰鬥回合"));
                            await Task.Delay(500);

                            Invoke((Action)(() => { 打架(); }));

                            break;

                        case 4://生產
                            Invoke((Action)(() => lbNowRound.Text = "生產回合"));
                            Invoke((Action)(() => { 生產(); }));

                            currentRound += 1;
                            break;

                        case 5://回合結算
                            Invoke((Action)(() => lbNowRound.Text = "回合結算"));

                            break;
                    }
                });
            }
        }

        public Form1()
        {
            InitializeComponent();

            lbAllyList.Text = lbEnemyList.Text = string.Empty;

            initConfiguration = new GameConfiguration(5, 100, 10, 5);
            resourceManager = new ResourceManager(initConfiguration);
            characterManager = new CharacterManager(initConfiguration, resourceManager);
            battaleSystem = new BattleSystem(initConfiguration.InitialEnemyCount);
            SetEnemyCharacterUI();
            UpdateResourceCount();

            foreach (AllyCharacter.AllyTypes value in Enum.GetValues(typeof(AllyCharacter.AllyTypes)))
            {
                StringBuilder part1Msg = new StringBuilder();
                Button button = new Button();
                button.Name = "btnRecruit" + value.ToString();
                button.Text = value.ToString();
                button.BackColor = Color.White;
                button.Size = new System.Drawing.Size(100, 60);

                button.Click += (s, e) =>
                {
                    if (_currentRound != 1)
                    {
                        _currentRound = 1;
                        lbNowRound.Text = "僱用角色";
                    }
                    characterManager.HireCharacter(value, ref part1Msg);
                    sblog.AppendLine(part1Msg.ToString());

                    UpdateAllyCount();
                    SetAllyCharacterUI();

                    if (characterManager.GetAllCharactersCount() > 0)
                    {
                        btnSetting.Enabled = false;
                    }
                };
                pnlRecruitCharacters.Controls.Add(button);
            }

            btnSetting.Click += (s, e) => { 設定(); };
            btnEndRound.Click += (s, e) =>
            {
                switch (_currentRound)
                {
                    case 0://設定
                        break;

                    case 1://僱用角色回合
                        if (characterManager.GetAllCharactersCount() == 0)
                        {
                            MessageBox.Show("尚未僱用角色");
                            return;
                        }
                        currentRound += 1;
                        btnEndRound.Visible = false;
                        break;
                }
            };

            btnLog.Click += BtnLog_Click;
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            FormLog form = new FormLog(sblog.ToString());
            form.ShowDialog();
        }

        private void 消耗()
        {
            // 確保 UI 更新在主執行緒
            if (InvokeRequired)
            {
                Invoke(new Action(消耗));
                return;
            }

            StringBuilder msg = new StringBuilder();
            characterManager.AllocateResourceAndRemoveCharacter(ref msg);
            sblog.AppendLine("【消耗回合】");
            sblog.AppendLine(msg.ToString());
            UpdateAllyCount();
            UpdateResourceCount();

            currentRound += 1;
        }

        private void 生產()
        {  // 確保 UI 更新在主執行緒
            if (InvokeRequired)
            {
                Invoke(new Action(生產));
                return;
            }
            StringBuilder msg = new StringBuilder();
            characterManager.MakeAllCharactersWork(ref msg);
            sblog.AppendLine("【生產回合】");
            sblog.AppendLine(msg.ToString());
            UpdateAllyCount();
            UpdateResourceCount();
            currentRound += 1;
        }

        private void 打架()
        {
            //battaleSystem.Fight(characterManager.GetAllInGameCharacters());
            if (InvokeRequired)
            {
                Invoke(new Action(打架));
                return;
            }
            foreach (var ally in characterManager.GetAllInGameCharacters().Where(a => !a.IsDead).OrderByDescending(a => a.AttackPower).ThenByDescending(a => a.Appetite))
            {
                lbAlly.Text = ally.AllyType.ToString();
                foreach (var enemy in battaleSystem.Enemies.Where(e => !e.IsDead))
                {
                    lbEnemy.Text = enemy.EnemyType.ToString();

                    if (ally.IsDead) continue;
                    battaleSystem.Fight_1v1(ally, enemy);
                    UpdateAllyCount();
                }
            }

            UpdateResourceCount();
            currentRound += 1;
        }

        private void 設定()
        {
            FormSetting frm = new FormSetting();
            frm.UpdateSetting(initConfiguration);
            frm.Show();

            frm.FormClosed += (s, _) =>
            {
                initConfiguration = new GameConfiguration(frm.enemyCount, frm.foodCount, frm.bedCount, frm.maxCharCount);
                battaleSystem = new BattleSystem(initConfiguration.InitialEnemyCount);
                characterManager = new CharacterManager(initConfiguration, resourceManager);
                resourceManager = new ResourceManager(initConfiguration);
                SetEnemyCharacterUI();
                UpdateResourceCount();
            };
        }

        private void SetAllyCharacterUI()
        {
            string text = string.Empty;
            for (int i = 0; i < characterManager.GetFarmersCount(); i++)
            {
                text += "農";
            }
            for (int i = 0; i < characterManager.GetBuildersCount(); i++)
            {
                text += "建";
            }
            for (int i = 0; i < characterManager.GetSoldiersCount(); i++)
            {
                text += "鬥";
            }
            lbAllyList.Text = text;
        }

        private void SetEnemyCharacterUI()
        {
            string text = string.Empty;
            for (int i = 0; i < battaleSystem.GetEnemyCount(); i++)
            {
                text += "敵";
            }

            lbEnemyList.Text = text;
        }

        private void UpdateAllyCount()
        {
            teSoilderCount.Text = characterManager.GetSoldiersCount().ToString();
            teBuilderCount.Text = characterManager.GetBuildersCount().ToString();
            teFarmerCount.Text = characterManager.GetFarmersCount().ToString();
            teTotalCount.Text = characterManager.GetAllCharactersCount().ToString();
        }

        private void UpdateResourceCount()
        {
            teFoodCount.Text = resourceManager.TotalFoods.ToString();
            teBedCount.Text = resourceManager.EmptyBeds.ToString();
        }
    }
}