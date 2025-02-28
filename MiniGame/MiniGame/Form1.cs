using Characters;
using DataManagement;
using GameLogic;
using GameLogic.BattleSystem;
using GameLogic.Characters;
using GameLogic.ResourceManagement;
using System;
using System.Drawing;
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
            initConfiguration = new GameConfiguration(5, 200, 5, 5);
            resourceManager = new ResourceManager(initConfiguration);
            characterManager = new CharacterManager(initConfiguration, resourceManager);
            battaleSystem = new BattleSystem(characterManager.GetAllInGameCharacters(), initConfiguration.InitialEnemyCount);

            foreach (AllyCharacter.AllyTypes value in Enum.GetValues(typeof(AllyCharacter.AllyTypes)))
            {
                StringBuilder part1Msg = new StringBuilder();
                Button button = new Button();
                button.Name = "btnRecruit" + value.ToString();
                button.Text = value.ToString();
                button.BackColor = Color.White;
                button.Size = new System.Drawing.Size(100, 60);

                #region hide

                //Action<AllyCharacter.AllyTypes> recruitAct = (AllyCharacter.AllyTypes type) =>
                //{
                //    switch (value)
                //    {
                //        case AllyCharacter.AllyTypes.Farmer:
                //            characterManager.HireCharacter(new Farmer(), ref part1Msg);
                //            break;

                //        case AllyCharacter.AllyTypes.Builder:
                //            characterManager.HireCharacter(new Builder(), ref part1Msg);
                //            break;

                //        case AllyCharacter.AllyTypes.Soldier:
                //            characterManager.HireCharacter(new Soldier(), ref part1Msg);
                //            break;

                //        default:
                //            throw new ArgumentNullException();
                //    }
                //};

                //button.Click += (s, e) => recruitAct(value);

                #endregion hide

                button.Click += (s, e) =>
                {
                    characterManager.HireCharacter(value, ref part1Msg);
                    UpdateAllyCount();
                };
                pnlRecruitCharacters.Controls.Add(button);
            }
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