using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Aula_23_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(
            System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PictureBox_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox_restaurar.Visible = true;
            pictureBox_maximizar.Visible = false;
        }

        private void PictureBox_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox_restaurar.Visible = false;
            pictureBox_maximizar.Visible = true;
        }

        private void PictureBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
            
        private void PictureBox_menu_Click_1(object sender, EventArgs e)
        {
            if (panel_vertical.Width == 238)
            {
                panel_vertical.Width = 0;
            }
            else
            {
                panel_vertical.Width = 238;
            }
        }

        private void Panel_header_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Método que encaixa os formulários no Form1
        private void AbrirFormulario(Object prodForm)
        {
            if (this.panel_conteudo.Controls.Count > 0)           
                this.panel_conteudo.Controls.RemoveAt(0);
            Form fh = prodForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_conteudo.Controls.Add(fh);
            this.panel_conteudo.Tag = fh;
            fh.Show();
        }

        private void Btn_historia_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Historia());
            
        }

        private void Btn_jogo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Jogo());
        }

        private void Panel_conteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
