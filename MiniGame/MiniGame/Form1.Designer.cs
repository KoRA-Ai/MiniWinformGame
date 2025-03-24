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
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.lbNowRound = new System.Windows.Forms.Label();
            this.btnEndRound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hpEnemy = new System.Windows.Forms.ProgressBar();
            this.hpAlly = new System.Windows.Forms.ProgressBar();
            this.lbAllyList = new System.Windows.Forms.Label();
            this.lbEnemyList = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbBedCount = new System.Windows.Forms.Label();
            this.teBedCount = new System.Windows.Forms.TextBox();
            this.lbFoodCount = new System.Windows.Forms.Label();
            this.teFoodCount = new System.Windows.Forms.TextBox();
            this.lbTotalCount = new System.Windows.Forms.Label();
            this.teTotalCount = new System.Windows.Forms.TextBox();
            this.lbSoilder = new System.Windows.Forms.Label();
            this.teSoilderCount = new System.Windows.Forms.TextBox();
            this.lbBuilder = new System.Windows.Forms.Label();
            this.teBuilderCount = new System.Windows.Forms.TextBox();
            this.lbFarmer = new System.Windows.Forms.Label();
            this.teFarmerCount = new System.Windows.Forms.TextBox();
            this.pnlRecruitCharacters = new System.Windows.Forms.FlowLayoutPanel();
            this.lbAlly = new System.Windows.Forms.Label();
            this.lbEnemy = new System.Windows.Forms.Label();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.lbEnemy);
            this.pnlGame.Controls.Add(this.lbAlly);
            this.pnlGame.Controls.Add(this.btnSetting);
            this.pnlGame.Controls.Add(this.btnLog);
            this.pnlGame.Controls.Add(this.lbNowRound);
            this.pnlGame.Controls.Add(this.btnEndRound);
            this.pnlGame.Controls.Add(this.label1);
            this.pnlGame.Controls.Add(this.hpEnemy);
            this.pnlGame.Controls.Add(this.hpAlly);
            this.pnlGame.Controls.Add(this.lbAllyList);
            this.pnlGame.Controls.Add(this.lbEnemyList);
            this.pnlGame.Location = new System.Drawing.Point(122, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(675, 317);
            this.pnlGame.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(187, 8);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(50, 42);
            this.btnSetting.TabIndex = 18;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(382, 8);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(50, 42);
            this.btnLog.TabIndex = 22;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // lbNowRound
            // 
            this.lbNowRound.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbNowRound.Location = new System.Drawing.Point(263, 39);
            this.lbNowRound.Name = "lbNowRound";
            this.lbNowRound.Size = new System.Drawing.Size(91, 19);
            this.lbNowRound.TabIndex = 24;
            this.lbNowRound.Text = "尚未開始";
            this.lbNowRound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEndRound
            // 
            this.btnEndRound.Location = new System.Drawing.Point(259, 59);
            this.btnEndRound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEndRound.Name = "btnEndRound";
            this.btnEndRound.Size = new System.Drawing.Size(95, 32);
            this.btnEndRound.TabIndex = 22;
            this.btnEndRound.Text = "結束回合";
            this.btnEndRound.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(263, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "現在回合:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hpEnemy
            // 
            this.hpEnemy.Location = new System.Drawing.Point(499, 14);
            this.hpEnemy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hpEnemy.Name = "hpEnemy";
            this.hpEnemy.Size = new System.Drawing.Size(161, 15);
            this.hpEnemy.TabIndex = 17;
            // 
            // hpAlly
            // 
            this.hpAlly.Location = new System.Drawing.Point(14, 14);
            this.hpAlly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hpAlly.Name = "hpAlly";
            this.hpAlly.Size = new System.Drawing.Size(161, 15);
            this.hpAlly.TabIndex = 16;
            // 
            // lbAllyList
            // 
            this.lbAllyList.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAllyList.Location = new System.Drawing.Point(11, 157);
            this.lbAllyList.Name = "lbAllyList";
            this.lbAllyList.Size = new System.Drawing.Size(295, 83);
            this.lbAllyList.TabIndex = 15;
            this.lbAllyList.Text = "ally";
            this.lbAllyList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbEnemyList
            // 
            this.lbEnemyList.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEnemyList.Location = new System.Drawing.Point(312, 157);
            this.lbEnemyList.Name = "lbEnemyList";
            this.lbEnemyList.Size = new System.Drawing.Size(357, 83);
            this.lbEnemyList.TabIndex = 13;
            this.lbEnemyList.Text = "enemy";
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
            this.pnlStatus.Location = new System.Drawing.Point(0, 323);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(800, 127);
            this.pnlStatus.TabIndex = 1;
            // 
            // lbBedCount
            // 
            this.lbBedCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBedCount.Location = new System.Drawing.Point(529, 59);
            this.lbBedCount.Name = "lbBedCount";
            this.lbBedCount.Size = new System.Drawing.Size(91, 19);
            this.lbBedCount.TabIndex = 11;
            this.lbBedCount.Text = "Bed Count";
            // 
            // teBedCount
            // 
            this.teBedCount.Location = new System.Drawing.Point(621, 57);
            this.teBedCount.Name = "teBedCount";
            this.teBedCount.ReadOnly = true;
            this.teBedCount.Size = new System.Drawing.Size(105, 22);
            this.teBedCount.TabIndex = 10;
            // 
            // lbFoodCount
            // 
            this.lbFoodCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFoodCount.Location = new System.Drawing.Point(529, 25);
            this.lbFoodCount.Name = "lbFoodCount";
            this.lbFoodCount.Size = new System.Drawing.Size(91, 19);
            this.lbFoodCount.TabIndex = 9;
            this.lbFoodCount.Text = "Food Count";
            // 
            // teFoodCount
            // 
            this.teFoodCount.Location = new System.Drawing.Point(621, 24);
            this.teFoodCount.Name = "teFoodCount";
            this.teFoodCount.ReadOnly = true;
            this.teFoodCount.Size = new System.Drawing.Size(105, 22);
            this.teFoodCount.TabIndex = 8;
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotalCount.Location = new System.Drawing.Point(223, 94);
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Size = new System.Drawing.Size(80, 19);
            this.lbTotalCount.TabIndex = 7;
            this.lbTotalCount.Text = "Total Count";
            // 
            // teTotalCount
            // 
            this.teTotalCount.Location = new System.Drawing.Point(309, 93);
            this.teTotalCount.Name = "teTotalCount";
            this.teTotalCount.ReadOnly = true;
            this.teTotalCount.Size = new System.Drawing.Size(105, 22);
            this.teTotalCount.TabIndex = 6;
            // 
            // lbSoilder
            // 
            this.lbSoilder.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSoilder.Location = new System.Drawing.Point(13, 94);
            this.lbSoilder.Name = "lbSoilder";
            this.lbSoilder.Size = new System.Drawing.Size(91, 19);
            this.lbSoilder.TabIndex = 5;
            this.lbSoilder.Text = "Soilder Count";
            // 
            // teSoilderCount
            // 
            this.teSoilderCount.Location = new System.Drawing.Point(106, 93);
            this.teSoilderCount.Name = "teSoilderCount";
            this.teSoilderCount.ReadOnly = true;
            this.teSoilderCount.Size = new System.Drawing.Size(105, 22);
            this.teSoilderCount.TabIndex = 4;
            // 
            // lbBuilder
            // 
            this.lbBuilder.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBuilder.Location = new System.Drawing.Point(13, 58);
            this.lbBuilder.Name = "lbBuilder";
            this.lbBuilder.Size = new System.Drawing.Size(91, 19);
            this.lbBuilder.TabIndex = 3;
            this.lbBuilder.Text = "Builder Count";
            // 
            // teBuilderCount
            // 
            this.teBuilderCount.Location = new System.Drawing.Point(106, 57);
            this.teBuilderCount.Name = "teBuilderCount";
            this.teBuilderCount.ReadOnly = true;
            this.teBuilderCount.Size = new System.Drawing.Size(105, 22);
            this.teBuilderCount.TabIndex = 2;
            // 
            // lbFarmer
            // 
            this.lbFarmer.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFarmer.Location = new System.Drawing.Point(13, 25);
            this.lbFarmer.Name = "lbFarmer";
            this.lbFarmer.Size = new System.Drawing.Size(91, 19);
            this.lbFarmer.TabIndex = 1;
            this.lbFarmer.Text = "Farmer Count";
            // 
            // teFarmerCount
            // 
            this.teFarmerCount.Location = new System.Drawing.Point(106, 24);
            this.teFarmerCount.Name = "teFarmerCount";
            this.teFarmerCount.ReadOnly = true;
            this.teFarmerCount.Size = new System.Drawing.Size(105, 22);
            this.teFarmerCount.TabIndex = 0;
            // 
            // pnlRecruitCharacters
            // 
            this.pnlRecruitCharacters.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlRecruitCharacters.Location = new System.Drawing.Point(0, 0);
            this.pnlRecruitCharacters.Name = "pnlRecruitCharacters";
            this.pnlRecruitCharacters.Size = new System.Drawing.Size(116, 317);
            this.pnlRecruitCharacters.TabIndex = 0;
            // 
            // lbAlly
            // 
            this.lbAlly.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAlly.Location = new System.Drawing.Point(3, 237);
            this.lbAlly.Name = "lbAlly";
            this.lbAlly.Size = new System.Drawing.Size(295, 83);
            this.lbAlly.TabIndex = 25;
            this.lbAlly.Text = "ally";
            this.lbAlly.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbEnemy
            // 
            this.lbEnemy.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEnemy.Location = new System.Drawing.Point(318, 237);
            this.lbEnemy.Name = "lbEnemy";
            this.lbEnemy.Size = new System.Drawing.Size(357, 83);
            this.lbEnemy.TabIndex = 26;
            this.lbEnemy.Text = "enemy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnEndRound;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lbNowRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEnemy;
        private System.Windows.Forms.Label lbAlly;
    }
}

