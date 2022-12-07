using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL_NET1
{
    public partial class FormInit : Form
    {
        public FormInit()
        {
            InitializeComponent();
            FuncInit();
            
        }
        public async void FuncInit()
        {
            await Task.Delay(3000);
            FormMain fmain = new FormMain();
            fmain.Show();
            this.Hide();

        }

    }
}
