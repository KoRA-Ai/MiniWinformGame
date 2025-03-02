namespace MiniGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbTotalCount = new System.Windows.Forms.Label();
            this.teTotalCount = new System.Windows.Forms.TextBox();
            this.lbSoilder = new System.Windows.Forms.Label();
            this.teSoilderCount = new System.Windows.Forms.TextBox();
            this.lbBuilder = new System.Windows.Forms.Label();
            this.teBuilderCount = new System.Windows.Forms.TextBox();
            this.lbFarmer = new System.Windows.Forms.Label();
            this.teFarmerCount = new System.Windows.Forms.TextBox();
            this.pnlRecruitCharacters = new System.Windows.Forms.FlowLayoutPanel();
            this.lbFoodCount = new System.Windows.Forms.Label();
            this.teFoodCount = new System.Windows.Forms.TextBox();
            this.lbBedCount = new System.Windows.Forms.Label();
            this.teBedCount = new System.Windows.Forms.TextBox();
            this.lbEnemyList = new System.Windows.Forms.Label();
            this.lbAllyList = new System.Windows.Forms.Label();
            this.hpAlly = new System.Windows.Forms.ProgressBar();
            this.hpEnemy = new System.Windows.Forms.ProgressBar();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnNoon = new System.Windows.Forms.Button();
            this.btnNight = new System.Windows.Forms.Button();
            this.btnMorning = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlGame);
            this.panel1.Controls.Add(this.pnlStatus);
            this.panel1.Controls.Add(this.pnlRecruitCharacters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 675);
            this.panel1.TabIndex = 0;
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.btnMorning);
            this.pnlGame.Controls.Add(this.btnNight);
            this.pnlGame.Controls.Add(this.btnNoon);
            this.pnlGame.Controls.Add(this.btnSetting);
            this.pnlGame.Controls.Add(this.hpEnemy);
            this.pnlGame.Controls.Add(this.hpAlly);
            this.pnlGame.Controls.Add(this.lbAllyList);
            this.pnlGame.Controls.Add(this.lbEnemyList);
            this.pnlGame.Location = new System.Drawing.Point(183, 0);
            this.pnlGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1012, 476);
            this.pnlGame.TabIndex = 2;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.Info;
            this.pnlStatus.Controls.Add(this.lbBedCount);
            this.pnlStatus.Controls.Add(this.teBedCount);
            this.pnlStatus.Controls.Add(this.lbFoodCount);
            this.pnlStatus.Controls.Add(this.teFoodCount);
            this.pnlStatus.Controls.Add(this.lbTotalCount);
            this.pnlStatus.Controls.Add(this.teTotalCount);
            this.pnlStatus.Controls.Add(this.lbSoilder);
            this.pnlStatus.Controls.Add(this.teSoilderCount);
            this.pnlStatus.Controls.Add(this.lbBuilder);
            this.pnlStatus.Controls.Add(this.teBuilderCount);
            this.pnlStatus.Controls.Add(this.lbFarmer);
            this.pnlStatus.Controls.Add(this.teFarmerCount);
            this.pnlStatus.Location = new System.Drawing.Point(0, 484);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1200, 190);
            this.pnlStatus.TabIndex = 1;
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotalCount.Location = new System.Drawing.Point(334, 141);
            this.lbTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Size = new System.Drawing.Size(120, 28);
            this.lbTotalCount.TabIndex = 7;
            this.lbTotalCount.Text = "Total Count";
            // 
            // teTotalCount
            // 
            this.teTotalCount.Location = new System.Drawing.Point(464, 140);
            this.teTotalCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teTotalCount.Name = "teTotalCount";
            this.teTotalCount.ReadOnly = true;
            this.teTotalCount.Size = new System.Drawing.Size(156, 29);
            this.teTotalCount.TabIndex = 6;
            // 
            // lbSoilder
            // 
            this.lbSoilder.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSoilder.Location = new System.Drawing.Point(20, 141);
            this.lbSoilder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoilder.Name = "lbSoilder";
            this.lbSoilder.Size = new System.Drawing.Size(136, 28);
            this.lbSoilder.TabIndex = 5;
            this.lbSoilder.Text = "Soilder Count";
            // 
            // teSoilderCount
            // 
            this.teSoilderCount.Location = new System.Drawing.Point(159, 140);
            this.teSoilderCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teSoilderCount.Name = "teSoilderCount";
            this.teSoilderCount.ReadOnly = true;
            this.teSoilderCount.Size = new System.Drawing.Size(156, 29);
            this.teSoilderCount.TabIndex = 4;
            // 
            // lbBuilder
            // 
            this.lbBuilder.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBuilder.Location = new System.Drawing.Point(20, 87);
            this.lbBuilder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuilder.Name = "lbBuilder";
            this.lbBuilder.Size = new System.Drawing.Size(136, 28);
            this.lbBuilder.TabIndex = 3;
            this.lbBuilder.Text = "Builder Count";
            // 
            // teBuilderCount
            // 
            this.teBuilderCount.Location = new System.Drawing.Point(159, 86);
            this.teBuilderCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teBuilderCount.Name = "teBuilderCount";
            this.teBuilderCount.ReadOnly = true;
            this.teBuilderCount.Size = new System.Drawing.Size(156, 29);
            this.teBuilderCount.TabIndex = 2;
            // 
            // lbFarmer
            // 
            this.lbFarmer.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFarmer.Location = new System.Drawing.Point(20, 38);
            this.lbFarmer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFarmer.Name = "lbFarmer";
            this.lbFarmer.Size = new System.Drawing.Size(136, 28);
            this.lbFarmer.TabIndex = 1;
            this.lbFarmer.Text = "Farmer Count";
            // 
            // teFarmerCount
            // 
            this.teFarmerCount.Location = new System.Drawing.Point(159, 36);
            this.teFarmerCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teFarmerCount.Name = "teFarmerCount";
            this.teFarmerCount.ReadOnly = true;
            this.teFarmerCount.Size = new System.Drawing.Size(156, 29);
            this.teFarmerCount.TabIndex = 0;
            // 
            // pnlRecruitCharacters
            // 
            this.pnlRecruitCharacters.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlRecruitCharacters.Location = new System.Drawing.Point(0, 0);
            this.pnlRecruitCharacters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRecruitCharacters.Name = "pnlRecruitCharacters";
            this.pnlRecruitCharacters.Size = new System.Drawing.Size(174, 476);
            this.pnlRecruitCharacters.TabIndex = 0;
            // 
            // lbFoodCount
            // 
            this.lbFoodCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFoodCount.Location = new System.Drawing.Point(793, 38);
            this.lbFoodCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFoodCount.Name = "lbFoodCount";
            this.lbFoodCount.Size = new System.Drawing.Size(136, 28);
            this.lbFoodCount.TabIndex = 9;
            this.lbFoodCount.Text = "Food Count";
            // 
            // teFoodCount
            // 
            this.teFoodCount.Location = new System.Drawing.Point(932, 36);
            this.teFoodCount.Margin = new System.Windows.Forms.Padding(4);
            this.teFoodCount.Name = "teFoodCount";
            this.teFoodCount.ReadOnly = true;
            this.teFoodCount.Size = new System.Drawing.Size(156, 29);
            this.teFoodCount.TabIndex = 8;
            // 
            // lbBedCount
            // 
            this.lbBedCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBedCount.Location = new System.Drawing.Point(793, 88);
            this.lbBedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBedCount.Name = "lbBedCount";
            this.lbBedCount.Size = new System.Drawing.Size(136, 28);
            this.lbBedCount.TabIndex = 11;
            this.lbBedCount.Text = "Bed Count";
            // 
            // teBedCount
            // 
            this.teBedCount.Location = new System.Drawing.Point(932, 86);
            this.teBedCount.Margin = new System.Windows.Forms.Padding(4);
            this.teBedCount.Name = "teBedCount";
            this.teBedCount.ReadOnly = true;
            this.teBedCount.Size = new System.Drawing.Size(156, 29);
            this.teBedCount.TabIndex = 10;
            // 
            // lbEnemyList
            // 
            this.lbEnemyList.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEnemyList.Location = new System.Drawing.Point(468, 235);
            this.lbEnemyList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnemyList.Name = "lbEnemyList";
            this.lbEnemyList.Size = new System.Drawing.Size(536, 28);
            this.lbEnemyList.TabIndex = 13;
            this.lbEnemyList.Text = "enemy";
            this.lbEnemyList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAllyList
            // 
            this.lbAllyList.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAllyList.Location = new System.Drawing.Point(17, 235);
            this.lbAllyList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAllyList.Name = "lbAllyList";
            this.lbAllyList.Size = new System.Drawing.Size(443, 28);
            this.lbAllyList.TabIndex = 15;
            this.lbAllyList.Text = "ally";
            this.lbAllyList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hpAlly
            // 
            this.hpAlly.Location = new System.Drawing.Point(21, 21);
            this.hpAlly.Name = "hpAlly";
            this.hpAlly.Size = new System.Drawing.Size(241, 23);
            this.hpAlly.TabIndex = 16;
            // 
            // hpEnemy
            // 
            this.hpEnemy.Location = new System.Drawing.Point(749, 21);
            this.hpEnemy.Name = "hpEnemy";
            this.hpEnemy.Size = new System.Drawing.Size(241, 23);
            this.hpEnemy.TabIndex = 17;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(437, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 63);
            this.btnSetting.TabIndex = 18;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnNoon
            // 
            this.btnNoon.Location = new System.Drawing.Point(614, 400);
            this.btnNoon.Name = "btnNoon";
            this.btnNoon.Size = new System.Drawing.Size(75, 63);
            this.btnNoon.TabIndex = 19;
            this.btnNoon.Text = "午";
            this.btnNoon.UseVisualStyleBackColor = true;
            // 
            // btnNight
            // 
            this.btnNight.Location = new System.Drawing.Point(730, 400);
            this.btnNight.Name = "btnNight";
            this.btnNight.Size = new System.Drawing.Size(75, 63);
            this.btnNight.TabIndex = 20;
            this.btnNight.Text = "晚";
            this.btnNight.UseVisualStyleBackColor = true;
            // 
            // btnMorning
            // 
            this.btnMorning.Location = new System.Drawing.Point(504, 400);
            this.btnMorning.Name = "btnMorning";
            this.btnMorning.Size = new System.Drawing.Size(75, 63);
            this.btnMorning.TabIndex = 21;
            this.btnMorning.Text = "早";
            this.btnMorning.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.pnlGame.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlRecruitCharacters;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbFarmer;
        private System.Windows.Forms.TextBox teFarmerCount;
        private System.Windows.Forms.Label lbSoilder;
        private System.Windows.Forms.TextBox teSoilderCount;
        private System.Windows.Forms.Label lbBuilder;
        private System.Windows.Forms.TextBox teBuilderCount;
        private System.Windows.Forms.Label lbTotalCount;
        private System.Windows.Forms.TextBox teTotalCount;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lbBedCount;
        private System.Windows.Forms.TextBox teBedCount;
        private System.Windows.Forms.Label lbFoodCount;
        private System.Windows.Forms.TextBox teFoodCount;
        private System.Windows.Forms.Label lbEnemyList;
        private System.Windows.Forms.Label lbAllyList;
        private System.Windows.Forms.ProgressBar hpAlly;
        private System.Windows.Forms.ProgressBar hpEnemy;
        private System.Windows.Forms.Button btnNight;
        private System.Windows.Forms.Button btnNoon;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMorning;
    }
}

