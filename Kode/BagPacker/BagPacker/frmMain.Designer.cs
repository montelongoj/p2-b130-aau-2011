namespace BagPacker
{
    partial class frmMain
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
            this.btnOpenLug = new System.Windows.Forms.Button();
            this.bntStartPacking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenLug
            // 
            this.btnOpenLug.Location = new System.Drawing.Point(154, 62);
            this.btnOpenLug.Name = "btnOpenLug";
            this.btnOpenLug.Size = new System.Drawing.Size(101, 42);
            this.btnOpenLug.TabIndex = 0;
            this.btnOpenLug.Text = "Manage Luggage";
            this.btnOpenLug.UseVisualStyleBackColor = true;
            this.btnOpenLug.Click += new System.EventHandler(this.btnOpenLug_Click);
            // 
            // bntStartPacking
            // 
            this.bntStartPacking.Location = new System.Drawing.Point(154, 110);
            this.bntStartPacking.Name = "bntStartPacking";
            this.bntStartPacking.Size = new System.Drawing.Size(101, 36);
            this.bntStartPacking.TabIndex = 1;
            this.bntStartPacking.Text = "Start Packing";
            this.bntStartPacking.UseVisualStyleBackColor = true;
            this.bntStartPacking.Click += new System.EventHandler(this.bntStartPacking_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntStartPacking);
            this.Controls.Add(this.btnOpenLug);
            this.Name = "frmMain";
            this.Text = "The BagPacker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenLug;
        private System.Windows.Forms.Button bntStartPacking;
    }
}