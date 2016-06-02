using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace twitchBot {

    public partial class LoginWindow : Form {
        private MainForm f;
        private loginInfo li;

        public LoginWindow() {
            InitializeComponent();
            winforms.centerToMainScreen(this);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.FormClosed += LoginWindow_FormClosed;
            loadLoginData();
        }

        public LoginWindow(bool visible, loginInfo lli) {
            InitializeComponent();
            winforms.centerToMainScreen(this);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            loadLoginData();
            li = lli;
            textBoxUsername.Text = String.Copy(li.username);
            textBoxPassword.Text = String.Copy(li.password);
            textBoxRoom.Text = String.Copy(li.channel);
            this.FormClosed += LoginWindow_FormClosed;
            if (!visible)
                connect();
        }


        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void saveLoginData() {
            Directory.SetCurrentDirectory(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            FileStream fs = new FileStream("login_data.txt", FileMode.OpenOrCreate, FileAccess.Write);
            try {
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine(li.username);
                writer.WriteLine(li.password);
                writer.WriteLine(li.channel);
                writer.Close();
            }
            finally {
                fs.Close();
            }
        }

        private void loadLoginData() {
            li = new loginInfo("", "", "");
            Directory.SetCurrentDirectory(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            FileStream fs = new FileStream("login_data.txt", FileMode.Open, FileAccess.Read);
            try {
                StreamReader reader = new StreamReader(fs);
                li.username = reader.ReadLine();
                li.password = reader.ReadLine();
                li.channel = reader.ReadLine();
                reader.Close();
            }
            finally {
                fs.Close();
                textBoxUsername.Text = String.Copy(li.username);
                textBoxPassword.Text = String.Copy(li.password);
                textBoxRoom.Text = String.Copy(li.channel);
            }
        }

        private void connect() {
            li = new loginInfo(textBoxUsername.Text, textBoxPassword.Text, textBoxRoom.Text);
            saveLoginData();
            f = new MainForm(this, li);
            f.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            connect();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape)
                this.Close();
            else if (keyData == Keys.Return)
                connect();
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
