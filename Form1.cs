using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HactoolUnpacker
{
    public partial class Form1 : Form
    {
        private string selectedXciFilePath = "";
        private string selectedNcaFilePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void SelectXciFile()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "选择XCI文件";
                dialog.Filter = "XCI文件 (*.xci)|*.xci";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedXciFilePath = dialog.FileName;
                    UpdateRichTextBox($"已选择XCI文件: {selectedXciFilePath}");
                }
            }
        }

        private void SelectNcaFile()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "选择NCA文件";
                dialog.Filter = "NCA文件 (*.nca)|*.nca";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedNcaFilePath = dialog.FileName;
                    UpdateRichTextBox($"已选择NCA文件: {selectedNcaFilePath}");
                }
            }
        }

        private void UnpackXCI()
        {
            if (!string.IsNullOrEmpty(selectedXciFilePath))
            {
                string encodedFilePath = Encoding.UTF8.GetString(Encoding.Default.GetBytes(selectedXciFilePath));
                UpdateRichTextBox($"开始解包XCI文件: {encodedFilePath}");

                new Thread(() =>
                {
                    string? directoryName = Path.GetDirectoryName(encodedFilePath);
                    if (directoryName != null)
                    {
                        string outDir = Path.Combine(directoryName, "XCI_Extracted");
                        Directory.CreateDirectory(outDir);
                        RunProcess("hactool.exe", $"-t xci \"{encodedFilePath}\" --outdir \"{outDir}\"");
                    }
                    else
                    {
                        UpdateRichTextBox("无法获取文件路径的目录名。");
                    }
                }).Start();
            }
            else
            {
                UpdateRichTextBox("请先选择XCI文件再进行解包操作。");
            }
        }

        private void UnpackNCA()
        {
            if (!string.IsNullOrEmpty(selectedNcaFilePath))
            {
                string encodedFilePath = Encoding.UTF8.GetString(Encoding.Default.GetBytes(selectedNcaFilePath));
                UpdateRichTextBox($"开始解包NCA文件: {encodedFilePath}");

                new Thread(() =>
                {
                    string? directoryName = Path.GetDirectoryName(encodedFilePath);
                    if (directoryName != null)
                    {
                        string outDir = Path.Combine(directoryName, "NCA_Extracted");
                        Directory.CreateDirectory(outDir);
                        Directory.CreateDirectory(Path.Combine(outDir, "romfs"));
                        Directory.CreateDirectory(Path.Combine(outDir, "exefs"));
                        RunProcess("hactool.exe", $"-x -k keys.ini --romfsdir \"{outDir}/romfs\" --exefsdir \"{outDir}/exefs\" \"{encodedFilePath}\"");
                    }
                    else
                    {
                        UpdateRichTextBox("无法获取文件路径的目录名。");
                    }
                }).Start();
            }
            else
            {
                UpdateRichTextBox("请先选择NCA文件再进行解包操作。");
            }
        }

        private void RunProcess(string exe, string args)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = exe,
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = psi;
                    process.OutputDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            UpdateRichTextBox(Encoding.UTF8.GetString(Encoding.Default.GetBytes(e.Data)));
                        }
                    };
                    process.ErrorDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            UpdateRichTextBox($"[错误] {Encoding.UTF8.GetString(Encoding.Default.GetBytes(e.Data))}");
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();

                    UpdateRichTextBox(process.ExitCode == 0
                       ? "解包完成！"
                        : $"解包失败，退出代码: {process.ExitCode}");
                }
            }
            catch (Exception ex)
            {
                UpdateRichTextBox($"错误: {ex.Message}\n堆栈信息: {ex.StackTrace}");
            }
        }

        private void UpdateRichTextBox(string message)
        {
            if (string.IsNullOrEmpty(message)) return;

            if (rtbOutput.InvokeRequired)
            {
                rtbOutput.Invoke(new Action(() =>
                {
                    rtbOutput.AppendText($"{DateTime.Now:HH:mm:ss} - {message}\n");
                    rtbOutput.ScrollToCaret();
                }));
            }
            else
            {
                rtbOutput.AppendText($"{DateTime.Now:HH:mm:ss} - {message}\n");
                rtbOutput.ScrollToCaret();
            }
        }

        private void btnSelectXci_Click(object sender, EventArgs e) => SelectXciFile();
        private void btnUnpackXCI_Click(object sender, EventArgs e) => UnpackXCI();
        private void btnSelectNca_Click(object sender, EventArgs e) => SelectNcaFile();
        private void btnUnpackNCA_Click(object sender, EventArgs e) => UnpackNCA();
    }
}