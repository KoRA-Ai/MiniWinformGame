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
            this.btnSeq1 = new System.Windows.Forms.Button();
            this.btnSeq3 = new System.Windows.Forms.Button();
            this.btnSeq2 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
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
            this.pnlGame.Controls.Add(this.btnLog);
            this.pnlGame.Controls.Add(this.btnSeq1);
            this.pnlGame.Controls.Add(this.btnSeq3);
            this.pnlGame.Controls.Add(this.btnSeq2);
            this.pnlGame.Controls.Add(this.btnSetting);
            this.pnlGame.Controls.Add(this.hpEnemy);
            this.pnlGame.Controls.Add(this.hpAlly);
            this.pnlGame.Controls.Add(this.lbAllyList);
            this.pnlGame.Controls.Add(this.lbEnemyList);
            this.pnlGame.Location = new System.Drawing.Point(122, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(675, 317);
            this.pnlGame.TabIndex = 2;
            // 
            // btnSeq1
            // 
            this.btnSeq1.Location = new System.Drawing.Point(336, 267);
            this.btnSeq1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeq1.Name = "btnSeq1";
            this.btnSeq1.Size = new System.Drawing.Size(50, 42);
            this.btnSeq1.TabIndex = 21;
            this.btnSeq1.Text = "1";
            this.btnSeq1.UseVisualStyleBackColor = true;
            // 
            // btnSeq3
            // 
            this.btnSeq3.Location = new System.Drawing.Point(487, 267);
            this.btnSeq3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeq3.Name = "btnSeq3";
            this.btnSeq3.Size = new System.Drawing.Size(50, 42);
            this.btnSeq3.TabIndex = 20;
            this.btnSeq3.Text = "3";
            this.btnSeq3.UseVisualStyleBackColor = true;
            // 
            // btnSeq2
            // 
            this.btnSeq2.Location = new System.Drawing.Point(409, 267);
            this.btnSeq2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeq2.Name = "btnSeq2";
            this.btnSeq2.Size = new System.Drawing.Size(50, 42);
            this.btnSeq2.TabIndex = 19;
            this.btnSeq2.Text = "2";
            this.btnSeq2.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(291, 8);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(50, 42);
            this.btnSetting.TabIndex = 18;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
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
            this.pnlStatus.Controls.Add(this.btnStart);
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(325, 17);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 32);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "開始回合";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(361, 8);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(50, 42);
            this.btnLog.TabIndex = 22;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnSeq3;
        private System.Windows.Forms.Button btnSeq2;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSeq1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLog;
    }
}

