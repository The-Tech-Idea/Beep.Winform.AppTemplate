namespace BeepWinFormsApp
{
    partial class MovingData
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
            SourceEntitiescomboBox = new ListBox();
            DestEntitiescomboBox = new ListBox();
            LogtextBox = new TextBox();
            label2 = new Label();
            SourceDataSourcescomboBox = new ComboBox();
            label1 = new Label();
            DestinationDataSourcecomboBox1 = new ComboBox();
            copybutton = new Button();
            deletebutton = new Button();
            progressBar1 = new Beep.Winform.Vis.Controls.TextProgressBar();
            SuspendLayout();
            // 
            // SourceEntitiescomboBox
            // 
            SourceEntitiescomboBox.FormattingEnabled = true;
            SourceEntitiescomboBox.ItemHeight = 15;
            SourceEntitiescomboBox.Location = new Point(40, 71);
            SourceEntitiescomboBox.Name = "SourceEntitiescomboBox";
            SourceEntitiescomboBox.Size = new Size(305, 334);
            SourceEntitiescomboBox.TabIndex = 0;
            // 
            // DestEntitiescomboBox
            // 
            DestEntitiescomboBox.FormattingEnabled = true;
            DestEntitiescomboBox.ItemHeight = 15;
            DestEntitiescomboBox.Location = new Point(420, 71);
            DestEntitiescomboBox.Name = "DestEntitiescomboBox";
            DestEntitiescomboBox.Size = new Size(308, 334);
            DestEntitiescomboBox.TabIndex = 1;
            // 
            // LogtextBox
            // 
            LogtextBox.Location = new Point(40, 421);
            LogtextBox.Multiline = true;
            LogtextBox.Name = "LogtextBox";
            LogtextBox.ScrollBars = ScrollBars.Vertical;
            LogtextBox.Size = new Size(688, 71);
            LogtextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 21);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 8;
            label2.Text = "DataSource";
            // 
            // SourceDataSourcescomboBox
            // 
            SourceDataSourcescomboBox.FormattingEnabled = true;
            SourceDataSourcescomboBox.Location = new Point(40, 42);
            SourceDataSourcescomboBox.Name = "SourceDataSourcescomboBox";
            SourceDataSourcescomboBox.Size = new Size(305, 23);
            SourceDataSourcescomboBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 21);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 10;
            label1.Text = "Destination DataSource";
            // 
            // DestinationDataSourcecomboBox1
            // 
            DestinationDataSourcecomboBox1.FormattingEnabled = true;
            DestinationDataSourcecomboBox1.Location = new Point(418, 42);
            DestinationDataSourcecomboBox1.Name = "DestinationDataSourcecomboBox1";
            DestinationDataSourcecomboBox1.Size = new Size(310, 23);
            DestinationDataSourcecomboBox1.TabIndex = 9;
            // 
            // copybutton
            // 
            copybutton.Location = new Point(351, 145);
            copybutton.Name = "copybutton";
            copybutton.Size = new Size(63, 23);
            copybutton.TabIndex = 11;
            copybutton.Text = ">";
            copybutton.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(351, 215);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(63, 23);
            deletebutton.TabIndex = 12;
            deletebutton.Text = "DEL";
            deletebutton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.CustomText = "";
            progressBar1.Location = new Point(177, 498);
            progressBar1.Margin = new Padding(4, 3, 4, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.ProgressColor = Color.LightGreen;
            progressBar1.Size = new Size(396, 27);
            progressBar1.TabIndex = 26;
            progressBar1.TextColor = Color.Black;
            progressBar1.TextFont = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic);
            progressBar1.VisualMode = Beep.Winform.Vis.Controls.ProgressBarDisplayMode.CurrProgress;
            // 
            // MovingData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 544);
            Controls.Add(progressBar1);
            Controls.Add(deletebutton);
            Controls.Add(copybutton);
            Controls.Add(label1);
            Controls.Add(DestinationDataSourcecomboBox1);
            Controls.Add(label2);
            Controls.Add(SourceDataSourcescomboBox);
            Controls.Add(LogtextBox);
            Controls.Add(DestEntitiescomboBox);
            Controls.Add(SourceEntitiescomboBox);
            Name = "MovingData";
            Text = "MovingData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SourceEntitiescomboBox;
        private ListBox DestEntitiescomboBox;
        private TextBox LogtextBox;
        private Label label2;
        private ComboBox SourceDataSourcescomboBox;
        private Label label1;
        private ComboBox DestinationDataSourcecomboBox1;
        private Button copybutton;
        private Button deletebutton;
        private Beep.Winform.Vis.Controls.TextProgressBar progressBar1;
    }
}