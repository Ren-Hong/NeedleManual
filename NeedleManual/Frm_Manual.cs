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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            if (txt_Distance.Text == "" )
            {
                MessageBox.Show("請輸入距離");
                return;
            }
            else if (cmb_Nozzle.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇移動軸");
                return;
            }
            dgv_ManualList.Rows.Add(cmb_Nozzle.Text, Convert.ToDouble(txt_Distance.Text), txt_Comment.Text);
            txt_Distance.Text = "";
            txt_Comment.Text = "";
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

        private void txt_Distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 檢查是否為數字、小數點或控制鍵（如Backspace）
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 阻止非數字和小數點的輸入
            }

            // 確保小數點只能輸入一次
            if (e.KeyChar == '.' && txt_Distance.Text.Contains("."))
            {
                e.Handled = true; // 阻止重複輸入小數點
            }
        }
    }
}
