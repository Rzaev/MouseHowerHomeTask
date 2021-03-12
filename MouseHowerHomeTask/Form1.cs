using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHowerHomeTask
{
    public partial class Form1 : Form
    {
        Image image = Properties.Resources.Femalee;
        public Form1()
        {
            InitializeComponent();
            ChangeCursor();
        }


        private void ChangeCursor()
        {
            Bitmap btm = new Bitmap(Properties.Resources.male);
            Cursor c = new Cursor(btm.GetHicon());
            this.Cursor = c;
        }

       

      
        private void FemaleBtn_MouseHover(object sender, EventArgs e)
        {
            if(sender is Button bt)
            {
                bt.Dispose();
                Button button = new Button();
                
                button.MouseHover += FemaleBtn_MouseHover;
                button.Image = image;
                button.AutoSize = true;


                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 120);
                int randomY = random.Next(this.Size.Height - 120);
                button.Location = new Point(randomX, randomY);

                this.Controls.Add(button);
            }
        }
    }
}
