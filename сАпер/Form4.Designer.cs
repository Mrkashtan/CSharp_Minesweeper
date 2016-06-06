namespace сАпер
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 489);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра \"Сапер\" написана студентами 1 курса образовательной программы \"Инфокоммуника" +
    "ционные технологии и системы связи\" группы БИТ 153 Никитиной Еленой и Фроловым К" +
    "ириллом\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(508, 242);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Разработчики";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}