namespace GameUI
{
    partial class FormStoryBoard02
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
            this.label1 = new System.Windows.Forms.Label();
            this.teBuilderCount = new System.Windows.Forms.TextBox();
            this.teFarmerCount = new System.Windows.Forms.TextBox();
            this.lbSoilder = new System.Windows.Forms.Label();
            this.lbFarmer = new System.Windows.Forms.Label();
            this.teSoilderCount = new System.Windows.Forms.TextBox();
            this.lbBuilder = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入各角色數量";
            // 
            // teBuilderCount
            // 
            this.teBuilderCount.Location = new System.Drawing.Point(372, 164);
            this.teBuilderCount.Name = "teBuilderCount";
            this.teBuilderCount.Size = new System.Drawing.Size(67, 22);
            this.teBuilderCount.TabIndex = 20;
            // 
            // teFarmerCount
            // 
            this.teFarmerCount.Location = new System.Drawing.Point(372, 119);
            this.teFarmerCount.Name = "teFarmerCount";
            this.teFarmerCount.Size = new System.Drawing.Size(67, 22);
            this.teFarmerCount.TabIndex = 18;
            // 
            // lbSoilder
            // 
            this.lbSoilder.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSoilder.Location = new System.Drawing.Point(315, 207);
            this.lbSoilder.Name = "lbSoilder";
            this.lbSoilder.Size = new System.Drawing.Size(51, 19);
            this.lbSoilder.TabIndex = 23;
            this.lbSoilder.Text = "Soilder";
            // 
            // lbFarmer
            // 
            this.lbFarmer.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFarmer.Location = new System.Drawing.Point(315, 120);
            this.lbFarmer.Name = "lbFarmer";
            this.lbFarmer.Size = new System.Drawing.Size(54, 19);
            this.lbFarmer.TabIndex = 19;
            this.lbFarmer.Text = "Farmer";
            // 
            // teSoilderCount
            // 
            this.teSoilderCount.Location = new System.Drawing.Point(372, 206);
            this.teSoilderCount.Name = "teSoilderCount";
            this.teSoilderCount.Size = new System.Drawing.Size(68, 22);
            this.teSoilderCount.TabIndex = 22;
            // 
            // lbBuilder
            // 
            this.lbBuilder.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBuilder.Location = new System.Drawing.Point(315, 167);
            this.lbBuilder.Name = "lbBuilder";
            this.lbBuilder.Size = new System.Drawing.Size(51, 19);
            this.lbBuilder.TabIndex = 21;
            this.lbBuilder.Text = "Builder";
            // 
            // labelMsg
            // 
            this.labelMsg.Location = new System.Drawing.Point(260, 250);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(234, 92);
            this.labelMsg.TabIndex = 24;
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(500, 120);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 26;
            this.btnView.Text = "預覽";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(500, 167);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "開始遊戲";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // FormStoryBoard02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.teBuilderCount);
            this.Controls.Add(this.teFarmerCount);
            this.Controls.Add(this.lbSoilder);
            this.Controls.Add(this.lbFarmer);
            this.Controls.Add(this.teSoilderCount);
            this.Controls.Add(this.lbBuilder);
            this.Controls.Add(this.label1);
            this.Name = "FormStoryBoard02";
            this.Text = "FormStoryBoard02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teBuilderCount;
        private System.Windows.Forms.TextBox teFarmerCount;
        private System.Windows.Forms.Label lbSoilder;
        private System.Windows.Forms.Label lbFarmer;
        private System.Windows.Forms.TextBox teSoilderCount;
        private System.Windows.Forms.Label lbBuilder;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnConfirm;
    }
}