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
    }
}
