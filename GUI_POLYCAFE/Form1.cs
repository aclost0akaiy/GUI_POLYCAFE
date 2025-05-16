using BDUtil.POLYCAFE;
using BLL_POLYCSAFE;
using DTO_POLYCAFE;

namespace GUI_POLYCAFE
{
    public partial class Form1 : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public Form1()
        {
            InitializeComponent();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            NhANVIEN nv = busNhanVien.Dangnhap(username, password);
            if (nv == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không đúng");
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài khoản đã bị khóa");
                    return;
                }
                AuthUtil.user = nv;
                Frommain main = new Frommain();
                main.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
