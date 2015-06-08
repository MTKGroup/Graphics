namespace Graphics
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBoxTypeDiagram = new System.Windows.Forms.GroupBox();
            this.grpBoxShape = new System.Windows.Forms.GroupBox();
            this.grpBoxEffect = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gdiLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cairoLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(284, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 526);
            this.panel1.TabIndex = 0;
            // 
            // grpBoxTypeDiagram
            // 
            this.grpBoxTypeDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxTypeDiagram.Location = new System.Drawing.Point(13, 61);
            this.grpBoxTypeDiagram.Name = "grpBoxTypeDiagram";
            this.grpBoxTypeDiagram.Size = new System.Drawing.Size(235, 100);
            this.grpBoxTypeDiagram.TabIndex = 1;
            this.grpBoxTypeDiagram.TabStop = false;
            this.grpBoxTypeDiagram.Text = "Diagrams";
            // 
            // grpBoxShape
            // 
            this.grpBoxShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxShape.Location = new System.Drawing.Point(13, 301);
            this.grpBoxShape.Name = "grpBoxShape";
            this.grpBoxShape.Size = new System.Drawing.Size(235, 286);
            this.grpBoxShape.TabIndex = 0;
            this.grpBoxShape.TabStop = false;
            this.grpBoxShape.Text = "Shapes";
            // 
            // grpBoxEffect
            // 
            this.grpBoxEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxEffect.Location = new System.Drawing.Point(13, 176);
            this.grpBoxEffect.Name = "grpBoxEffect";
            this.grpBoxEffect.Size = new System.Drawing.Size(235, 100);
            this.grpBoxEffect.TabIndex = 2;
            this.grpBoxEffect.TabStop = false;
            this.grpBoxEffect.Text = "Effects";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.graphicsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpegToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.saveToolStripMenuItem.Text = "Save as";
            // 
            // jpegToolStripMenuItem
            // 
            this.jpegToolStripMenuItem.Name = "jpegToolStripMenuItem";
            this.jpegToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.jpegToolStripMenuItem.Text = "jpeg";
            // 
            // graphicsToolStripMenuItem
            // 
            this.graphicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gdiLibraryToolStripMenuItem,
            this.cairoLibraryToolStripMenuItem});
            this.graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
            this.graphicsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.graphicsToolStripMenuItem.Text = "Graphics";
            // 
            // gdiLibraryToolStripMenuItem
            // 
            this.gdiLibraryToolStripMenuItem.CheckOnClick = true;
            this.gdiLibraryToolStripMenuItem.Name = "gdiLibraryToolStripMenuItem";
            this.gdiLibraryToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.gdiLibraryToolStripMenuItem.Text = "Gdi+ library";
            this.gdiLibraryToolStripMenuItem.CheckedChanged += new System.EventHandler(this.graphicsLibraryToolStripMenuItem_CheckedChanged);
            // 
            // cairoLibraryToolStripMenuItem
            // 
            this.cairoLibraryToolStripMenuItem.CheckOnClick = true;
            this.cairoLibraryToolStripMenuItem.Name = "cairoLibraryToolStripMenuItem";
            this.cairoLibraryToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.cairoLibraryToolStripMenuItem.Text = "Cairo library";
            this.cairoLibraryToolStripMenuItem.CheckedChanged += new System.EventHandler(this.graphicsLibraryToolStripMenuItem_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 600);
            this.Controls.Add(this.grpBoxEffect);
            this.Controls.Add(this.grpBoxShape);
            this.Controls.Add(this.grpBoxTypeDiagram);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxTypeDiagram;
        private System.Windows.Forms.GroupBox grpBoxShape;
        private System.Windows.Forms.GroupBox grpBoxEffect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gdiLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cairoLibraryToolStripMenuItem;
    }
}

