﻿namespace LINQDemoReVisit
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(84, 86);
            button1.Name = "button1";
            button1.Size = new Size(110, 86);
            button1.TabIndex = 0;
            button1.Text = "Where and ORder by";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 35);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Group by";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(240, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(254, 264);
            listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(582, 86);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(254, 264);
            listBox2.TabIndex = 3;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(1003, 86);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(254, 264);
            listBox3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(489, 35);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Select Many";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 524);
            Controls.Add(button3);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button3;
    }
}
