using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorasPonto
{
    public partial class FormAlarme : Form
    {
        //private string mensagem;
        private System.Media.SoundPlayer player;

        public FormAlarme(string mensagem, string directoryPath)
        {
            InitializeComponent();
            lbMensagem.Text = mensagem;
            player = new System.Media.SoundPlayer(string.Format("{0}\\Resources\\alarm.wav", directoryPath));
        }

        public FormAlarme()
        {
            InitializeComponent();
        }

        private void FormAlarme_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }
    }
}
