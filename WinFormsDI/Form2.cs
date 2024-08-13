using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDI
{
    public partial class Form2 : Form
    {
        private readonly IMyService _myService;
        public Form2(IMyService myservice)
        {
            InitializeComponent();
            _myService = myservice;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_myService.Mensaje());
        }
    }
}
