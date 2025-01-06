using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NeedleManual
{
    public partial class Frm_Manual : Form
    {
        public Frm_Manual()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Distance.Text != "")
            {
                dgv_ManualList.Rows.Add(cmb_Nozzle.Text, txt_Distance.Text, txt_Comment.Text);
                txt_Distance.Text = "";
                txt_Comment.Text = "";
            }
            else
            {
                MessageBox.Show("請輸入距離");
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_ManualList.Rows.Remove(dgv_ManualList.CurrentRow);
            }
            catch (Exception)
            {
                MessageBox.Show("請選擇要刪除的項目");
            }
        }
    }
}
