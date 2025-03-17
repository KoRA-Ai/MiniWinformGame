using Characters;
using GameLogic;
using GameLogic.Characters;
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
    public partial class FormStoryBoard02 : Form
    {
        private CharacterManager characterManager;
        private List<AllyCharacter> characterList = new List<AllyCharacter>();

        public FormStoryBoard02()
        {
            InitializeComponent();
            teFarmerCount.KeyPress += TypeOnlyNumer;
            teBuilderCount.KeyPress += TypeOnlyNumer;
            teSoilderCount.KeyPress += TypeOnlyNumer;
            teFarmerCount.TextChanged += (s, e) => CheckResource();
            teBuilderCount.TextChanged += (s, e) => CheckResource();
            teSoilderCount.TextChanged += (s, e) => CheckResource();
        }

        public FormStoryBoard02(CharacterManager characterManager)
        {
            InitializeComponent();
            btnConfirm.Enabled = false;
            this.characterManager = characterManager;

            teFarmerCount.KeyPress += TypeOnlyNumer;
            teBuilderCount.KeyPress += TypeOnlyNumer;
            teSoilderCount.KeyPress += TypeOnlyNumer;
            btnView.Click += (s, e) => CheckResource();
            btnConfirm.Click += (s, e) =>
            {
                StringBuilder msg = new StringBuilder();
                foreach (var ch in characterList)
                {
                    characterManager.HireCharacter(ch, ref msg);
                }

                this.Close();
            };
        }

        private void CheckResource()
        {
            characterList.Clear();
            if (string.IsNullOrWhiteSpace(teBuilderCount.Text) && string.IsNullOrWhiteSpace(teFarmerCount.Text) && string.IsNullOrWhiteSpace(teSoilderCount.Text))
            {
                labelMsg.Text = "請輸入欲僱用的角色數量";
            }
            if (!string.IsNullOrWhiteSpace(teBuilderCount.Text))
            {
                for (int i = 0; i < Convert.ToInt32(teBuilderCount.Text); i++)
                {
                    characterList.Add(new Builder());
                }
            }
            if (!string.IsNullOrWhiteSpace(teFarmerCount.Text))
            {
                for (int i = 0; i < Convert.ToInt32(teFarmerCount.Text); i++)
                {
                    characterList.Add(new Farmer());
                }
            }
            if (!string.IsNullOrWhiteSpace(teSoilderCount.Text))
            {
                for (int i = 0; i < Convert.ToInt32(teSoilderCount.Text); i++)
                {
                    characterList.Add(new Soldier());
                }
            }
            btnConfirm.Enabled = characterManager.CheckHireRules(characterList, out string output);
            labelMsg.Text = output;
        }

        private void TypeOnlyNumer(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}