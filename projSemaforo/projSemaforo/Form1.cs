using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projSemaforo
{
    public partial class Form1 : Form
    {
        private Semaforo semaforo;
        public Form1()
        {
            InitializeComponent();
            semaforo = new Semaforo();
            atualizaInterface();
        }

        public void atualizaInterface()
        {
            lblEstado.Text = Convert.ToString(semaforo.getEstado(), 2);
            lblRua1.Text = Convert.ToString(semaforo.getEstado(1));
            lblRua2.Text = Convert.ToString(semaforo.getEstado(2));
            picRua1.Image = (semaforo.getEstado(1) == 1) ? projSemaforo.Properties.Resources.verde :
                                        (semaforo.getEstado(1) == 2) ? projSemaforo.Properties.Resources.amarelo :
                                        projSemaforo.Properties.Resources.vermelho;
            picRua2.Image = (semaforo.getEstado(2) == 1) ? projSemaforo.Properties.Resources.verde :
                                        (semaforo.getEstado(2) == 2) ? projSemaforo.Properties.Resources.amarelo :
                                        projSemaforo.Properties.Resources.vermelho;

        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            semaforo.setVerde(radRua1.Checked ? 1 : 2);
            atualizaInterface();
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            semaforo.setVermelho(radRua1.Checked ? 1 : 2);
            atualizaInterface();
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            semaforo.setAmarelo(radRua1.Checked ? 1 : 2);
            atualizaInterface();
        }

        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {
            btnLigaDesliga.Text = (btnLigaDesliga.Text == "Liga") ? "Desliga" : "Liga";
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (semaforo.getEstado(1) == 1)
            {
                semaforo.setAmarelo(1);
            }
            else
                if (semaforo.getEstado(1) == 2)
                    {
                semaforo.setVermelho(1);
                semaforo.setVerde(2);
                    }

            atualizaInterface();
        }

    }
}
