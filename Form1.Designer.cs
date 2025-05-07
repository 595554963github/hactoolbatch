namespace HactoolUnpacker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnSelectXci = new System.Windows.Forms.Button();
            this.btnUnpackXCI = new System.Windows.Forms.Button();
            this.btnSelectNca = new System.Windows.Forms.Button();
            this.btnUnpackNCA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(560, 300);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // btnSelectXci
            // 
            this.btnSelectXci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectXci.Location = new System.Drawing.Point(12, 318);
            this.btnSelectXci.Name = "btnSelectXci";
            this.btnSelectXci.Size = new System.Drawing.Size(120, 30);
            this.btnSelectXci.TabIndex = 1;
            this.btnSelectXci.Text = "选择XCI文件";
            this.btnSelectXci.UseVisualStyleBackColor = true;
            this.btnSelectXci.Click += new System.EventHandler(this.btnSelectXci_Click);
            // 
            // btnUnpackXCI
            // 
            this.btnUnpackXCI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnpackXCI.Location = new System.Drawing.Point(138, 318);
            this.btnUnpackXCI.Name = "btnUnpackXCI";
            this.btnUnpackXCI.Size = new System.Drawing.Size(120, 30);
            this.btnUnpackXCI.TabIndex = 2;
            this.btnUnpackXCI.Text = "解包XCI";
            this.btnUnpackXCI.UseVisualStyleBackColor = true;
            this.btnUnpackXCI.Click += new System.EventHandler(this.btnUnpackXCI_Click);
            // 
            // btnSelectNca
            // 
            this.btnSelectNca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectNca.Location = new System.Drawing.Point(264, 318);
            this.btnSelectNca.Name = "btnSelectNca";
            this.btnSelectNca.Size = new System.Drawing.Size(120, 30);
            this.btnSelectNca.TabIndex = 3;
            this.btnSelectNca.Text = "选择NCA文件";
            this.btnSelectNca.UseVisualStyleBackColor = true;
            this.btnSelectNca.Click += new System.EventHandler(this.btnSelectNca_Click);
            // 
            // btnUnpackNCA
            // 
            this.btnUnpackNCA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnpackNCA.Location = new System.Drawing.Point(390, 318);
            this.btnUnpackNCA.Name = "btnUnpackNCA";
            this.btnUnpackNCA.Size = new System.Drawing.Size(120, 30);
            this.btnUnpackNCA.TabIndex = 4;
            this.btnUnpackNCA.Text = "解包NCA";
            this.btnUnpackNCA.UseVisualStyleBackColor = true;
            this.btnUnpackNCA.Click += new System.EventHandler(this.btnUnpackNCA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnUnpackNCA);
            this.Controls.Add(this.btnSelectNca);
            this.Controls.Add(this.btnUnpackXCI);
            this.Controls.Add(this.btnSelectXci);
            this.Controls.Add(this.rtbOutput);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Hactool解包工具";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnSelectXci;
        private System.Windows.Forms.Button btnUnpackXCI;
        private System.Windows.Forms.Button btnSelectNca;
        private System.Windows.Forms.Button btnUnpackNCA;
    }
}