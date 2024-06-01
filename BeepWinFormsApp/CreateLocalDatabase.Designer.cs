namespace BeepWinFormsApp
{
    partial class CreateLocalDatabase
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            databaseTextBox = new TextBox();
            EmbeddedDatabaseTypecomboBox = new ComboBox();
            CreateDBbutton = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(30, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(217, 379);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 19);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 1;
            label1.Text = "Local Databases";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 106);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Database Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 141);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "Local Database Type";
            // 
            // databaseTextBox
            // 
            databaseTextBox.Location = new Point(501, 102);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.Size = new Size(219, 23);
            databaseTextBox.TabIndex = 4;
            // 
            // EmbeddedDatabaseTypecomboBox
            // 
            EmbeddedDatabaseTypecomboBox.FormattingEnabled = true;
            EmbeddedDatabaseTypecomboBox.Location = new Point(501, 137);
            EmbeddedDatabaseTypecomboBox.Name = "EmbeddedDatabaseTypecomboBox";
            EmbeddedDatabaseTypecomboBox.Size = new Size(219, 23);
            EmbeddedDatabaseTypecomboBox.TabIndex = 5;
            // 
            // CreateDBbutton
            // 
            CreateDBbutton.Location = new Point(568, 166);
            CreateDBbutton.Name = "CreateDBbutton";
            CreateDBbutton.Size = new Size(75, 23);
            CreateDBbutton.TabIndex = 6;
            CreateDBbutton.Text = "Create";
            CreateDBbutton.UseVisualStyleBackColor = true;
            // 
            // CreateLocalDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateDBbutton);
            Controls.Add(EmbeddedDatabaseTypecomboBox);
            Controls.Add(databaseTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "CreateLocalDatabase";
            Text = "CreateLocalDatabase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox databaseTextBox;
        private ComboBox EmbeddedDatabaseTypecomboBox;
        private Button CreateDBbutton;
    }
}