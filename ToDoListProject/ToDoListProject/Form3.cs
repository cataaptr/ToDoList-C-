using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ToDoListProject
{
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTaskOk_Click(object sender, EventArgs e)
        {

        }
        public int GetSliderValue()
        {
            return slStatus.Value;
        }

        private void btnAddTaskCancel_Click(object sender, EventArgs e)
        {
            
        }
    }

}
