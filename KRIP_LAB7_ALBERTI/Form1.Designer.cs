﻿namespace KRIP_LAB7_ALBERTI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShifrText = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.Text = new System.Windows.Forms.TextBox();
            this.button_unShifr = new System.Windows.Forms.Button();
            this.button_Shifr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShifrText
            // 
            this.ShifrText.Location = new System.Drawing.Point(139, 214);
            this.ShifrText.Name = "ShifrText";
            this.ShifrText.Size = new System.Drawing.Size(391, 20);
            this.ShifrText.TabIndex = 19;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(100, 104);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(81, 20);
            this.keyBox.TabIndex = 18;
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(139, 38);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(384, 20);
            this.Text.TabIndex = 17;
            // 
            // button_unShifr
            // 
            this.button_unShifr.Location = new System.Drawing.Point(243, 133);
            this.button_unShifr.Name = "button_unShifr";
            this.button_unShifr.Size = new System.Drawing.Size(75, 23);
            this.button_unShifr.TabIndex = 16;
            this.button_unShifr.Text = "unShifr";
            this.button_unShifr.UseVisualStyleBackColor = true;
            this.button_unShifr.Click += new System.EventHandler(this.button_unShifr_Click);
            // 
            // button_Shifr
            // 
            this.button_Shifr.Location = new System.Drawing.Point(243, 79);
            this.button_Shifr.Name = "button_Shifr";
            this.button_Shifr.Size = new System.Drawing.Size(75, 23);
            this.button_Shifr.TabIndex = 15;
            this.button_Shifr.Text = "Shifr";
            this.button_Shifr.UseVisualStyleBackColor = true;
            this.button_Shifr.Click += new System.EventHandler(this.button_Shifr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 300);
            this.Controls.Add(this.ShifrText);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.button_unShifr);
            this.Controls.Add(this.button_Shifr);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShifrText;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.Button button_unShifr;
        private System.Windows.Forms.Button button_Shifr;
    }
}

