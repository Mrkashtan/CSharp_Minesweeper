﻿namespace MineSweeper
{
    partial class NewGameForm
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
            this.rb_easy = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_hard = new System.Windows.Forms.RadioButton();
            this.bttn_start = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_easy
            // 
            this.rb_easy.AutoSize = true;
            this.rb_easy.Location = new System.Drawing.Point(18, 20);
            this.rb_easy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_easy.Name = "rb_easy";
            this.rb_easy.Size = new System.Drawing.Size(69, 24);
            this.rb_easy.TabIndex = 0;
            this.rb_easy.TabStop = true;
            this.rb_easy.Text = "Easy";
            this.rb_easy.UseVisualStyleBackColor = true;
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(18, 55);
            this.rb_medium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(90, 24);
            this.rb_medium.TabIndex = 1;
            this.rb_medium.TabStop = true;
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            this.rb_medium.CheckedChanged += new System.EventHandler(this.rb_medium_CheckedChanged);
            // 
            // rb_hard
            // 
            this.rb_hard.AutoSize = true;
            this.rb_hard.Location = new System.Drawing.Point(18, 91);
            this.rb_hard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_hard.Name = "rb_hard";
            this.rb_hard.Size = new System.Drawing.Size(69, 24);
            this.rb_hard.TabIndex = 2;
            this.rb_hard.TabStop = true;
            this.rb_hard.Text = "Hard";
            this.rb_hard.UseVisualStyleBackColor = true;
            this.rb_hard.CheckedChanged += new System.EventHandler(this.rb_hard_CheckedChanged);
            // 
            // bttn_start
            // 
            this.bttn_start.Location = new System.Drawing.Point(140, 143);
            this.bttn_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttn_start.Name = "bttn_start";
            this.bttn_start.Size = new System.Drawing.Size(112, 35);
            this.bttn_start.TabIndex = 3;
            this.bttn_start.Text = "Start Game";
            this.bttn_start.UseVisualStyleBackColor = true;
            this.bttn_start.Click += new System.EventHandler(this.bttn_start_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(18, 143);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 35);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cencel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 268);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.bttn_start);
            this.Controls.Add(this.rb_hard);
            this.Controls.Add(this.rb_medium);
            this.Controls.Add(this.rb_easy);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewGameForm";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_easy;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_hard;
        private System.Windows.Forms.Button bttn_start;
        private System.Windows.Forms.Button btn_cancel;
    }
}