namespace SimCorp.IMS.Framework.GUI
{
    partial class CallsForm
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
            this.callGridView = new System.Windows.Forms.DataGridView();
            this.contactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callLog = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.callGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // callGridView
            // 
            this.callGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactName,
            this.phoneNumber,
            this.callDirection,
            this.callLog});
            this.callGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.callGridView.Location = new System.Drawing.Point(12, 12);
            this.callGridView.Name = "callGridView";
            this.callGridView.Size = new System.Drawing.Size(468, 237);
            this.callGridView.TabIndex = 1;
            // 
            // contactName
            // 
            this.contactName.HeaderText = "Contact name";
            this.contactName.Name = "contactName";
            this.contactName.Width = 99;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone number";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // callDirection
            // 
            this.callDirection.HeaderText = "Call direction";
            this.callDirection.Name = "callDirection";
            this.callDirection.Width = 99;
            // 
            // callLog
            // 
            this.callLog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.callLog.HeaderText = "Call history";
            this.callLog.Name = "callLog";
            // 
            // CallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.callGridView);
            this.MaximizeBox = false;
            this.Name = "CallsForm";
            this.Text = "Calls";
            this.Load += new System.EventHandler(this.CallsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.callGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView callGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDirection;
        private System.Windows.Forms.DataGridViewComboBoxColumn callLog;
    }
}