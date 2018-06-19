namespace ASMSim
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Code = new System.Windows.Forms.RichTextBox();
            this.Compiler = new System.Windows.Forms.Button();
            this.xText = new System.Windows.Forms.TextBox();
            this.AccText = new System.Windows.Forms.TextBox();
            this.yText = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.codeP = new System.Windows.Forms.TextBox();
            this.RunProgramTick = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoRUnFaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZDisplay = new System.Windows.Forms.TextBox();
            this.SDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(619, 12);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(113, 442);
            this.Code.TabIndex = 0;
            this.Code.Text = "";
            // 
            // Compiler
            // 
            this.Compiler.Location = new System.Drawing.Point(297, 408);
            this.Compiler.Name = "Compiler";
            this.Compiler.Size = new System.Drawing.Size(86, 48);
            this.Compiler.TabIndex = 1;
            this.Compiler.Text = "Run";
            this.Compiler.UseVisualStyleBackColor = true;
            this.Compiler.Click += new System.EventHandler(this.Compiler_Click);
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(483, 434);
            this.xText.Name = "xText";
            this.xText.ReadOnly = true;
            this.xText.Size = new System.Drawing.Size(130, 20);
            this.xText.TabIndex = 2;
            // 
            // AccText
            // 
            this.AccText.Location = new System.Drawing.Point(483, 327);
            this.AccText.Name = "AccText";
            this.AccText.ReadOnly = true;
            this.AccText.Size = new System.Drawing.Size(130, 20);
            this.AccText.TabIndex = 3;
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(483, 408);
            this.yText.Name = "yText";
            this.yText.ReadOnly = true;
            this.yText.Size = new System.Drawing.Size(130, 20);
            this.yText.TabIndex = 4;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(483, 225);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(130, 70);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset Program";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // codeP
            // 
            this.codeP.Location = new System.Drawing.Point(483, 301);
            this.codeP.Name = "codeP";
            this.codeP.ReadOnly = true;
            this.codeP.Size = new System.Drawing.Size(130, 20);
            this.codeP.TabIndex = 6;
            // 
            // RunProgramTick
            // 
            this.RunProgramTick.Enabled = true;
            this.RunProgramTick.Interval = 400;
            this.RunProgramTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1,
            this.readFormToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.testToolStripMenuItem.Text = "Menu";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem1.Text = "Info";
            this.testToolStripMenuItem1.Click += new System.EventHandler(this.ShowInfo);
            // 
            // readFormToolStripMenuItem
            // 
            this.readFormToolStripMenuItem.Name = "readFormToolStripMenuItem";
            this.readFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readFormToolStripMenuItem.Text = "Open File";
            this.readFormToolStripMenuItem.Click += new System.EventHandler(this.readFormToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoRUnFaToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // AutoRUnFaToolStripMenuItem
            // 
            this.AutoRUnFaToolStripMenuItem.Name = "AutoRUnFaToolStripMenuItem";
            this.AutoRUnFaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AutoRUnFaToolStripMenuItem.Text = "Debug Mode";
            this.AutoRUnFaToolStripMenuItem.Click += new System.EventHandler(this.AutoRun);
            // 
            // ZDisplay
            // 
            this.ZDisplay.Location = new System.Drawing.Point(483, 382);
            this.ZDisplay.Name = "ZDisplay";
            this.ZDisplay.ReadOnly = true;
            this.ZDisplay.Size = new System.Drawing.Size(130, 20);
            this.ZDisplay.TabIndex = 9;
            // 
            // SDisplay
            // 
            this.SDisplay.Location = new System.Drawing.Point(483, 356);
            this.SDisplay.Name = "SDisplay";
            this.SDisplay.ReadOnly = true;
            this.SDisplay.Size = new System.Drawing.Size(130, 20);
            this.SDisplay.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "StepForward >|";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(731, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SDisplay);
            this.Controls.Add(this.ZDisplay);
            this.Controls.Add(this.codeP);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.AccText);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.Compiler);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Code;
        private System.Windows.Forms.Button Compiler;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.TextBox AccText;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox codeP;
        private System.Windows.Forms.Timer RunProgramTick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.TextBox ZDisplay;
        private System.Windows.Forms.TextBox SDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoRUnFaToolStripMenuItem;
    }
}

