using DataManagement;
using System.Windows.Forms;

namespace GameUI
{
    public partial class FormSetting : Form
    {
        public int foodCount;
        public int enemyCount;
        public int bedCount;
        public int maxCharCount;

        public FormSetting()
        {
            InitializeComponent();
            barBedCount.Maximum = barEnemy.Maximum = barFoodCount.Maximum = barMaxCharCount.Maximum = 100;
            lbBedCountValue.Text = barBedCount.Value.ToString();
            lbEnemyCountValue.Text = barEnemy.Value.ToString();
            lbFoodCountValue.Text = barFoodCount.Value.ToString();
            lbMaxCharCountValue.Text = barMaxCharCount.Value.ToString();

            barBedCount.Scroll += (s, e) => { lbBedCountValue.Text = barBedCount.Value.ToString(); };
            barEnemy.Scroll += (s, e) => { lbEnemyCountValue.Text = barEnemy.Value.ToString(); };
            barFoodCount.Scroll += (s, e) => { lbFoodCountValue.Text = barFoodCount.Value.ToString(); };
            barMaxCharCount.Scroll += (s, e) => { lbMaxCharCountValue.Text = barMaxCharCount.Value.ToString(); };

            btnSave.Click += (s, e) =>
            {
                bedCount = barBedCount.Value;
                enemyCount = barEnemy.Value;
                foodCount = barFoodCount.Value;
                maxCharCount = barMaxCharCount.Value;
                this.Close();
            };
        }

        public void UpdateSetting(GameConfiguration configuration)
        {
            barBedCount.Value = bedCount = configuration.InitialBedCount;
            barEnemy.Value = enemyCount = configuration.InitialEnemyCount;
            barFoodCount.Value = foodCount = configuration.InitialFoodCount;
            barMaxCharCount.Value = maxCharCount = configuration.MaxCharacterCount;
            lbBedCountValue.Text = barBedCount.Value.ToString();
            lbEnemyCountValue.Text = barEnemy.Value.ToString();
            lbFoodCountValue.Text = barFoodCount.Value.ToString();
            lbMaxCharCountValue.Text = barMaxCharCount.Value.ToString();
        }
    }
}