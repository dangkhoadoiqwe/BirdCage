using Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping
{
    public partial class Login : Form
    {
        AccountReponsitory repo = new AccountReponsitory();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String pass = txtPass.Text;
                var account = repo.Login(name, pass);
                if (account != null)
                {
                    MessageBox.Show("Successfully");
                    ListAllProduct listAllProduct = new ListAllProduct();
                    listAllProduct.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra tên đăng nhập và mật khẩu.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
