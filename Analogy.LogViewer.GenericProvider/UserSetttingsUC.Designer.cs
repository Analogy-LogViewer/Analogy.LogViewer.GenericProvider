namespace Analogy.LogViewer.GenericProvider
{
    partial class UserSetttingsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtLogsLocation = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtbOpenFileFilters = new System.Windows.Forms.TextBox();
            this.lblOpenfilesFilters = new System.Windows.Forms.Label();
            this.txtbSupportedFiles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbRegEx = new System.Windows.Forms.TextBox();
            this.lblRegex = new System.Windows.Forms.Label();
            this.txtbTest = new System.Windows.Forms.TextBox();
            this.lblLogTest = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblDateTimeFormat = new System.Windows.Forms.Label();
            this.txtbDateTimeFormat = new System.Windows.Forms.TextBox();
            this.gbresult = new System.Windows.Forms.GroupBox();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbresult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.Location = new System.Drawing.Point(809, 25);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(47, 25);
            this.btnBrowser.TabIndex = 28;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtLogsLocation
            // 
            this.txtLogsLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogsLocation.Location = new System.Drawing.Point(189, 25);
            this.txtLogsLocation.Name = "txtLogsLocation";
            this.txtLogsLocation.Size = new System.Drawing.Size(614, 26);
            this.txtLogsLocation.TabIndex = 27;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(7, 28);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(147, 18);
            this.lblPath.TabIndex = 26;
            this.lblPath.Text = "Default Logs Location";
            // 
            // txtbOpenFileFilters
            // 
            this.txtbOpenFileFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbOpenFileFilters.Location = new System.Drawing.Point(189, 69);
            this.txtbOpenFileFilters.Name = "txtbOpenFileFilters";
            this.txtbOpenFileFilters.Size = new System.Drawing.Size(614, 26);
            this.txtbOpenFileFilters.TabIndex = 30;
            // 
            // lblOpenfilesFilters
            // 
            this.lblOpenfilesFilters.AutoSize = true;
            this.lblOpenfilesFilters.Location = new System.Drawing.Point(7, 72);
            this.lblOpenfilesFilters.Name = "lblOpenfilesFilters";
            this.lblOpenfilesFilters.Size = new System.Drawing.Size(105, 18);
            this.lblOpenfilesFilters.TabIndex = 29;
            this.lblOpenfilesFilters.Text = "Open file Filter:";
            // 
            // txtbSupportedFiles
            // 
            this.txtbSupportedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbSupportedFiles.Location = new System.Drawing.Point(189, 111);
            this.txtbSupportedFiles.Name = "txtbSupportedFiles";
            this.txtbSupportedFiles.Size = new System.Drawing.Size(614, 26);
            this.txtbSupportedFiles.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Supported Log Formats:";
            // 
            // txtbRegEx
            // 
            this.txtbRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRegEx.Location = new System.Drawing.Point(189, 165);
            this.txtbRegEx.Name = "txtbRegEx";
            this.txtbRegEx.Size = new System.Drawing.Size(614, 26);
            this.txtbRegEx.TabIndex = 34;
            // 
            // lblRegex
            // 
            this.lblRegex.AccessibleDescription = "";
            this.lblRegex.AutoSize = true;
            this.lblRegex.Location = new System.Drawing.Point(7, 169);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new System.Drawing.Size(170, 18);
            this.lblRegex.TabIndex = 33;
            this.lblRegex.Text = "Logs Regular Expression:";
            // 
            // txtbTest
            // 
            this.txtbTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTest.Location = new System.Drawing.Point(189, 244);
            this.txtbTest.Name = "txtbTest";
            this.txtbTest.Size = new System.Drawing.Size(614, 26);
            this.txtbTest.TabIndex = 36;
            // 
            // lblLogTest
            // 
            this.lblLogTest.AccessibleDescription = "";
            this.lblLogTest.AutoSize = true;
            this.lblLogTest.Location = new System.Drawing.Point(7, 248);
            this.lblLogTest.Name = "lblLogTest";
            this.lblLogTest.Size = new System.Drawing.Size(109, 18);
            this.lblLogTest.TabIndex = 35;
            this.lblLogTest.Text = "Log line to test:";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(809, 244);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(47, 25);
            this.btnTest.TabIndex = 28;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblDateTimeFormat
            // 
            this.lblDateTimeFormat.AccessibleDescription = "";
            this.lblDateTimeFormat.AutoSize = true;
            this.lblDateTimeFormat.Location = new System.Drawing.Point(7, 200);
            this.lblDateTimeFormat.Name = "lblDateTimeFormat";
            this.lblDateTimeFormat.Size = new System.Drawing.Size(170, 18);
            this.lblDateTimeFormat.TabIndex = 33;
            this.lblDateTimeFormat.Text = "Logs Regular Expression:";
            // 
            // txtbDateTimeFormat
            // 
            this.txtbDateTimeFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDateTimeFormat.Location = new System.Drawing.Point(189, 197);
            this.txtbDateTimeFormat.Name = "txtbDateTimeFormat";
            this.txtbDateTimeFormat.Size = new System.Drawing.Size(614, 26);
            this.txtbDateTimeFormat.TabIndex = 34;
            this.txtbDateTimeFormat.Text = "yyyy-MM-dd HH:mm:ss,fff";
            // 
            // gbresult
            // 
            this.gbresult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbresult.Controls.Add(this.lblResultMessage);
            this.gbresult.Controls.Add(this.lblResult);
            this.gbresult.Location = new System.Drawing.Point(0, 306);
            this.gbresult.Name = "gbresult";
            this.gbresult.Size = new System.Drawing.Size(782, 191);
            this.gbresult.TabIndex = 37;
            this.gbresult.TabStop = false;
            this.gbresult.Text = "Result";
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultMessage.Location = new System.Drawing.Point(3, 41);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(776, 147);
            this.lblResultMessage.TabIndex = 31;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Location = new System.Drawing.Point(3, 22);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(776, 19);
            this.lblResult.TabIndex = 30;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(788, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 25);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserSetttingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbresult);
            this.Controls.Add(this.txtbTest);
            this.Controls.Add(this.lblLogTest);
            this.Controls.Add(this.txtbDateTimeFormat);
            this.Controls.Add(this.txtbRegEx);
            this.Controls.Add(this.lblDateTimeFormat);
            this.Controls.Add(this.lblRegex);
            this.Controls.Add(this.txtbSupportedFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbOpenFileFilters);
            this.Controls.Add(this.lblOpenfilesFilters);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtLogsLocation);
            this.Controls.Add(this.lblPath);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserSetttingsUC";
            this.Size = new System.Drawing.Size(859, 518);
            this.Load += new System.EventHandler(this.UserSetttingsUC_Load);
            this.gbresult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtLogsLocation;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtbOpenFileFilters;
        private System.Windows.Forms.Label lblOpenfilesFilters;
        private System.Windows.Forms.TextBox txtbSupportedFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbRegEx;
        private System.Windows.Forms.Label lblRegex;
        private System.Windows.Forms.TextBox txtbTest;
        private System.Windows.Forms.Label lblLogTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblDateTimeFormat;
        private System.Windows.Forms.TextBox txtbDateTimeFormat;
        private System.Windows.Forms.GroupBox gbresult;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSave;
    }
}
