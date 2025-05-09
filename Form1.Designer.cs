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
            rtbOutput = new RichTextBox();
            btnSelectXci = new Button();
            btnUnpackXCI = new Button();
            btnSelectNca = new Button();
            btnUnpackNCA = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // rtbOutput
            // 
            rtbOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbOutput.Location = new Point(14, 17);
            rtbOutput.Margin = new Padding(4, 4, 4, 4);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(653, 407);
            rtbOutput.TabIndex = 0;
            rtbOutput.Text = "";
            // 
            // btnSelectXci
            // 
            btnSelectXci.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSelectXci.Location = new Point(14, 450);
            btnSelectXci.Margin = new Padding(4, 4, 4, 4);
            btnSelectXci.Name = "btnSelectXci";
            btnSelectXci.Size = new Size(140, 42);
            btnSelectXci.TabIndex = 1;
            btnSelectXci.Text = "选择XCI文件";
            btnSelectXci.UseVisualStyleBackColor = true;
            btnSelectXci.Click += btnSelectXci_Click;
            // 
            // btnUnpackXCI
            // 
            btnUnpackXCI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUnpackXCI.Location = new Point(161, 450);
            btnUnpackXCI.Margin = new Padding(4, 4, 4, 4);
            btnUnpackXCI.Name = "btnUnpackXCI";
            btnUnpackXCI.Size = new Size(140, 42);
            btnUnpackXCI.TabIndex = 2;
            btnUnpackXCI.Text = "解包XCI";
            btnUnpackXCI.UseVisualStyleBackColor = true;
            btnUnpackXCI.Click += btnUnpackXCI_Click;
            // 
            // btnSelectNca
            // 
            btnSelectNca.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSelectNca.Location = new Point(308, 450);
            btnSelectNca.Margin = new Padding(4, 4, 4, 4);
            btnSelectNca.Name = "btnSelectNca";
            btnSelectNca.Size = new Size(140, 42);
            btnSelectNca.TabIndex = 3;
            btnSelectNca.Text = "选择NCA文件";
            btnSelectNca.UseVisualStyleBackColor = true;
            btnSelectNca.Click += btnSelectNca_Click;
            // 
            // btnUnpackNCA
            // 
            btnUnpackNCA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUnpackNCA.Location = new Point(455, 450);
            btnUnpackNCA.Margin = new Padding(4, 4, 4, 4);
            btnUnpackNCA.Name = "btnUnpackNCA";
            btnUnpackNCA.Size = new Size(140, 42);
            btnUnpackNCA.TabIndex = 4;
            btnUnpackNCA.Text = "解包NCA";
            btnUnpackNCA.UseVisualStyleBackColor = true;
            btnUnpackNCA.Click += btnUnpackNCA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(161, 428);
            label1.Name = "label1";
            label1.Size = new Size(287, 17);
            label1.TabIndex = 5;
            label1.Text = "注:解包前请把rom放到一个不含中文的根目录！！！";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 511);
            Controls.Add(label1);
            Controls.Add(btnUnpackNCA);
            Controls.Add(btnSelectNca);
            Controls.Add(btnUnpackXCI);
            Controls.Add(btnSelectXci);
            Controls.Add(rtbOutput);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(697, 550);
            Name = "Form1";
            Text = "Hactool解包工具";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnSelectXci;
        private System.Windows.Forms.Button btnUnpackXCI;
        private System.Windows.Forms.Button btnSelectNca;
        private System.Windows.Forms.Button btnUnpackNCA;
        private Label label1;
    }
}
