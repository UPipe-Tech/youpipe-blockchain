namespace UTech.View
{
    partial class CreateAccountForm
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
            this.MainTBLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAcc = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCopy = new System.Windows.Forms.Label();
            this.labelCopy2 = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelSecret = new System.Windows.Forms.Label();
            this.richTextBoxAccSecret = new System.Windows.Forms.RichTextBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.tbLayoutPassword = new System.Windows.Forms.TableLayoutPanel();
            this.labelPw = new System.Windows.Forms.Label();
            this.labelRePw = new System.Windows.Forms.Label();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.textBoxRePw = new System.Windows.Forms.TextBox();
            this.labelTips = new System.Windows.Forms.Label();
            this.btnFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.MainTBLayout.SuspendLayout();
            this.groupBoxAcc.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbLayoutPassword.SuspendLayout();
            this.btnFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTBLayout
            // 
            this.MainTBLayout.ColumnCount = 1;
            this.MainTBLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTBLayout.Controls.Add(this.groupBoxAcc, 0, 1);
            this.MainTBLayout.Controls.Add(this.tbLayoutPassword, 0, 0);
            this.MainTBLayout.Controls.Add(this.btnFlowLayoutPanel, 0, 2);
            this.MainTBLayout.Location = new System.Drawing.Point(13, 13);
            this.MainTBLayout.Name = "MainTBLayout";
            this.MainTBLayout.RowCount = 3;
            this.MainTBLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.59184F));
            this.MainTBLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.40816F));
            this.MainTBLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.MainTBLayout.Size = new System.Drawing.Size(412, 317);
            this.MainTBLayout.TabIndex = 0;
            // 
            // groupBoxAcc
            // 
            this.groupBoxAcc.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxAcc.Location = new System.Drawing.Point(3, 87);
            this.groupBoxAcc.Name = "groupBoxAcc";
            this.groupBoxAcc.Size = new System.Drawing.Size(406, 193);
            this.groupBoxAcc.TabIndex = 0;
            this.groupBoxAcc.TabStop = false;
            this.groupBoxAcc.Text = "Account Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.46917F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.53083F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Controls.Add(this.labelCopy, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCopy2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAccount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSecret, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxAccSecret, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAccount, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.08589F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.91411F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 163);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelCopy
            // 
            this.labelCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopy.AutoSize = true;
            this.labelCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCopy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCopy.Location = new System.Drawing.Point(350, 12);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(41, 12);
            this.labelCopy.TabIndex = 0;
            this.labelCopy.Text = "Copy";
            this.labelCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCopy2
            // 
            this.labelCopy2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopy2.AutoSize = true;
            this.labelCopy2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCopy2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCopy2.Location = new System.Drawing.Point(350, 141);
            this.labelCopy2.Name = "labelCopy2";
            this.labelCopy2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelCopy2.Size = new System.Drawing.Size(41, 22);
            this.labelCopy2.TabIndex = 1;
            this.labelCopy2.Text = "Copy";
            this.labelCopy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAccount
            // 
            this.labelAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(3, 12);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(82, 12);
            this.labelAccount.TabIndex = 2;
            this.labelAccount.Text = "Account";
            this.labelAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSecret
            // 
            this.labelSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecret.AutoSize = true;
            this.labelSecret.Location = new System.Drawing.Point(3, 93);
            this.labelSecret.Name = "labelSecret";
            this.labelSecret.Size = new System.Drawing.Size(82, 12);
            this.labelSecret.TabIndex = 3;
            this.labelSecret.Text = "Secret";
            this.labelSecret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBoxAccSecret
            // 
            this.richTextBoxAccSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAccSecret.Enabled = false;
            this.richTextBoxAccSecret.Location = new System.Drawing.Point(91, 39);
            this.richTextBoxAccSecret.Name = "richTextBoxAccSecret";
            this.richTextBoxAccSecret.Size = new System.Drawing.Size(253, 121);
            this.richTextBoxAccSecret.TabIndex = 4;
            this.richTextBoxAccSecret.Text = "";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccount.Enabled = false;
            this.textBoxAccount.Location = new System.Drawing.Point(91, 7);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(253, 21);
            this.textBoxAccount.TabIndex = 5;
            // 
            // tbLayoutPassword
            // 
            this.tbLayoutPassword.ColumnCount = 2;
            this.tbLayoutPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.94015F));
            this.tbLayoutPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.05985F));
            this.tbLayoutPassword.Controls.Add(this.labelPw, 0, 0);
            this.tbLayoutPassword.Controls.Add(this.labelRePw, 0, 1);
            this.tbLayoutPassword.Controls.Add(this.textBoxPw, 1, 0);
            this.tbLayoutPassword.Controls.Add(this.textBoxRePw, 1, 1);
            this.tbLayoutPassword.Controls.Add(this.labelTips, 0, 2);
            this.tbLayoutPassword.Location = new System.Drawing.Point(3, 3);
            this.tbLayoutPassword.Name = "tbLayoutPassword";
            this.tbLayoutPassword.RowCount = 3;
            this.tbLayoutPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLayoutPassword.Size = new System.Drawing.Size(401, 78);
            this.tbLayoutPassword.TabIndex = 1;
            // 
            // labelPw
            // 
            this.labelPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPw.AutoSize = true;
            this.labelPw.Location = new System.Drawing.Point(3, 8);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(89, 12);
            this.labelPw.TabIndex = 0;
            this.labelPw.Text = "Password";
            this.labelPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRePw
            // 
            this.labelRePw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRePw.AutoSize = true;
            this.labelRePw.Location = new System.Drawing.Point(3, 37);
            this.labelRePw.Name = "labelRePw";
            this.labelRePw.Size = new System.Drawing.Size(89, 12);
            this.labelRePw.TabIndex = 1;
            this.labelRePw.Text = "Repeat";
            this.labelRePw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPw
            // 
            this.textBoxPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPw.Location = new System.Drawing.Point(98, 4);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.PasswordChar = '*';
            this.textBoxPw.Size = new System.Drawing.Size(300, 21);
            this.textBoxPw.TabIndex = 2;
            this.textBoxPw.TextChanged += new System.EventHandler(this.textBoxPw_TextChanged);
            // 
            // textBoxRePw
            // 
            this.textBoxRePw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRePw.Location = new System.Drawing.Point(98, 33);
            this.textBoxRePw.Name = "textBoxRePw";
            this.textBoxRePw.PasswordChar = '*';
            this.textBoxRePw.Size = new System.Drawing.Size(300, 21);
            this.textBoxRePw.TabIndex = 3;
            this.textBoxRePw.TextChanged += new System.EventHandler(this.textBoxRePw_TextChanged);
            // 
            // labelTips
            // 
            this.labelTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTips.AutoSize = true;
            this.tbLayoutPassword.SetColumnSpan(this.labelTips, 2);
            this.labelTips.Location = new System.Drawing.Point(3, 62);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(395, 12);
            this.labelTips.TabIndex = 4;
            this.labelTips.Text = "password need 8~20 characters.";
            this.labelTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFlowLayoutPanel
            // 
            this.btnFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFlowLayoutPanel.Controls.Add(this.btnCancel);
            this.btnFlowLayoutPanel.Controls.Add(this.btnCreate);
            this.btnFlowLayoutPanel.Location = new System.Drawing.Point(3, 287);
            this.btnFlowLayoutPanel.Name = "btnFlowLayoutPanel";
            this.btnFlowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnFlowLayoutPanel.Size = new System.Drawing.Size(406, 27);
            this.btnFlowLayoutPanel.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(247, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 340);
            this.Controls.Add(this.MainTBLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccountForm_Load);
            this.MainTBLayout.ResumeLayout(false);
            this.groupBoxAcc.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbLayoutPassword.ResumeLayout(false);
            this.tbLayoutPassword.PerformLayout();
            this.btnFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTBLayout;
        private System.Windows.Forms.GroupBox groupBoxAcc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.Label labelCopy2;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelSecret;
        private System.Windows.Forms.RichTextBox richTextBoxAccSecret;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TableLayoutPanel tbLayoutPassword;
        private System.Windows.Forms.Label labelPw;
        private System.Windows.Forms.Label labelRePw;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.TextBox textBoxRePw;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.FlowLayoutPanel btnFlowLayoutPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
    }
}