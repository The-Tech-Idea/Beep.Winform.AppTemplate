namespace BeepWinFormsApp
{
    partial class UnitofWork
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
            components = new System.ComponentModel.Container();
            TheTechIdea.Beep.Vis.Modules.BeepTheme beepTheme1 = new TheTechIdea.Beep.Vis.Modules.BeepTheme();
            label3 = new Label();
            label2 = new Label();
            DataSourcescomboBox = new ComboBox();
            Getbutton = new Button();
            EntitiescomboBox = new ComboBox();
            beepGrid1 = new TheTechIdea.Beep.Winform.Controls.Grid.BeepGrid();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 13;
            label3.Text = "Entity";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 8);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 12;
            label2.Text = "DataSource";
            label2.Visible = false;
            // 
            // DataSourcescomboBox
            // 
            DataSourcescomboBox.FormattingEnabled = true;
            DataSourcescomboBox.Location = new Point(91, 29);
            DataSourcescomboBox.Name = "DataSourcescomboBox";
            DataSourcescomboBox.Size = new Size(310, 23);
            DataSourcescomboBox.TabIndex = 11;
            DataSourcescomboBox.Visible = false;
            // 
            // Getbutton
            // 
            Getbutton.Location = new Point(571, 29);
            Getbutton.Name = "Getbutton";
            Getbutton.Size = new Size(75, 23);
            Getbutton.TabIndex = 10;
            Getbutton.Text = "Get";
            Getbutton.UseVisualStyleBackColor = true;
            Getbutton.Visible = false;
            // 
            // EntitiescomboBox
            // 
            EntitiescomboBox.FormattingEnabled = true;
            EntitiescomboBox.Location = new Point(415, 29);
            EntitiescomboBox.Name = "EntitiescomboBox";
            EntitiescomboBox.Size = new Size(150, 23);
            EntitiescomboBox.TabIndex = 9;
            EntitiescomboBox.Visible = false;
            // 
            // beepGrid1
            // 
            beepGrid1.AddinName = null;
            beepGrid1.AllowDrop = true;
            beepGrid1.AllowUserToAddRows = true;
            beepGrid1.AllowUserToDeleteRows = true;
            beepGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            beepGrid1.BorderStyle = BorderStyle.FixedSingle;
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
            beepGrid1.Location = new Point(89, 74);
            beepGrid1.Logger = null;
            beepGrid1.Margin = new Padding(5, 3, 5, 3);
            beepGrid1.Name = "beepGrid1";
            beepGrid1.NameSpace = null;
            beepGrid1.ObjectName = null;
            beepGrid1.ObjectType = "UserControl";
            beepGrid1.ParentBranch = null;
            beepGrid1.ParentName = null;
            beepGrid1.Passedarg = null;
            beepGrid1.pbr = null;
            beepGrid1.Progress = null;
            beepGrid1.ReadOnly = false;
            beepGrid1.RootBranch = null;
            beepGrid1.ShowFilterPanel = false;
            beepGrid1.ShowTotalsPanel = false;
            beepGrid1.Size = new Size(908, 609);
            beepGrid1.SourceConnection = null;
            beepGrid1.TabIndex = 8;
            beepTheme1.AltRowBackColor = Color.WhiteSmoke;
            beepTheme1.BackColor = Color.WhiteSmoke;
            beepTheme1.BeforeForColor = Color.Gray;
            beepTheme1.ButtonBackColor = Color.LightGray;
            beepTheme1.ButtonForeColor = Color.Black;
            beepTheme1.CheckBoxBackColor = Color.Transparent;
            beepTheme1.CheckBoxForeColor = Color.Black;
            beepTheme1.ComboBoxBackColor = Color.White;
            beepTheme1.ComboBoxForeColor = Color.Black;
            beepTheme1.DescriptionForColor = Color.DarkGray;
            beepTheme1.GridLineColor = Color.DarkGray;
            beepTheme1.HeaderBackColor = Color.Gray;
            beepTheme1.HeaderForeColor = Color.Black;
            beepTheme1.LabelBackColor = Color.Transparent;
            beepTheme1.LabelForeColor = Color.Black;
            beepTheme1.LatestForColor = Color.DarkBlue;
            beepTheme1.PanelBackColor = Color.WhiteSmoke;
            beepTheme1.RadioButtonBackColor = Color.Transparent;
            beepTheme1.RadioButtonForeColor = Color.Black;
            beepTheme1.RowBackColor = Color.White;
            beepTheme1.RowForeColor = Color.Black;
            beepTheme1.SelectedRowBackColor = Color.Gray;
            beepTheme1.SelectedRowForeColor = Color.Black;
            beepTheme1.TextBoxBackColor = Color.White;
            beepTheme1.TextBoxForeColor = Color.Black;
            beepTheme1.TitleForColor = Color.Black;
            beepGrid1.Theme = beepTheme1;
            beepGrid1.Tree = null;
            beepGrid1.util = null;
            beepGrid1.VerifyDelete = true;
            beepGrid1.ViewRootBranch = null;
            beepGrid1.Visutil = null;
            // 
            // UnitofWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 695);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DataSourcescomboBox);
            Controls.Add(Getbutton);
            Controls.Add(EntitiescomboBox);
            Controls.Add(beepGrid1);
            Name = "UnitofWork";
            Text = "UnitofWork";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private ComboBox DataSourcescomboBox;
        private Button Getbutton;
        private ComboBox EntitiescomboBox;
        private TheTechIdea.Beep.Winform.Controls.Grid.BeepGrid beepGrid1;
    }
}