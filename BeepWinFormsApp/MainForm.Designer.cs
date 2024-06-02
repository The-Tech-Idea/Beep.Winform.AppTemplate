namespace BeepWinFormsApp
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
            CreateLocalDBbutton = new Button();
            GridViewbutton = new Button();
            MoveDatabutton = new Button();
            CreateinmemoryDBbutton = new Button();
            SuspendLayout();
            // 
            // CreateLocalDBbutton
            // 
            CreateLocalDBbutton.Location = new Point(50, 33);
            CreateLocalDBbutton.Name = "CreateLocalDBbutton";
            CreateLocalDBbutton.Size = new Size(136, 23);
            CreateLocalDBbutton.TabIndex = 0;
            CreateLocalDBbutton.Text = "Create Local DB";
            CreateLocalDBbutton.UseVisualStyleBackColor = true;
            // 
            // GridViewbutton
            // 
            GridViewbutton.Location = new Point(50, 73);
            GridViewbutton.Name = "GridViewbutton";
            GridViewbutton.Size = new Size(136, 23);
            GridViewbutton.TabIndex = 1;
            GridViewbutton.Text = "DataGrid View";
            GridViewbutton.UseVisualStyleBackColor = true;
            // 
            // MoveDatabutton
            // 
            MoveDatabutton.Location = new Point(50, 114);
            MoveDatabutton.Name = "MoveDatabutton";
            MoveDatabutton.Size = new Size(136, 23);
            MoveDatabutton.TabIndex = 2;
            MoveDatabutton.Text = "Move Data";
            MoveDatabutton.UseVisualStyleBackColor = true;
            // 
            // CreateinmemoryDBbutton
            // 
            CreateinmemoryDBbutton.Location = new Point(50, 156);
            CreateinmemoryDBbutton.Name = "CreateinmemoryDBbutton";
            CreateinmemoryDBbutton.Size = new Size(136, 23);
            CreateinmemoryDBbutton.TabIndex = 3;
            CreateinmemoryDBbutton.Text = "Create InMemory DB";
            CreateinmemoryDBbutton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 623);
            Controls.Add(CreateinmemoryDBbutton);
            Controls.Add(MoveDatabutton);
            Controls.Add(GridViewbutton);
            Controls.Add(CreateLocalDBbutton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Beep Sample code";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Button CreateLocalDBbutton;
        private Button GridViewbutton;
        private Button MoveDatabutton;
        private Button CreateinmemoryDBbutton;
    }
}