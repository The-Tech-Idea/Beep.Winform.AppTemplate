namespace BeepWinFormsApp
{
    partial class GenerateEntitiesPOCO
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
            label3 = new Label();
            label2 = new Label();
            DataSourcescomboBox = new ComboBox();
            Getbutton = new Button();
            EntitiescomboBox = new ComboBox();
            LogtextBox = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 56);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 12;
            label3.Text = "Entity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 55);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 11;
            label2.Text = "DataSource";
            // 
            // DataSourcescomboBox
            // 
            DataSourcescomboBox.FormattingEnabled = true;
            DataSourcescomboBox.Location = new Point(123, 76);
            DataSourcescomboBox.Name = "DataSourcescomboBox";
            DataSourcescomboBox.Size = new Size(310, 23);
            DataSourcescomboBox.TabIndex = 10;
            // 
            // Getbutton
            // 
            Getbutton.Location = new Point(603, 76);
            Getbutton.Name = "Getbutton";
            Getbutton.Size = new Size(75, 23);
            Getbutton.TabIndex = 9;
            Getbutton.Text = "Get";
            Getbutton.UseVisualStyleBackColor = true;
            // 
            // EntitiescomboBox
            // 
            EntitiescomboBox.FormattingEnabled = true;
            EntitiescomboBox.Location = new Point(447, 76);
            EntitiescomboBox.Name = "EntitiescomboBox";
            EntitiescomboBox.Size = new Size(150, 23);
            EntitiescomboBox.TabIndex = 8;
            // 
            // LogtextBox
            // 
            LogtextBox.Location = new Point(103, 124);
            LogtextBox.Multiline = true;
            LogtextBox.Name = "LogtextBox";
            LogtextBox.ScrollBars = ScrollBars.Vertical;
            LogtextBox.Size = new Size(688, 479);
            LogtextBox.TabIndex = 13;
            // 
            // GenerateEntitiesPOCO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 643);
            Controls.Add(LogtextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DataSourcescomboBox);
            Controls.Add(Getbutton);
            Controls.Add(EntitiescomboBox);
            Name = "GenerateEntitiesPOCO";
            Text = "GenerateEntitiesPOCO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private ComboBox DataSourcescomboBox;
        private Button Getbutton;
        private ComboBox EntitiescomboBox;
        private TextBox LogtextBox;
    }
}