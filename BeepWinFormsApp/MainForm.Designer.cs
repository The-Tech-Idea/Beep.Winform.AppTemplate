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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // button1
            // 
            button1.Location = new Point(50, 195);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 4;
            button1.Text = "Create InMemory DB";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(50, 235);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 5;
            button2.Text = "Create InMemory DB";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(50, 274);
            button3.Name = "button3";
            button3.Size = new Size(136, 23);
            button3.TabIndex = 6;
            button3.Text = "Create InMemory DB";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(50, 316);
            button4.Name = "button4";
            button4.Size = new Size(136, 23);
            button4.TabIndex = 7;
            button4.Text = "Create InMemory DB";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(230, 443);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CreateinmemoryDBbutton);
            Controls.Add(MoveDatabutton);
            Controls.Add(GridViewbutton);
            Controls.Add(CreateLocalDBbutton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Samples";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Button CreateLocalDBbutton;
        private Button GridViewbutton;
        private Button MoveDatabutton;
        private Button CreateinmemoryDBbutton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}