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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.Info;
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
            // pnlGame
            // 
            this.pnlGame.Location = new System.Drawing.Point(122, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(675, 317);
            this.pnlGame.TabIndex = 2;
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
    }
}

