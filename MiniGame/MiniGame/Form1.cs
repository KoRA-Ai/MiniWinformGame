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
        private TurnSettlement turnSettlement = new TurnSettlement();
        private StringBuilder sblog = new StringBuilder();

        //private int _currentRound = 0;
        private bool isStartRound = true;

        private int currentRound = 0;

        public Form1(GameConfiguration configuration = null, CharacterManager cManager = null)
        {
            InitializeComponent();

            lbAllyList.Text = lbEnemyList.Text = string.Empty;
            btnEndRound.Enabled = false;
            if (configuration == null)
                initConfiguration = new GameConfiguration(5, 100, 10, 5);
            else
                initConfiguration = configuration;
            resourceManager = new ResourceManager(initConfiguration);
            if (cManager == null)
                characterManager = new CharacterManager(initConfiguration, resourceManager);
            else
                characterManager = cManager;
            battaleSystem = new BattleSystem(initConfiguration.InitialEnemyCount);
            SetEnemyCharacterUI();
            UpdateResourceCount();

            僱用();

            btnSetting.Click += (s, e) => { 設定(); };
            btnEndRound.Click += async (s, e) =>
            {
                isStartRound = !isStartRound;
                if (isStartRound) currentRound += 1;
                switch (currentRound)
                {
                    case 1://僱用角色回合
                        if (!isStartRound)
                        {
                            btnEndRound.Enabled = true;
                            //禁止僱用
                            foreach (Control c in pnlRecruitCharacters.Controls)
                            {
                                c.Enabled = false;
                            }
                        }
                        break;

                    case 2://消耗
                        if (isStartRound)
                        {
                            lbNowRound.Text = "消耗";
                            btnEndRound.Text = "自動執行回合...";
                            await Task.Delay(2000);
                            消耗();
                            isStartRound = false;
                        }

                        break;

                    case 3://戰鬥
                        if (isStartRound)
                        {
                            lbNowRound.Text = "戰鬥回合";
                            btnEndRound.Text = "自動執行回合...";
                            await Task.Delay(1000);
                            打架();
                            isStartRound = false;
                        }

                        break;

                    case 4://生產
                        lbNowRound.Text = "生產回合";
                        btnEndRound.Text = "自動執行回合...";
                        await Task.Delay(1000);
                        生產();
                        isStartRound = false;

                        break;

                    case 5://回合結算
                        lbNowRound.Text = "回合結算";
                        btnEndRound.Text = "...";
                        if (turnSettlement.IsWinGame(characterManager, battaleSystem))
                        {
                            MessageBox.Show("遊戲結束 - 我方勝利");
                            MessageBox.Show("將開始新回合");
                            StringBuilder sbmsg = new StringBuilder();
                            turnSettlement.ReassignCharacters(characterManager, battaleSystem, ref sbmsg);
                            sblog.AppendLine(sbmsg.ToString());
                            Form1 form1 = new Form1(new GameConfiguration(5, 100, 10, 5), characterManager);
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("遊戲結束 - 我方失敗");
                            MessageBox.Show("將開始新回合");
                            initConfiguration = new GameConfiguration(5 + battaleSystem.GetEnemyCount(), 100, 10, 5);
                            Form1 form1 = new Form1(initConfiguration, null);
                            form1.Show();
                            return;
                        }
                        break;
                }

                if (isStartRound) btnEndRound.Text = "結束此回合";
                else btnEndRound.Text = "進行下回合";
            };

            btnLog.Click += BtnLog_Click;
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            FormLog form = new FormLog(sblog.ToString());
            form.ShowDialog();
        }

        private void 僱用()
        {
            foreach (GoodCharacter.PositionTypes value in Enum.GetValues(typeof(GoodCharacter.PositionTypes)))
            {
                Button button = new Button();
                button.Name = "btnRecruit" + value.ToString();
                button.Text = value.ToString();
                button.BackColor = Color.White;
                button.Size = new System.Drawing.Size(100, 60);

                button.Click += (s, e) =>
                {
                    btnEndRound.Enabled = true;

                    if (currentRound != 1)
                    {
                        currentRound = 1;
                        lbNowRound.Text = "僱用角色";
                    }
                    var result = characterManager.HireCharacter(value);
                    if (!result.isSuccessed)
                    {
                        MessageBox.Show(result.err);
                    }
                    sblog.AppendLine(result.err);

                    SetGoodCharacterUI();
                    UpdateResourceCount();

                    //一旦招募就將設定關起來
                    if (characterManager.GetAllCharactersCount() > 0)
                    {
                        btnSetting.Enabled = false;
                    }
                };
                pnlRecruitCharacters.Controls.Add(button);
            }
        }

        private void 消耗()
        {
            StringBuilder msg = new StringBuilder();
            characterManager.AllocateResourceAndRemoveCharacter(ref msg);
            sblog.AppendLine("【消耗回合】");
            sblog.AppendLine(msg.ToString());
            SetGoodCharacterUI();
            UpdateResourceCount();
        }

        private void 生產()
        {
            StringBuilder msg = new StringBuilder();
            characterManager.MakeAllCharactersWork(ref msg);
            sblog.AppendLine("【生產回合】");
            sblog.AppendLine(msg.ToString());
            MessageBox.Show(msg.ToString());
            SetGoodCharacterUI();
            UpdateResourceCount();
        }

        private void 打架()
        {
            StringBuilder sbmsg = new StringBuilder();
            sblog.AppendLine("【打架回合】");
            battaleSystem.Fight(characterManager.GetAllInGameCharacters(), ref sbmsg);
            sblog.AppendLine(sbmsg.ToString());

            SetGoodCharacterUI();
            SetEnemyCharacterUI();
            //重算空床
            resourceManager.EmptyBeds = resourceManager.TotalBeds - characterManager.GetAllCharactersCount();
            UpdateResourceCount();
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

        private void SetGoodCharacterUI()
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
            UpdateAllyCount();
        }

        private void SetEnemyCharacterUI()
        {
            string text = string.Empty;
            for (int i = 0; i < battaleSystem.GetEnemyCount(); i++)
            {
                text += "敵";
            }

            lbEnemyList.Text = text;
            teEnemyCount.Text = battaleSystem.GetEnemyCount().ToString();
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
            teEmptyBedCount.Text = resourceManager.EmptyBeds.ToString();
            teTotalBed.Text = resourceManager.TotalBeds.ToString();
        }
    }
}