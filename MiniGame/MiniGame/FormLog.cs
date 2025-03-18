using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
            richTextBox1.Text = "";
        }

        public FormLog(string log)
        {
            InitializeComponent();
            richTextBox1.Text = log;
        }
    }
}