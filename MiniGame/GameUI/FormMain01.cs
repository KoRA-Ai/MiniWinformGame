using DataManagement;
using GameLogic;
using GameLogic.BattleSystem;
using GameLogic.ResourceManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameUI
{
    public partial class FormMain01 : Form
    {
        private GameConfiguration initConfiguration;
        private ResourceManager resourceManager;
        private CharacterManager characterManager;
        private BattleSystem battaleSystem;
        private int num = 1;

        public FormMain01()
        {
            InitializeComponent();

            initConfiguration = new GameConfiguration(5, 100, 10, 5);

            splitContainer1.Panel1.Visible = false;
            //FormSetting form = new FormSetting() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
            //splitContainer1.Panel2.Controls.Add(form);
            //form.Show();
            //form.FormClosed += (s, e) =>
            //{
            //    splitContainer1.Panel1.Visible = true;
            //    initConfiguration = new GameConfiguration(form.enemyCount, form.foodCount, form.bedCount, form.maxCharCount);
            //    resourceManager = new ResourceManager(initConfiguration);
            //    characterManager = new CharacterManager(initConfiguration, resourceManager);
            //    battaleSystem = new BattleSystem(characterManager.GetAllInGameCharacters(), initConfiguration.InitialEnemyCount);
            //    UpdateResourceCount();
            //    UpdateEnemyCount();
            //    UpdateAllyCount();
            //    num += 1;
            //};

            RunStoryBoardSequence();
        }

        private async void RunStoryBoardSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await StoryBoard(i);  // 等待前一個 Form 關閉才開啟下一個
            }
        }

        private async Task StoryBoard(int num)
        {
            var tcs = new TaskCompletionSource<bool>();

            switch (num)
            {
                case 1:
                    FormSetting form = new FormSetting() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
                    splitContainer1.Panel2.Controls.Add(form);
                    form.Show();
                    form.FormClosed += (s, e) =>
                    {
                        splitContainer1.Panel1.Visible = true;
                        initConfiguration = new GameConfiguration(form.enemyCount, form.foodCount, form.bedCount, form.maxCharCount);
                        resourceManager = new ResourceManager(initConfiguration);
                        characterManager = new CharacterManager(initConfiguration, resourceManager);
                        battaleSystem = new BattleSystem(characterManager.GetAllInGameCharacters(), initConfiguration.InitialEnemyCount);
                        UpdateResourceCount();
                        UpdateEnemyCount();
                        UpdateAllyCount();
                        tcs.SetResult(true);
                    };
                    break;

                case 2:
                    FormStoryBoard02 form2 = new FormStoryBoard02(characterManager) { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
                    splitContainer1.Panel2.Controls.Add(form2);
                    form2.Show();
                    form2.FormClosed += (s, e) =>
                    {
                        battaleSystem = new BattleSystem(characterManager.GetAllInGameCharacters(), initConfiguration.InitialEnemyCount);
                        UpdateResourceCount();
                        UpdateEnemyCount();
                        UpdateAllyCount();
                        tcs.SetResult(true);
                    };
                    break;

                case 3:
                    tcs.SetResult(true);
                    break;

                default:
                    tcs.SetResult(true);
                    break;
            }
            await tcs.Task;
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

        private void UpdateEnemyCount()
        {
            teEnemyCount.Text = battaleSystem.GetEnemyCount().ToString();
        }
    }
}