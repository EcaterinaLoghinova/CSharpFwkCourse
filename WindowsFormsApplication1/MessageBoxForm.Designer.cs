namespace SimCorp.IMS.Framework.GUI
{
    partial class MessageBoxForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.selectFormattingComboBox = new System.Windows.Forms.ComboBox();
            this.recievedMessagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SelectFormattingLabel = new System.Windows.Forms.Label();
            this.filterByContactLabel = new System.Windows.Forms.Label();
            this.messageListView = new System.Windows.Forms.ListView();
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.textSearchButton = new System.Windows.Forms.Button();
            this.allFiltersCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // selectFormattingComboBox
            // 
            this.selectFormattingComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.selectFormattingComboBox.AllowDrop = true;
            this.selectFormattingComboBox.DisplayMember = "Select Formatting";
            this.selectFormattingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFormattingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFormattingComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selectFormattingComboBox.FormattingEnabled = true;
            this.selectFormattingComboBox.Items.AddRange(new object[] {
            "None",
            "Custom",
            "Start with date and time",
            "End with date and time",
            "Uppercase",
            "Lowercase"});
            this.selectFormattingComboBox.Location = new System.Drawing.Point(12, 84);
            this.selectFormattingComboBox.Name = "selectFormattingComboBox";
            this.selectFormattingComboBox.Size = new System.Drawing.Size(181, 24);
            this.selectFormattingComboBox.TabIndex = 0;
            this.selectFormattingComboBox.Tag = "";
            this.selectFormattingComboBox.ValueMember = "Select Formatting";
            this.selectFormattingComboBox.SelectedIndexChanged += new System.EventHandler(this.selectFormattingComboBox_SelectedIndexChanged);
            // 
            // recievedMessagesRichTextBox
            // 
            this.recievedMessagesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recievedMessagesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recievedMessagesRichTextBox.Location = new System.Drawing.Point(11, 121);
            this.recievedMessagesRichTextBox.Name = "recievedMessagesRichTextBox";
            this.recievedMessagesRichTextBox.ReadOnly = true;
            this.recievedMessagesRichTextBox.Size = new System.Drawing.Size(410, 212);
            this.recievedMessagesRichTextBox.TabIndex = 1;
            this.recievedMessagesRichTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(239, 8);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(182, 21);
            this.userComboBox.TabIndex = 2;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(238, 63);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.fromDateTimePicker.TabIndex = 4;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(329, 63);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.toDateTimePicker.TabIndex = 5;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // SelectFormattingLabel
            // 
            this.SelectFormattingLabel.AutoSize = true;
            this.SelectFormattingLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectFormattingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SelectFormattingLabel.Location = new System.Drawing.Point(19, 88);
            this.SelectFormattingLabel.Name = "SelectFormattingLabel";
            this.SelectFormattingLabel.Size = new System.Drawing.Size(112, 16);
            this.SelectFormattingLabel.TabIndex = 6;
            this.SelectFormattingLabel.Text = "Select Formatting";
            // 
            // filterByContactLabel
            // 
            this.filterByContactLabel.AutoSize = true;
            this.filterByContactLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.filterByContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.filterByContactLabel.Location = new System.Drawing.Point(246, 10);
            this.filterByContactLabel.Name = "filterByContactLabel";
            this.filterByContactLabel.Size = new System.Drawing.Size(101, 16);
            this.filterByContactLabel.TabIndex = 7;
            this.filterByContactLabel.Text = "Filter by contact";
            // 
            // messageListView
            // 
            this.messageListView.AllowColumnReorder = true;
            this.messageListView.AllowDrop = true;
            this.messageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contact,
            this.Message,
            this.DateTime});
            this.messageListView.FullRowSelect = true;
            this.messageListView.GridLines = true;
            this.messageListView.HoverSelection = true;
            this.messageListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.messageListView.Location = new System.Drawing.Point(11, 8);
            this.messageListView.Name = "messageListView";
            this.messageListView.Size = new System.Drawing.Size(206, 56);
            this.messageListView.TabIndex = 8;
            this.messageListView.UseCompatibleStateImageBehavior = false;
            this.messageListView.View = System.Windows.Forms.View.Tile;
            // 
            // Contact
            // 
            this.Contact.Text = "Contact";
            // 
            // Message
            // 
            this.Message.Text = "Text";
            this.Message.Width = 70;
            // 
            // DateTime
            // 
            this.DateTime.Text = "Recieving time";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.messageTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.messageTextBox.Location = new System.Drawing.Point(260, 35);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(161, 22);
            this.messageTextBox.TabIndex = 9;
            this.messageTextBox.Text = "Message";
            // 
            // textSearchButton
            // 
            this.textSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("textSearchButton.Image")));
            this.textSearchButton.Location = new System.Drawing.Point(239, 35);
            this.textSearchButton.Name = "textSearchButton";
            this.textSearchButton.Size = new System.Drawing.Size(22, 22);
            this.textSearchButton.TabIndex = 10;
            this.textSearchButton.UseVisualStyleBackColor = true;
            this.textSearchButton.Click += new System.EventHandler(this.textSearchButton_Click);
            // 
            // allFiltersCheckBox
            // 
            this.allFiltersCheckBox.AutoSize = true;
            this.allFiltersCheckBox.Location = new System.Drawing.Point(329, 91);
            this.allFiltersCheckBox.Name = "allFiltersCheckBox";
            this.allFiltersCheckBox.Size = new System.Drawing.Size(92, 17);
            this.allFiltersCheckBox.TabIndex = 11;
            this.allFiltersCheckBox.Text = "Apply all filters";
            this.allFiltersCheckBox.UseVisualStyleBackColor = true;
            this.allFiltersCheckBox.CheckedChanged += new System.EventHandler(this.allFiltersCheckBox_CheckedChanged);
            // 
            // MessageBoxForm
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 345);
            this.Controls.Add(this.allFiltersCheckBox);
            this.Controls.Add(this.textSearchButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageListView);
            this.Controls.Add(this.filterByContactLabel);
            this.Controls.Add(this.SelectFormattingLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.recievedMessagesRichTextBox);
            this.Controls.Add(this.selectFormattingComboBox);
            this.MaximizeBox = false;
            this.Name = "MessageBoxForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Message Box";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.RichTextBox recievedMessagesRichTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.ComboBox selectFormattingComboBox;
        private System.Windows.Forms.Label SelectFormattingLabel;
        private System.Windows.Forms.Label filterByContactLabel;
        private System.Windows.Forms.ListView messageListView;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button textSearchButton;
        private System.Windows.Forms.CheckBox allFiltersCheckBox;
    }
}