using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorasPonto
{
    public partial class FormPrincipal : Form
    {
        private const int HORAS_DIA = 23;
        private const int MINUTOS_DIA = 59;
        private string directoryPath = Directory.GetCurrentDirectory();
        private TimeSpan timeIntervaloSaida;
        private TimeSpan timeIntervaloEntrada;
        private TimeSpan horaMinutoSaida;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            setaIconNotify();

            setaCombo(cbHoraEntrada, HORAS_DIA, "06");
            setaCombo(cbMinutoEntrada, MINUTOS_DIA, "45");

            setaCombo(cbHoraIntervaloSaida, HORAS_DIA, "10");
            setaCombo(cbHoraIntervaloEntrada, HORAS_DIA, "10");

            setaCombo(cbMinutoIntervaloSaida, MINUTOS_DIA, "00");
            setaCombo(cbMinutoIntervaloEntrada, MINUTOS_DIA, "15");

            notifyIcon1.Visible = false;
        }

        private void setaIconNotify()
        {
            this.Icon = notifyIcon1.Icon = new Icon(directoryPath + "\\Resources\\clock.ico");
        }

        private void btnCalcularSaida_Click(object sender, EventArgs e)
        {
            calculaSaida();
            setaTextoNoficitacao();
            startAlarmeIntervaloESaida();
        }

        private void startAlarmeIntervaloESaida()
        {
            timer1.Interval = 60000;
            timer1.Start();
        }

        private void setaTextoNoficitacao()
        {
            notifyIcon1.Text = string.Format("Saída às {0}:{1}", txtHoraSaida.Text, txtMinutoSaida.Text);
        }

        private void calculaSaida()
        {
            int horaEntrada = Convert.ToInt32(cbHoraEntrada.SelectedItem);
            int minutoEntrada = Convert.ToInt32(cbMinutoEntrada.SelectedItem);
            int horaIntervaloSaida = Convert.ToInt32(cbHoraIntervaloSaida.SelectedItem);
            int minutoIntervaloSaida = Convert.ToInt32(cbMinutoIntervaloSaida.SelectedItem);
            int horaIntervaloEntrada = Convert.ToInt32(cbHoraIntervaloEntrada.SelectedItem);
            int minutoIntervaloEntrada = Convert.ToInt32(cbMinutoIntervaloEntrada.SelectedItem);

            TimeSpan timeEntrada = new TimeSpan(horaEntrada, minutoEntrada, 0);
            timeIntervaloSaida = new TimeSpan(horaIntervaloSaida, minutoIntervaloSaida, 0);

            TimeSpan tempoAteIntervalo = timeIntervaloSaida - timeEntrada;
            TimeSpan tempoTotal = new TimeSpan(6, 0, 0);
            TimeSpan tempoQueFalta = tempoTotal - tempoAteIntervalo;

            timeIntervaloEntrada = new TimeSpan(horaIntervaloEntrada, minutoIntervaloEntrada, 0);
            horaMinutoSaida = timeIntervaloEntrada + tempoQueFalta;

            txtHoraSaida.Text = horaMinutoSaida.Hours.ToString().PadLeft(2, '0');
            txtMinutoSaida.Text = horaMinutoSaida.Minutes.ToString().PadLeft(2, '0');
        }

        private void setaCombo(ComboBox combo, int tempo, string valueDefault)
        {
            combo.DataSource = getListTempo(tempo);
            if (!string.IsNullOrEmpty(valueDefault))
            {
                combo.SelectedItem = valueDefault;
            }
        }

        private IList<string> getListTempo(int horaOuMinuto)
        {
            IList<string> tempos = new List<string>();

            for (int i = 0; i <= horaOuMinuto; i++)
            {
                string tempo = i.ToString().PadLeft(2, '0');
                tempos.Add(tempo);
            }

            return tempos;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            verificaHoraParaAlarme(timeIntervaloSaida, "Ponto intervalo");
            verificaHoraParaAlarme(timeIntervaloEntrada, "Ponto intervalo volta");
            verificaHoraParaAlarme(horaMinutoSaida, "É hora de dar TCHAU!!!");
        }

        private void verificaHoraParaAlarme(TimeSpan timeSpan, string mensagem)
        {
            DateTime agora = DateTime.Now;
            TimeSpan agoraHoraMinuto = new TimeSpan(agora.Hour, agora.Minute, 0);

            TimeSpan diff = timeSpan - agoraHoraMinuto;

            if (diff.Hours == 0 && diff.Minutes == 0)
            {
                FormAlarme form = new FormAlarme(mensagem, directoryPath);
                form.Icon = this.Icon;
                form.ShowDialog();
            }
        }
    }
}
