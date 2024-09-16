using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapbuoi3
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(tbln.Text);
            lvi.SubItems.Add(tbfn.Text);
            lvi.SubItems.Add(tbp.Text);
            listView1.Items.Add(lvi);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Người Để Xoá");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectItem = listView1.SelectedItems[0];
                tbln.Text = selectItem.SubItems[0].Text; // Cột 0: Last Name
                tbfn.Text = selectItem.SubItems[1].Text; // Cột 1: First Name
                tbp.Text = selectItem.SubItems[2].Text; // Cột 2: Phone
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để chỉnh sửa.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[0].Text = tbln.Text; 
                selectedItem.SubItems[1].Text = tbfn.Text;
                selectedItem.SubItems[2].Text = tbp.Text;

                MessageBox.Show("Cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để cập nhật.");
            }
        }
    }
}
