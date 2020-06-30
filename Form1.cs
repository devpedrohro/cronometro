using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            lerHistorico();
        }

        string historico = "historico.txt";
        int segundos = 0;
        int minutos = 0;
        int horas = 0;
        bool salvo, cronometro = true, temporizador;
        int millisegundos = 0;

        private void BtnIniciar_Click(object sender, EventArgs e) {
            tmrCronometro.Start();
        }

        private void BtnParar_Click(object sender, EventArgs e) {
            tmrCronometro.Stop();
            cronometroParar();
        }

        private void BtnZerar_Click(object sender, EventArgs e) {
            tmrCronometro.Stop();
            cronometroZerar();
            lerHistorico();
        }

        private void BtnSalvar_Click(object sender, EventArgs e) {
            salvarHistorico(segundos, minutos, horas);
            lerHistorico();
        }

        private void TmrCronometro_Tick(object sender, EventArgs e) {
            cronometroIniciar();
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            if (salvo)
                Application.Exit();
            else {
                cronometroParar();
                if (MessageBox.Show("Tempo do cronômetro não foi salvo no histórico. \nDeseja salvar?", "Histórico", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    salvarHistorico(segundos, minutos, horas);
                    Application.Exit();
                } else {
                    Application.Exit();
                }
            }
        }

        private void PtbLimpar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja limpar o histórico?", "Limpar Histórico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                limparHistorico();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e) {

        }

        void cronometroIniciar() {
            lblSegundos.ForeColor = Color.White;
            lblMinutos.ForeColor = Color.White;
            lblHoras.ForeColor = Color.White;

            millisegundos++;
            lblMilliseconds.Text = millisegundos.ToString();

            if (cronometro) {
                if (millisegundos == 100) {
                    millisegundos = 0;
                    segundos++;
                    if (segundos < 10)
                        lblSegundos.Text = "0" + segundos;
                    else
                        lblSegundos.Text = segundos.ToString();

                    //if (segundos == 60) {
                    //    minutos++;
                    //    segundos = 0;
                    //    if (minutos < 10)
                    //        lblMinutos.Text = "0" + minutos;
                    //    else
                    //        lblMinutos.Text = minutos.ToString();
                    //    if (minutos == 60) {
                    //        horas = 0;
                    //        minutos = 0;
                    //        if (horas < 10)
                    //            lblHoras.Text = "0" + horas;
                    //        else
                    //            lblHoras.Text = horas.ToString();
                    //    }
                    //}
                }
            } else if (temporizador) {
                pnlTempoHoras.Visible = false;
                pnlTempoMinutos.Visible = false;
                pnlTempoSegundos.Visible = false;
                btnParar.Visible = true;
                btnSalvar.Visible = true;
                btnZerar.Visible = true;

                segundos--;

                if (segundos < 10)
                    lblSegundos.Text = "0" + segundos;
                else
                    lblSegundos.Text = segundos.ToString();

                Thread thread = new Thread(countDownSegundos);

                if (segundos == 0) {
                    segundos = 60;

                    thread.Start();

                    horas--;

                    if(minutos < 10)
                        lblMinutos.Text = "0" + minutos;
                    else
                        lblMinutos.Text = minutos.ToString();
                }
                //if (segundos == 0) {
                //    minutos--;

                //    if (minutos >= 0)
                //        segundos = 60;

                //    if (minutos < 10)
                //        lblMinutos.Text = "0" + minutos;
                //    else
                //        lblMinutos.Text = minutos.ToString();

                //    else {
                //        lblHoras.ForeColor = Color.Red;
                //        lblMinutos.ForeColor = Color.Red;
                //        lblSegundos.ForeColor = Color.Red;
                //        segundos = 0;
                //    }
                //}


            }
        }

        void countDownSegundos() {
            if (segundos > 0) 
                segundos--;
        }

        void countDownMinutos() {
            if (minutos > 0)
                minutos--;
        }

        void countDownHoras() {
            if (horas > 0)
                horas--;
        }

        void cronometroZerar() {
            //salvarHistorico(segundos, minutos, horas);
            lblSegundos.ForeColor = Color.White;
            lblMinutos.ForeColor = Color.White;
            lblHoras.ForeColor = Color.White;
            segundos = 0;
            minutos = 0;
            horas = 0;
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";
        }

        void cronometroParar() {
            lblSegundos.ForeColor = Color.Red;
            lblMinutos.ForeColor = Color.Red;
            lblHoras.ForeColor = Color.Red;
        }

        void salvarHistorico(int segundos, int minutos, int horas) {
            if (File.Exists(historico)) {
                if (totalHistorico() > 0)
                    File.AppendAllText(historico, "\n" + labelHistoricoText(segundos, minutos, horas));
                else
                    File.AppendAllText(historico, labelHistoricoText(segundos, minutos, horas));
            } else {
                using (File.CreateText(historico)) {
                };
                File.AppendAllText(historico, labelHistoricoText(segundos, minutos, horas));
            }
        }

        void criarLabelHistorico(int segundos, int minutos, int horas) {
            Label label = new Label();
            label.ForeColor = Color.FromArgb(142, 143, 16);
            label.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            label.Text = labelHistoricoText(segundos, minutos, horas);
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(200, 20);
            flpHistorico.Controls.Add(label);
            label.Show();
            salvo = true;
        }

        void lerHistorico() {
            flpHistorico.Controls.Clear();
            if (File.Exists(historico)) {
                var linesHistorico = File.ReadAllLines(historico);
                foreach (string linha in linesHistorico) {
                    int segundosHistorico = Convert.ToInt32(linha.Split(':')[2]);
                    int minutosHistorico = Convert.ToInt32(linha.Split(':')[1]);
                    int horasHistorico = Convert.ToInt32(linha.Split(':')[0]);

                    criarLabelHistorico(segundosHistorico, minutosHistorico, horasHistorico);
                }
            }
        }

        int totalHistorico() {
            if (File.Exists(historico)) {
                var linesHistorico = File.ReadAllLines(historico);
                return linesHistorico.Length;
            }

            return 0;
        }

        string labelHistoricoText(int segundos, int minutos, int horas) {
            string labelSegundos;
            string labelMinutos;
            string labelHoras;

            if (segundos < 10)
                labelSegundos = "0" + segundos;
            else
                labelSegundos = segundos.ToString();

            if (minutos < 10)
                labelMinutos = "0" + minutos;
            else
                labelMinutos = minutos.ToString();

            if (horas < 10)
                labelHoras = "0" + horas;
            else
                labelHoras = horas.ToString();

            return labelHoras + ":" + labelMinutos + ":" + labelSegundos;
        }

        void limparHistorico() {
            if (File.Exists(historico)) {
                File.Delete(historico);
                lerHistorico();
            }
        }

        private void PtbCronometro_Click(object sender, EventArgs e) {
            definirTempo();
        }

        void definirTempo() {
            cronometroZerar();
            pnlTempoHoras.Visible = true;
            pnlTempoMinutos.Visible = true;
            pnlTempoSegundos.Visible = true;
            btnParar.Visible = false;
            btnZerar.Visible = false;
            btnSalvar.Visible = false;
            btnIniciar.Visible = false;
            cronometro = false;
            temporizador = true;
        }


        #region AumentarDiminuir
        // ==================================
        // AUMENTAR / DIMINUIR TEMPO BUTTONS
        // ==================================
        private void BtnAumentarSegundos_Click(object sender, EventArgs e) {
            segundos++;
            if (segundos > 0)
                btnDiminuirSegundos.Visible = true;
            if (segundos == 60)
                btnAumentarSegundos.Visible = false;
            if (segundos < 10)
                lblSegundos.Text = "0" + segundos;
            else
                lblSegundos.Text = segundos.ToString();

            btnIniciar.Visible = true;
        }

        private void BtnDiminuirSegundos_Click(object sender, EventArgs e) {
            segundos--;
            if (segundos <= 60)
                btnAumentarSegundos.Visible = true;
            if (segundos == 0)
                btnDiminuirSegundos.Visible = false;
            if (segundos < 10)
                lblSegundos.Text = "0" + segundos;
            else
                lblSegundos.Text = segundos.ToString();

            btnIniciar.Visible = true;
        }

        private void BtnAumentarMinutos_Click(object sender, EventArgs e) {
            minutos++;
            if (minutos > 0)
                btnDiminuirMinutos.Visible = true;
            if (minutos == 60)
                btnAumentarMinutos.Visible = false;
            if (minutos < 10)
                lblMinutos.Text = "0" + minutos;
            else
                lblMinutos.Text = minutos.ToString();

            btnIniciar.Visible = true;
        }

        private void BtnDiminuirMinutos_Click(object sender, EventArgs e) {
            minutos--;
            if (minutos <= 60)
                btnAumentarMinutos.Visible = true;
            if (minutos == 0)
                btnDiminuirMinutos.Visible = false;
            if (minutos < 10)
                lblMinutos.Text = "0" + minutos;
            else
                lblMinutos.Text = minutos.ToString();

            btnIniciar.Visible = true;
        }

        private void BtnAumentarHoras_Click(object sender, EventArgs e) {
            horas++;
            if (horas > 0)
                btnDiminuirHoras.Visible = true;
            if (horas == 60)
                btnAumentarHoras.Visible = false;
            if (horas < 10)
                lblHoras.Text = "0" + horas;
            else
                lblHoras.Text = horas.ToString();

            btnIniciar.Visible = true;
        }

        private void BtnDiminuirHoras_Click(object sender, EventArgs e) {
            horas--;
            if (horas <= 60)
                btnAumentarHoras.Visible = true;
            if (horas == 0)
                btnDiminuirHoras.Visible = false;
            if (horas < 10)
                lblHoras.Text = "0" + horas;
            else
                lblHoras.Text = horas.ToString();

            btnIniciar.Visible = true;
        }

        #endregion AumentarDiminuir
    }
}
