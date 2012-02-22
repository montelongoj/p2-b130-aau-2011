namespace BagPacker
{
    partial class frmLug
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
            this.lblLugInfo = new System.Windows.Forms.Label();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.txtLugWidth = new System.Windows.Forms.TextBox();
            this.txtLugHeigth = new System.Windows.Forms.TextBox();
            this.txtLugDepth = new System.Windows.Forms.TextBox();
            this.txtLugWeigth = new System.Windows.Forms.TextBox();
            this.lblLugWidth = new System.Windows.Forms.Label();
            this.lblLugHeigth = new System.Windows.Forms.Label();
            this.lblLugDepth = new System.Windows.Forms.Label();
            this.lblLugWeigth = new System.Windows.Forms.Label();
            this.btnInfoSave = new System.Windows.Forms.Button();
            this.cboLugDistUnit = new System.Windows.Forms.ComboBox();
            this.lstLuggages = new System.Windows.Forms.ListView();
            this.cboLugWeightUnit = new System.Windows.Forms.ComboBox();
            this.lblLugDistUnit1 = new System.Windows.Forms.Label();
            this.lblLugDistUnit2 = new System.Windows.Forms.Label();
            this.lblLugDistUnit3 = new System.Windows.Forms.Label();
            this.lblLugName = new System.Windows.Forms.Label();
            this.txtLugName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLugInfo
            // 
            this.lblLugInfo.AutoSize = true;
            this.lblLugInfo.Location = new System.Drawing.Point(120, 102);
            this.lblLugInfo.Name = "lblLugInfo";
            this.lblLugInfo.Size = new System.Drawing.Size(125, 13);
            this.lblLugInfo.TabIndex = 0;
            this.lblLugInfo.Text = "The info of your luggage:";
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHeadline.Location = new System.Drawing.Point(214, 26);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(248, 26);
            this.lblHeadline.TabIndex = 1;
            this.lblHeadline.Text = "The BagPacker program";
            // 
            // txtLugWidth
            // 
            this.txtLugWidth.Location = new System.Drawing.Point(170, 118);
            this.txtLugWidth.Name = "txtLugWidth";
            this.txtLugWidth.Size = new System.Drawing.Size(75, 20);
            this.txtLugWidth.TabIndex = 2;
            // 
            // txtLugHeigth
            // 
            this.txtLugHeigth.Location = new System.Drawing.Point(170, 144);
            this.txtLugHeigth.Name = "txtLugHeigth";
            this.txtLugHeigth.Size = new System.Drawing.Size(75, 20);
            this.txtLugHeigth.TabIndex = 3;
            // 
            // txtLugDepth
            // 
            this.txtLugDepth.Location = new System.Drawing.Point(170, 170);
            this.txtLugDepth.Name = "txtLugDepth";
            this.txtLugDepth.Size = new System.Drawing.Size(75, 20);
            this.txtLugDepth.TabIndex = 4;
            // 
            // txtLugWeigth
            // 
            this.txtLugWeigth.Location = new System.Drawing.Point(170, 196);
            this.txtLugWeigth.Name = "txtLugWeigth";
            this.txtLugWeigth.Size = new System.Drawing.Size(75, 20);
            this.txtLugWeigth.TabIndex = 5;
            // 
            // lblLugWidth
            // 
            this.lblLugWidth.AutoSize = true;
            this.lblLugWidth.Location = new System.Drawing.Point(129, 121);
            this.lblLugWidth.Name = "lblLugWidth";
            this.lblLugWidth.Size = new System.Drawing.Size(38, 13);
            this.lblLugWidth.TabIndex = 6;
            this.lblLugWidth.Text = "Width:";
            // 
            // lblLugHeigth
            // 
            this.lblLugHeigth.AutoSize = true;
            this.lblLugHeigth.Location = new System.Drawing.Point(129, 147);
            this.lblLugHeigth.Name = "lblLugHeigth";
            this.lblLugHeigth.Size = new System.Drawing.Size(41, 13);
            this.lblLugHeigth.TabIndex = 7;
            this.lblLugHeigth.Text = "Heigth:";
            // 
            // lblLugDepth
            // 
            this.lblLugDepth.AutoSize = true;
            this.lblLugDepth.Location = new System.Drawing.Point(129, 173);
            this.lblLugDepth.Name = "lblLugDepth";
            this.lblLugDepth.Size = new System.Drawing.Size(39, 13);
            this.lblLugDepth.TabIndex = 8;
            this.lblLugDepth.Text = "Depth:";
            // 
            // lblLugWeigth
            // 
            this.lblLugWeigth.AutoSize = true;
            this.lblLugWeigth.Location = new System.Drawing.Point(129, 199);
            this.lblLugWeigth.Name = "lblLugWeigth";
            this.lblLugWeigth.Size = new System.Drawing.Size(44, 13);
            this.lblLugWeigth.TabIndex = 9;
            this.lblLugWeigth.Text = "Weigth:";
            // 
            // btnInfoSave
            // 
            this.btnInfoSave.Location = new System.Drawing.Point(132, 222);
            this.btnInfoSave.Name = "btnInfoSave";
            this.btnInfoSave.Size = new System.Drawing.Size(115, 29);
            this.btnInfoSave.TabIndex = 11;
            this.btnInfoSave.Text = "Save";
            this.btnInfoSave.UseVisualStyleBackColor = true;
            this.btnInfoSave.Click += new System.EventHandler(this.btnInfoSave_Click);
            // 
            // cboLugDistUnit
            // 
            this.cboLugDistUnit.FormattingEnabled = true;
            this.cboLugDistUnit.Location = new System.Drawing.Point(251, 94);
            this.cboLugDistUnit.Name = "cboLugDistUnit";
            this.cboLugDistUnit.Size = new System.Drawing.Size(65, 21);
            this.cboLugDistUnit.TabIndex = 12;
            this.cboLugDistUnit.SelectedIndexChanged += new System.EventHandler(this.cboLugDistUnit_SelectedIndexChanged);
            // 
            // lstLuggages
            // 
            this.lstLuggages.Location = new System.Drawing.Point(1, 65);
            this.lstLuggages.Name = "lstLuggages";
            this.lstLuggages.Size = new System.Drawing.Size(115, 174);
            this.lstLuggages.TabIndex = 13;
            this.lstLuggages.UseCompatibleStateImageBehavior = false;
            this.lstLuggages.View = System.Windows.Forms.View.List;
            // 
            // cboLugWeightUnit
            // 
            this.cboLugWeightUnit.FormattingEnabled = true;
            this.cboLugWeightUnit.Location = new System.Drawing.Point(251, 195);
            this.cboLugWeightUnit.Name = "cboLugWeightUnit";
            this.cboLugWeightUnit.Size = new System.Drawing.Size(65, 21);
            this.cboLugWeightUnit.TabIndex = 14;
            // 
            // lblLugDistUnit1
            // 
            this.lblLugDistUnit1.AutoSize = true;
            this.lblLugDistUnit1.Location = new System.Drawing.Point(251, 121);
            this.lblLugDistUnit1.Name = "lblLugDistUnit1";
            this.lblLugDistUnit1.Size = new System.Drawing.Size(0, 13);
            this.lblLugDistUnit1.TabIndex = 15;
            // 
            // lblLugDistUnit2
            // 
            this.lblLugDistUnit2.AutoSize = true;
            this.lblLugDistUnit2.Location = new System.Drawing.Point(251, 147);
            this.lblLugDistUnit2.Name = "lblLugDistUnit2";
            this.lblLugDistUnit2.Size = new System.Drawing.Size(0, 13);
            this.lblLugDistUnit2.TabIndex = 16;
            // 
            // lblLugDistUnit3
            // 
            this.lblLugDistUnit3.AutoSize = true;
            this.lblLugDistUnit3.Location = new System.Drawing.Point(251, 173);
            this.lblLugDistUnit3.Name = "lblLugDistUnit3";
            this.lblLugDistUnit3.Size = new System.Drawing.Size(0, 13);
            this.lblLugDistUnit3.TabIndex = 17;
            // 
            // lblLugName
            // 
            this.lblLugName.AutoSize = true;
            this.lblLugName.Location = new System.Drawing.Point(122, 65);
            this.lblLugName.Name = "lblLugName";
            this.lblLugName.Size = new System.Drawing.Size(91, 13);
            this.lblLugName.TabIndex = 18;
            this.lblLugName.Text = "Name of luggage:";
            // 
            // txtLugName
            // 
            this.txtLugName.Location = new System.Drawing.Point(219, 58);
            this.txtLugName.Name = "txtLugName";
            this.txtLugName.Size = new System.Drawing.Size(96, 20);
            this.txtLugName.TabIndex = 19;
            // 
            // frmLug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 438);
            this.Controls.Add(this.txtLugName);
            this.Controls.Add(this.lblLugName);
            this.Controls.Add(this.lblLugDistUnit3);
            this.Controls.Add(this.lblLugDistUnit2);
            this.Controls.Add(this.lblLugDistUnit1);
            this.Controls.Add(this.cboLugWeightUnit);
            this.Controls.Add(this.lstLuggages);
            this.Controls.Add(this.cboLugDistUnit);
            this.Controls.Add(this.btnInfoSave);
            this.Controls.Add(this.lblLugWeigth);
            this.Controls.Add(this.lblLugDepth);
            this.Controls.Add(this.lblLugHeigth);
            this.Controls.Add(this.lblLugWidth);
            this.Controls.Add(this.txtLugWeigth);
            this.Controls.Add(this.txtLugDepth);
            this.Controls.Add(this.txtLugHeigth);
            this.Controls.Add(this.txtLugWidth);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.lblLugInfo);
            this.Name = "frmLug";
            this.Text = "BagPacker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLugInfo;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.TextBox txtLugWidth;
        private System.Windows.Forms.TextBox txtLugHeigth;
        private System.Windows.Forms.TextBox txtLugDepth;
        private System.Windows.Forms.TextBox txtLugWeigth;
        private System.Windows.Forms.Label lblLugWidth;
        private System.Windows.Forms.Label lblLugHeigth;
        private System.Windows.Forms.Label lblLugDepth;
        private System.Windows.Forms.Label lblLugWeigth;
        private System.Windows.Forms.Button btnInfoSave;
        private System.Windows.Forms.ComboBox cboLugDistUnit;
        private System.Windows.Forms.ListView lstLuggages;
        private System.Windows.Forms.ComboBox cboLugWeightUnit;
        private System.Windows.Forms.Label lblLugDistUnit1;
        private System.Windows.Forms.Label lblLugDistUnit2;
        private System.Windows.Forms.Label lblLugDistUnit3;
        private System.Windows.Forms.Label lblLugName;
        private System.Windows.Forms.TextBox txtLugName;
    }
}

