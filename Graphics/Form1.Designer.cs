﻿namespace Graphics
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(235, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 526);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // grpBoxTypeDiagram
            // 
            this.grpBoxTypeDiagram.Location = new System.Drawing.Point(13, 26);
            this.grpBoxTypeDiagram.Name = "grpBoxTypeDiagram";
            this.grpBoxTypeDiagram.Size = new System.Drawing.Size(200, 100);
            this.grpBoxTypeDiagram.TabIndex = 1;
            this.grpBoxTypeDiagram.TabStop = false;
            this.grpBoxTypeDiagram.Text = "Loại sơ đồ";
            // 
            // grpBoxShape
            // 
            this.grpBoxShape.Location = new System.Drawing.Point(13, 142);
            this.grpBoxShape.Name = "grpBoxShape";
            this.grpBoxShape.Size = new System.Drawing.Size(200, 410);
            this.grpBoxShape.TabIndex = 0;
            this.grpBoxShape.TabStop = false;
            this.grpBoxShape.Text = "Hình vẽ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 565);
            this.Controls.Add(this.grpBoxShape);
            this.Controls.Add(this.grpBoxTypeDiagram);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxTypeDiagram;
        private System.Windows.Forms.GroupBox grpBoxShape;
    }
}

