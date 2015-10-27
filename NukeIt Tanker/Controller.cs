using NukeIt_Tanker.CommManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NukeIt_Tanker
{
    public partial class Controller : Form
    {
        MessageHandler i;
        MessageSender ms;
        public Controller()
        {
            InitializeComponent();
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            i = new MessageHandler();
            ms = new MessageSender(i);
        }

        private void join_Click(object sender, EventArgs e)
        {
            ms.join();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ms.shoot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ms.right();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ms.up();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ms.down();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ms.left();
        }
    }
}
