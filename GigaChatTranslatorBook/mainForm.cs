using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace GigaChatTranslatorBook
{
    public partial class mainForm : Form
    {
        public static string f_name = "";
        public static string f_path = "";
        public static string f_type = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            var f_fdo = new OpenFileDialog();
            f_fdo.Filter = "fb2 book(*.fb2)|*.fb2";
            if (f_fdo.ShowDialog() == DialogResult.Cancel)
                return;
            MessageBox.Show(f_fdo.FileName);
        }
    }
}
