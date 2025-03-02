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
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Form1 : Form
    {
        private GameConfiguration initConfiguration;
        private ResourceManager resourceManager;
        private CharacterManager characterManager;
        private BattleSystem battaleSystem;

        public Form1()
        {
            InitializeComponent();
            btnSetting.Click += BtnSetting_Click;
            lbAllyList.Text = lbEnemyList.Text = string.Empty;
            //hpAlly.Value = 10;

            initConfiguration = new GameConfiguration(5, 100, 10, 5);
            resourceManager = new ResourceManager(initConfiguration);
            characterManager = new CharacterManager(initConfiguration, resourceManager);
            battaleSystem = new BattleSystem(characterManager.GetAllInGameCharacters(), initConfiguration.InitialEnemyCount);
            SetEnemyCharacterUI();

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
                    characterManager.HireCharacter(value, ref part1Msg);

                    UpdateAllyCount();
                    SetAllyCharacterUI();
                };
                pnlRecruitCharacters.Controls.Add(button);
            }
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            FormSetting frm = new FormSetting();
            frm.UpdateSetting(initConfiguration);
            frm.Show();
            frm.FormClosed += (s, _) =>
            {
                initConfiguration = new GameConfiguration(frm.enemyCount, frm.foodCount, frm.bedCount, frm.maxCharCount);
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
    }
}