using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class UpdateClassForm : Form
    {
        private int Classid;
        private ClassManagenment Business;
        public UpdateClassForm(int id)
        {
            InitializeComponent();
            this.Classid = id;
            this.Business = new ClassManagenment();
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            this.Load += UpdateClassForm_Load;
        }

        void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var @class = this.Business.GetClass(this.Classid);
            this.txtName.Text = @class.Name;
            this.txtDescription.Text = @class.Description;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this .txtName.Text;
            var description = this.txtDescription.Text;
            this.Business.EditClass(this.Classid, name, description);
            MessageBox.Show("Update Class successfully ");
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
