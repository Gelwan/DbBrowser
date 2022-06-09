namespace DbBrowser
{
    partial class MainForm
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
            this.QueryResultList = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UpdateIdBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateFirstNameBox = new System.Windows.Forms.TextBox();
            this.UpdateLastNameBox = new System.Windows.Forms.TextBox();
            this.UpdateEmailBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdatePhoneBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateIdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryResultList
            // 
            this.QueryResultList.FormattingEnabled = true;
            this.QueryResultList.Location = new System.Drawing.Point(12, 125);
            this.QueryResultList.Name = "QueryResultList";
            this.QueryResultList.Size = new System.Drawing.Size(486, 134);
            this.QueryResultList.TabIndex = 0;
            this.QueryResultList.SelectedIndexChanged += new System.EventHandler(this.QueryResultList_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 69);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // QueryBox
            // 
            this.QueryBox.Location = new System.Drawing.Point(12, 98);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(486, 20);
            this.QueryBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(75, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(75, 38);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(93, 69);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 7;
            this.InsertButton.Text = "Instert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(419, 408);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UpdateIdBox
            // 
            this.UpdateIdBox.Enabled = false;
            this.UpdateIdBox.Location = new System.Drawing.Point(17, 294);
            this.UpdateIdBox.Name = "UpdateIdBox";
            this.UpdateIdBox.Size = new System.Drawing.Size(57, 20);
            this.UpdateIdBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "First name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // UpdateFirstNameBox
            // 
            this.UpdateFirstNameBox.Location = new System.Drawing.Point(80, 294);
            this.UpdateFirstNameBox.Name = "UpdateFirstNameBox";
            this.UpdateFirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.UpdateFirstNameBox.TabIndex = 14;
            // 
            // UpdateLastNameBox
            // 
            this.UpdateLastNameBox.Location = new System.Drawing.Point(186, 294);
            this.UpdateLastNameBox.Name = "UpdateLastNameBox";
            this.UpdateLastNameBox.Size = new System.Drawing.Size(100, 20);
            this.UpdateLastNameBox.TabIndex = 15;
            // 
            // UpdateEmailBox
            // 
            this.UpdateEmailBox.Location = new System.Drawing.Point(292, 294);
            this.UpdateEmailBox.Name = "UpdateEmailBox";
            this.UpdateEmailBox.Size = new System.Drawing.Size(100, 20);
            this.UpdateEmailBox.TabIndex = 16;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 320);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(120, 23);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update selected";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(138, 320);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete selected";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdatePhoneBox
            // 
            this.UpdatePhoneBox.Location = new System.Drawing.Point(398, 294);
            this.UpdatePhoneBox.Name = "UpdatePhoneBox";
            this.UpdatePhoneBox.Size = new System.Drawing.Size(100, 20);
            this.UpdatePhoneBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Phone number";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(DbBrowser.Person);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 443);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpdatePhoneBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdateEmailBox);
            this.Controls.Add(this.UpdateLastNameBox);
            this.Controls.Add(this.UpdateFirstNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateIdBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.QueryResultList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Database Browser";
            ((System.ComponentModel.ISupportInitialize)(this.UpdateIdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox QueryResultList;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.NumericUpDown UpdateIdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UpdateFirstNameBox;
        private System.Windows.Forms.TextBox UpdateLastNameBox;
        private System.Windows.Forms.TextBox UpdateEmailBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox UpdatePhoneBox;
        private System.Windows.Forms.Label label7;
    }
}

