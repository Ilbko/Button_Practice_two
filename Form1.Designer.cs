﻿using System.Drawing;
using System.Windows.Forms;

namespace Button_Practice_two
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            this.button_1 = new Button();
            this.button_2 = new Button();

            this.button_1.Size = new Size(50, 50);
            this.button_2.Size = new Size(50, 50);

            this.button_1.Location = new Point(r.Next(0, this.Size.Width - this.button_1.Size.Width), r.Next(0, this.Size.Height - this.button_2.Size.Height));
            this.button_2.Location = new Point(r.Next(0, this.Size.Width - this.button_2.Size.Width), r.Next(0, this.Size.Height - this.button_2.Size.Height));

            //if (r.Next() % 2 == 1)
            if (r.Next(0, 2) == 1)
            {
                this.button_1.BackColor = Color.Red;
                this.button_2.BackColor = Color.Green;
            }
            else
            {
                this.button_1.BackColor = Color.Green;
                this.button_2.BackColor = Color.Red;
            }

            button_1.MouseMove += new System.Windows.Forms.MouseEventHandler(Mouse_Hover);
            button_2.MouseMove += new System.Windows.Forms.MouseEventHandler(Mouse_Hover);

            button_1.MouseClick += new MouseEventHandler(Mouse_Click);
            button_2.MouseClick += new MouseEventHandler(Mouse_Click);

            this.Controls.Add(button_1);
            this.Controls.Add(button_2);
        }
        Button button_1;
        Button button_2;

        #endregion
    }
}

