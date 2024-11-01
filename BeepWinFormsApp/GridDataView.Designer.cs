namespace BeepWinFormsApp
{
    partial class GridDataView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TheTechIdea.Beep.Vis.Modules.BeepTheme beepTheme2 = new TheTechIdea.Beep.Vis.Modules.BeepTheme();
            beepGrid1 = new TheTechIdea.Beep.Winform.Controls.Grid.BeepGrid();
            EntitiescomboBox = new ComboBox();
            Getbutton = new Button();
            DataSourcescomboBox = new ComboBox();
            ThemecomboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // beepGrid1
            // 
            beepGrid1.AddinName = null;
            beepGrid1.AllowDrop = true;
            beepGrid1.AllowUserToAddRows = true;
            beepGrid1.AllowUserToDeleteRows = true;
            beepGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            beepGrid1.BorderStyle = BorderStyle.FixedSingle;
            beepGrid1.DataSource = null;
            beepGrid1.DefaultCreate = true;
            beepGrid1.Description = null;
            beepGrid1.DestConnection = null;
            beepGrid1.DllName = null;
            beepGrid1.DllPath = null;
            beepGrid1.DMEEditor = null;
            beepGrid1.Dset = null;
            beepGrid1.EntityName = null;
            beepGrid1.EntityStructure = null;
            beepGrid1.ErrorObject = null;
            beepGrid1.ExtensionsHelpers = null;
            beepGrid1.Location = new Point(14, 77);
            beepGrid1.Logger = null;
            beepGrid1.Margin = new Padding(5, 3, 5, 3);
            beepGrid1.Name = "beepGrid1";
            beepGrid1.NameSpace = null;
            beepGrid1.ObjectName = null;
            beepGrid1.ObjectType = "UserControl";
           // beepGrid1.ParentBranch = null;
            beepGrid1.ParentName = null;
            beepGrid1.Passedarg = null;
           // beepGrid1.pbr = null;
            beepGrid1.Progress = null;
            beepGrid1.ReadOnly = false;
           // beepGrid1.RootBranch = null;
            beepGrid1.ShowFilterPanel = false;
            beepGrid1.ShowTotalsPanel = false;
            beepGrid1.Size = new Size(915, 617);
            beepGrid1.SourceConnection = null;
            beepGrid1.TabIndex = 0;
            beepTheme2.AltRowBackColor = Color.WhiteSmoke;
            beepTheme2.BackColor = Color.WhiteSmoke;
            beepTheme2.BeforeForColor = Color.Gray;
            beepTheme2.ButtonBackColor = Color.LightGray;
            beepTheme2.ButtonForeColor = Color.Black;
            beepTheme2.CheckBoxBackColor = Color.Transparent;
            beepTheme2.CheckBoxForeColor = Color.Black;
            beepTheme2.ComboBoxBackColor = Color.White;
            beepTheme2.ComboBoxForeColor = Color.Black;
            beepTheme2.DescriptionForColor = Color.DarkGray;
            beepTheme2.GridLineColor = Color.DarkGray;
            beepTheme2.HeaderBackColor = Color.Gray;
            beepTheme2.HeaderForeColor = Color.Black;
            beepTheme2.LabelBackColor = Color.Transparent;
            beepTheme2.LabelForeColor = Color.Black;
            beepTheme2.LatestForColor = Color.DarkBlue;
            beepTheme2.PanelBackColor = Color.WhiteSmoke;
            beepTheme2.RadioButtonBackColor = Color.Transparent;
            beepTheme2.RadioButtonForeColor = Color.Black;
            beepTheme2.RowBackColor = Color.White;
            beepTheme2.RowForeColor = Color.Black;
            beepTheme2.SelectedRowBackColor = Color.Gray;
            beepTheme2.SelectedRowForeColor = Color.Black;
            beepTheme2.TextBoxBackColor = Color.White;
            beepTheme2.TextBoxForeColor = Color.Black;
            beepTheme2.TitleForColor = Color.Black;
           // beepGrid1.Theme = beepTheme2;
           // beepGrid1.Tree = null;
            beepGrid1.util = null;
            beepGrid1.VerifyDelete = true;
          //  beepGrid1.ViewRootBranch = null;
         //   beepGrid1.Visutil = null;
            // 
            // EntitiescomboBox
            // 
            EntitiescomboBox.FormattingEnabled = true;
            EntitiescomboBox.Location = new Point(340, 32);
            EntitiescomboBox.Name = "EntitiescomboBox";
            EntitiescomboBox.Size = new Size(150, 23);
            EntitiescomboBox.TabIndex = 1;
            // 
            // Getbutton
            // 
            Getbutton.Location = new Point(496, 32);
            Getbutton.Name = "Getbutton";
            Getbutton.Size = new Size(75, 23);
            Getbutton.TabIndex = 2;
            Getbutton.Text = "Get";
            Getbutton.UseVisualStyleBackColor = true;
            // 
            // DataSourcescomboBox
            // 
            DataSourcescomboBox.FormattingEnabled = true;
            DataSourcescomboBox.Location = new Point(16, 32);
            DataSourcescomboBox.Name = "DataSourcescomboBox";
            DataSourcescomboBox.Size = new Size(310, 23);
            DataSourcescomboBox.TabIndex = 3;
            // 
            // ThemecomboBox
            // 
            ThemecomboBox.FormattingEnabled = true;
            ThemecomboBox.Location = new Point(808, 33);
            ThemecomboBox.Name = "ThemecomboBox";
            ThemecomboBox.Size = new Size(121, 23);
            ThemecomboBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(850, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Theme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 11);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "DataSource";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 12);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Entity";
            // 
            // GridDataView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 706);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ThemecomboBox);
            Controls.Add(DataSourcescomboBox);
            Controls.Add(Getbutton);
            Controls.Add(EntitiescomboBox);
            Controls.Add(beepGrid1);
            Name = "GridDataView";
            Text = "Sample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TheTechIdea.Beep.Winform.Controls.Grid.BeepGrid beepGrid1;
        private ComboBox EntitiescomboBox;
        private Button Getbutton;
        private ComboBox DataSourcescomboBox;
        private ComboBox ThemecomboBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
