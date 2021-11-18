using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.appData.karyawan);
            karyawanBindingSource.DataSource = this.appData.karyawan;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                spdataemploye.Enabled = true;
                txtfullname.Focus();
                this.appData.karyawan.AddkaryawanRow(this.appData.karyawan.NewkaryawanRow());
                karyawanBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                karyawanBindingSource.ResetBindings(false);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.JPG", ValidateNames = true, Multiselect = false }) 
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictview.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                karyawanBindingSource.EndEdit();
                karyawanTableAdapter.Update(this.appData.karyawan);
                spdataemploye.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                karyawanBindingSource.ResetBindings(false);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            spdataemploye.Enabled = true;
            txtfullname.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            spdataemploye.Enabled = false;
            karyawanBindingSource.ResetBindings(false);
        }

        private void gridemploye_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Data akan di hapus", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    karyawanBindingSource.RemoveCurrent();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    this.karyawanTableAdapter.Fill(this.appData.karyawan);
                    karyawanBindingSource.DataSource = this.appData.karyawan;
                }
                else
                {
                    var query = from o in this.appData.karyawan
                                where o.FullName.Contains(textBox1.Text) ||
                                o.PhoneNumber == textBox1.Text ||
                                o.Email == textBox1.Text ||
                                o.Address.Contains(textBox1.Text)
                                select o;
                    //karyawanBindingSource.DataSource = query.ToList();
                }
            }
        }
    }
}
