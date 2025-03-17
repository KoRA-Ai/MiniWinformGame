namespace GameUI
{
    partial class FormMain01
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
            this.panel01 = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.teBuilderCount = new System.Windows.Forms.TextBox();
            this.teFarmerCount = new System.Windows.Forms.TextBox();
            this.teTotalCount = new System.Windows.Forms.TextBox();
            this.lbBedCount = new System.Windows.Forms.Label();
            this.lbSoilder = new System.Windows.Forms.Label();
            this.lbFarmer = new System.Windows.Forms.Label();
            this.lbTotalCount = new System.Windows.Forms.Label();
            this.teBedCount = new System.Windows.Forms.TextBox();
            this.teSoilderCount = new System.Windows.Forms.TextBox();
            this.teFoodCount = new System.Windows.Forms.TextBox();
            this.lbFoodCount = new System.Windows.Forms.Label();
            this.lbBuilder = new System.Windows.Forms.Label();
            this.teEnemyCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel01.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel01
            // 
            this.panel01.Controls.Add(this.panelStatus);
            this.panel01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel01.Location = new System.Drawing.Point(0, 0);
            this.panel01.Name = "panel01";
            this.panel01.Size = new System.Drawing.Size(800, 450);
            this.panel01.TabIndex = 0;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.splitContainer1);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(800, 450);
            this.panelStatus.TabIndex = 24;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.teEnemyCount);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.teBuilderCount);
            this.splitContainer1.Panel1.Controls.Add(this.teFarmerCount);
            this.splitContainer1.Panel1.Controls.Add(this.teTotalCount);
            this.splitContainer1.Panel1.Controls.Add(this.lbBedCount);
            this.splitContainer1.Panel1.Controls.Add(this.lbSoilder);
            this.splitContainer1.Panel1.Controls.Add(this.lbFarmer);
            this.splitContainer1.Panel1.Controls.Add(this.lbTotalCount);
            this.splitContainer1.Panel1.Controls.Add(this.teBedCount);
            this.splitContainer1.Panel1.Controls.Add(this.teSoilderCount);
            this.splitContainer1.Panel1.Controls.Add(this.teFoodCount);
            this.splitContainer1.Panel1.Controls.Add(this.lbFoodCount);
            this.splitContainer1.Panel1.Controls.Add(this.lbBuilder);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 24;
            // 
            // teBuilderCount
            // 
            this.teBuilderCount.Location = new System.Drawing.Point(196, 14);
            this.teBuilderCount.Name = "teBuilderCount";
            this.teBuilderCount.ReadOnly = true;
            this.teBuilderCount.Size = new System.Drawing.Size(67, 22);
            this.teBuilderCount.TabIndex = 14;
            // 
            // teFarmerCount
            // 
            this.teFarmerCount.Location = new System.Drawing.Point(77, 14);
            this.teFarmerCount.Name = "teFarmerCount";
            this.teFarmerCount.ReadOnly = true;
            this.teFarmerCount.Size = new System.Drawing.Size(60, 22);
            this.teFarmerCount.TabIndex = 12;
            // 
            // teTotalCount
            // 
            this.teTotalCount.Location = new System.Drawing.Point(462, 17);
            this.teTotalCount.Name = "teTotalCount";
            this.teTotalCount.ReadOnly = true;
            this.teTotalCount.Size = new System.Drawing.Size(85, 22);
            this.teTotalCount.TabIndex = 18;
            // 
            // lbBedCount
            // 
            this.lbBedCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBedCount.Location = new System.Drawing.Point(164, 52);
            this.lbBedCount.Name = "lbBedCount";
            this.lbBedCount.Size = new System.Drawing.Size(33, 19);
            this.lbBedCount.TabIndex = 23;
            this.lbBedCount.Text = "Bed";
            // 
            // lbSoilder
            // 
            this.lbSoilder.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSoilder.Location = new System.Drawing.Point(273, 18);
            this.lbSoilder.Name = "lbSoilder";
            this.lbSoilder.Size = new System.Drawing.Size(51, 19);
            this.lbSoilder.TabIndex = 17;
            this.lbSoilder.Text = "Soilder";
            // 
            // lbFarmer
            // 
            this.lbFarmer.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFarmer.Location = new System.Drawing.Point(17, 18);
            this.lbFarmer.Name = "lbFarmer";
            this.lbFarmer.Size = new System.Drawing.Size(54, 19);
            this.lbFarmer.TabIndex = 13;
            this.lbFarmer.Text = "Farmer";
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotalCount.Location = new System.Drawing.Point(418, 20);
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Size = new System.Drawing.Size(38, 19);
            this.lbTotalCount.TabIndex = 19;
            this.lbTotalCount.Text = "Total";
            // 
            // teBedCount
            // 
            this.teBedCount.Location = new System.Drawing.Point(196, 49);
            this.teBedCount.Name = "teBedCount";
            this.teBedCount.ReadOnly = true;
            this.teBedCount.Size = new System.Drawing.Size(67, 22);
            this.teBedCount.TabIndex = 22;
            // 
            // teSoilderCount
            // 
            this.teSoilderCount.Location = new System.Drawing.Point(330, 17);
            this.teSoilderCount.Name = "teSoilderCount";
            this.teSoilderCount.ReadOnly = true;
            this.teSoilderCount.Size = new System.Drawing.Size(68, 22);
            this.teSoilderCount.TabIndex = 16;
            // 
            // teFoodCount
            // 
            this.teFoodCount.Location = new System.Drawing.Point(77, 48);
            this.teFoodCount.Name = "teFoodCount";
            this.teFoodCount.ReadOnly = true;
            this.teFoodCount.Size = new System.Drawing.Size(60, 22);
            this.teFoodCount.TabIndex = 20;
            // 
            // lbFoodCount
            // 
            this.lbFoodCount.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFoodCount.Location = new System.Drawing.Point(27, 50);
            this.lbFoodCount.Name = "lbFoodCount";
            this.lbFoodCount.Size = new System.Drawing.Size(44, 19);
            this.lbFoodCount.TabIndex = 21;
            this.lbFoodCount.Text = "Food";
            // 
            // lbBuilder
            // 
            this.lbBuilder.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBuilder.Location = new System.Drawing.Point(146, 18);
            this.lbBuilder.Name = "lbBuilder";
            this.lbBuilder.Size = new System.Drawing.Size(51, 19);
            this.lbBuilder.TabIndex = 15;
            this.lbBuilder.Text = "Builder";
            // 
            // teEnemyCount
            // 
            this.teEnemyCount.Location = new System.Drawing.Point(709, 15);
            this.teEnemyCount.Name = "teEnemyCount";
            this.teEnemyCount.ReadOnly = true;
            this.teEnemyCount.Size = new System.Drawing.Size(78, 22);
            this.teEnemyCount.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(639, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enemy";
            // 
            // FormMain01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel01);
            this.Name = "FormMain01";
            this.Text = "FormMain01";
            this.panel01.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel01;
        private System.Windows.Forms.Label lbBedCount;
        private System.Windows.Forms.TextBox teBedCount;
        private System.Windows.Forms.Label lbFoodCount;
        private System.Windows.Forms.TextBox teFoodCount;
        private System.Windows.Forms.Label lbTotalCount;
        private System.Windows.Forms.TextBox teTotalCount;
        private System.Windows.Forms.Label lbSoilder;
        private System.Windows.Forms.TextBox teSoilderCount;
        private System.Windows.Forms.Label lbBuilder;
        private System.Windows.Forms.TextBox teBuilderCount;
        private System.Windows.Forms.Label lbFarmer;
        private System.Windows.Forms.TextBox teFarmerCount;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox teEnemyCount;
        private System.Windows.Forms.Label label1;
    }
}