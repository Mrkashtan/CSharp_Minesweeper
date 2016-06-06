namespace сАпер
{
    partial class Form2
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.bttNnewgame = new System.Windows.Forms.Button();
            this.bttNclose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(233, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Новичёк(поле 9*9,10 мин) ";
            this.radioButton1.UseVisualStyleBackColor = true;
            
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 102);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(265, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Любитель(поле 16*16, 40 мин)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 149);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(232, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Вояка(поле 30*16, 99 мин)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // bttNnewgame
            // 
            this.bttNnewgame.Location = new System.Drawing.Point(934, 332);
            this.bttNnewgame.Name = "bttNnewgame";
            this.bttNnewgame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttNnewgame.Size = new System.Drawing.Size(85, 52);
            this.bttNnewgame.TabIndex = 4;
            this.bttNnewgame.Text = "Новая игра";
            this.bttNnewgame.UseVisualStyleBackColor = true;
            this.bttNnewgame.Click += new System.EventHandler(this.bttNnewgame_Click);
            // 
            // bttNclose
            // 
            this.bttNclose.Location = new System.Drawing.Point(842, 332);
            this.bttNclose.Name = "bttNclose";
            this.bttNclose.Size = new System.Drawing.Size(86, 52);
            this.bttNclose.TabIndex = 5;
            this.bttNclose.Text = "Выход";
            this.bttNclose.UseVisualStyleBackColor = true;
            this.bttNclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите сложность";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(541, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 201);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите цвет";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(11, 149);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(99, 24);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Красный";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(8, 102);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(102, 24);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Зелёный";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(11, 47);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 24);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Синий";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttNclose);
            this.Controls.Add(this.bttNnewgame);
            this.Name = "Form2";
            this.Text = "Начни игру";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button bttNnewgame;
        private System.Windows.Forms.Button bttNclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}