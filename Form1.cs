using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Practice_two
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public void Mouse_Hover(object obj, EventArgs argv)
        {
            if (((Button)obj).BackColor == Color.Red)
            {
                var relativePoint = this.PointToClient(Cursor.Position);

                ((Button)obj).Location = new Point(relativePoint.X - ((Button)obj).Size.Width / 2, relativePoint.Y - ((Button)obj).Size.Height / 2);
                this.Text = Cursor.Position.ToString();
            }
        }

        //public void Mouse_Click(object obj, MouseEventArgs argv)
        public void Mouse_Click(object obj, EventArgs argv)
        {
            MouseEventArgs me = (MouseEventArgs)argv;

            //if (me.Button == System.Windows.Forms.MouseButtons.Right)
            //{                
            //    Form_Reload();
            //}

            if (me.Button.Equals(MouseButtons.Left) && ((Button)obj).BackColor == Color.Red)
            {
                Form_Reload();
            }
        }

        public void Form_Reload()
        {
            button_1.Dispose();
            button_2.Dispose();

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

    }
}
