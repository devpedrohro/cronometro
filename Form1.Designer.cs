namespace Cronometro {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbLimpar = new System.Windows.Forms.PictureBox();
            this.flpHistorico = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlTempoMinutos = new System.Windows.Forms.Panel();
            this.btnDiminuirMinutos = new System.Windows.Forms.Button();
            this.btnAumentarMinutos = new System.Windows.Forms.Button();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlTempoSegundos = new System.Windows.Forms.Panel();
            this.btnDiminuirSegundos = new System.Windows.Forms.Button();
            this.btnAumentarSegundos = new System.Windows.Forms.Button();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlTempoHoras = new System.Windows.Forms.Panel();
            this.btnDiminuirHoras = new System.Windows.Forms.Button();
            this.btnAumentarHoras = new System.Windows.Forms.Button();
            this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ptbCronometro = new System.Windows.Forms.PictureBox();
            this.lblMilliseconds = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlTempoMinutos.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlTempoSegundos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlTempoHoras.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCronometro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 32);
            this.panel1.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Location = new System.Drawing.Point(1056, -7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(69, 36);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1182, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cronômetro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "HORAS";
            // 
            // lblHoras
            // 
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.White;
            this.lblHoras.Location = new System.Drawing.Point(3, 38);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(240, 153);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "00";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.ptbLimpar);
            this.panel2.Controls.Add(this.flpHistorico);
            this.panel2.Controls.Add(this.label8);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(-1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 184);
            this.panel2.TabIndex = 8;
            // 
            // ptbLimpar
            // 
            this.ptbLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbLimpar.Image = ((System.Drawing.Image)(resources.GetObject("ptbLimpar.Image")));
            this.ptbLimpar.Location = new System.Drawing.Point(13, 25);
            this.ptbLimpar.Name = "ptbLimpar";
            this.ptbLimpar.Size = new System.Drawing.Size(35, 20);
            this.ptbLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLimpar.TabIndex = 0;
            this.ptbLimpar.TabStop = false;
            this.ptbLimpar.Click += new System.EventHandler(this.PtbLimpar_Click);
            // 
            // flpHistorico
            // 
            this.flpHistorico.AutoScroll = true;
            this.flpHistorico.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpHistorico.Location = new System.Drawing.Point(5, 51);
            this.flpHistorico.Name = "flpHistorico";
            this.flpHistorico.Size = new System.Drawing.Size(227, 100);
            this.flpHistorico.TabIndex = 11;
            this.flpHistorico.WrapContents = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label8.Location = new System.Drawing.Point(56, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "HISTÓRICO";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(73, 392);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(205, 37);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(294, 392);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(205, 37);
            this.btnParar.TabIndex = 9;
            this.btnParar.Text = "PARAR";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar.Location = new System.Drawing.Point(736, 392);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(205, 37);
            this.btnZerar.TabIndex = 10;
            this.btnZerar.Text = "ZERAR";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.BtnZerar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlTempoSegundos);
            this.panel3.Controls.Add(this.pnlTempoMinutos);
            this.panel3.Controls.Add(this.pnlTempoHoras);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnZerar);
            this.panel3.Controls.Add(this.btnParar);
            this.panel3.Controls.Add(this.btnIniciar);
            this.panel3.Location = new System.Drawing.Point(235, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 555);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label3.Location = new System.Drawing.Point(759, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright 2019 Pedro Henrique Rocha";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(515, 392);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(205, 37);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblMinutos);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(384, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 244);
            this.panel5.TabIndex = 12;
            // 
            // pnlTempoMinutos
            // 
            this.pnlTempoMinutos.Controls.Add(this.btnDiminuirMinutos);
            this.pnlTempoMinutos.Controls.Add(this.btnAumentarMinutos);
            this.pnlTempoMinutos.Location = new System.Drawing.Point(438, 61);
            this.pnlTempoMinutos.Name = "pnlTempoMinutos";
            this.pnlTempoMinutos.Size = new System.Drawing.Size(140, 51);
            this.pnlTempoMinutos.TabIndex = 17;
            this.pnlTempoMinutos.Visible = false;
            // 
            // btnDiminuirMinutos
            // 
            this.btnDiminuirMinutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuirMinutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuirMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirMinutos.ForeColor = System.Drawing.Color.Yellow;
            this.btnDiminuirMinutos.Location = new System.Drawing.Point(80, 7);
            this.btnDiminuirMinutos.Name = "btnDiminuirMinutos";
            this.btnDiminuirMinutos.Size = new System.Drawing.Size(49, 37);
            this.btnDiminuirMinutos.TabIndex = 16;
            this.btnDiminuirMinutos.Text = "-";
            this.btnDiminuirMinutos.UseVisualStyleBackColor = true;
            this.btnDiminuirMinutos.Visible = false;
            this.btnDiminuirMinutos.Click += new System.EventHandler(this.BtnDiminuirMinutos_Click);
            // 
            // btnAumentarMinutos
            // 
            this.btnAumentarMinutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentarMinutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentarMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentarMinutos.ForeColor = System.Drawing.Color.Yellow;
            this.btnAumentarMinutos.Location = new System.Drawing.Point(12, 7);
            this.btnAumentarMinutos.Name = "btnAumentarMinutos";
            this.btnAumentarMinutos.Size = new System.Drawing.Size(49, 37);
            this.btnAumentarMinutos.TabIndex = 15;
            this.btnAumentarMinutos.Text = "+";
            this.btnAumentarMinutos.UseVisualStyleBackColor = true;
            this.btnAumentarMinutos.Click += new System.EventHandler(this.BtnAumentarMinutos_Click);
            // 
            // lblMinutos
            // 
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.White;
            this.lblMinutos.Location = new System.Drawing.Point(3, 38);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(240, 153);
            this.lblMinutos.TabIndex = 0;
            this.lblMinutos.Text = "00";
            this.lblMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "MINUTOS";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblMilliseconds);
            this.panel6.Controls.Add(this.lblSegundos);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(696, 118);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 244);
            this.panel6.TabIndex = 12;
            // 
            // pnlTempoSegundos
            // 
            this.pnlTempoSegundos.Controls.Add(this.btnDiminuirSegundos);
            this.pnlTempoSegundos.Controls.Add(this.btnAumentarSegundos);
            this.pnlTempoSegundos.Location = new System.Drawing.Point(736, 61);
            this.pnlTempoSegundos.Name = "pnlTempoSegundos";
            this.pnlTempoSegundos.Size = new System.Drawing.Size(140, 51);
            this.pnlTempoSegundos.TabIndex = 17;
            this.pnlTempoSegundos.Visible = false;
            // 
            // btnDiminuirSegundos
            // 
            this.btnDiminuirSegundos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuirSegundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuirSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirSegundos.ForeColor = System.Drawing.Color.Yellow;
            this.btnDiminuirSegundos.Location = new System.Drawing.Point(80, 7);
            this.btnDiminuirSegundos.Name = "btnDiminuirSegundos";
            this.btnDiminuirSegundos.Size = new System.Drawing.Size(49, 37);
            this.btnDiminuirSegundos.TabIndex = 16;
            this.btnDiminuirSegundos.Text = "-";
            this.btnDiminuirSegundos.UseVisualStyleBackColor = true;
            this.btnDiminuirSegundos.Visible = false;
            this.btnDiminuirSegundos.Click += new System.EventHandler(this.BtnDiminuirSegundos_Click);
            // 
            // btnAumentarSegundos
            // 
            this.btnAumentarSegundos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentarSegundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentarSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentarSegundos.ForeColor = System.Drawing.Color.Yellow;
            this.btnAumentarSegundos.Location = new System.Drawing.Point(12, 7);
            this.btnAumentarSegundos.Name = "btnAumentarSegundos";
            this.btnAumentarSegundos.Size = new System.Drawing.Size(49, 37);
            this.btnAumentarSegundos.TabIndex = 15;
            this.btnAumentarSegundos.Text = "+";
            this.btnAumentarSegundos.UseVisualStyleBackColor = true;
            this.btnAumentarSegundos.Click += new System.EventHandler(this.BtnAumentarSegundos_Click);
            // 
            // lblSegundos
            // 
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.White;
            this.lblSegundos.Location = new System.Drawing.Point(3, 38);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(240, 153);
            this.lblSegundos.TabIndex = 0;
            this.lblSegundos.Text = "00";
            this.lblSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "SEGUNDOS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblHoras);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(72, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 244);
            this.panel4.TabIndex = 11;
            // 
            // pnlTempoHoras
            // 
            this.pnlTempoHoras.Controls.Add(this.btnDiminuirHoras);
            this.pnlTempoHoras.Controls.Add(this.btnAumentarHoras);
            this.pnlTempoHoras.Location = new System.Drawing.Point(118, 61);
            this.pnlTempoHoras.Name = "pnlTempoHoras";
            this.pnlTempoHoras.Size = new System.Drawing.Size(140, 51);
            this.pnlTempoHoras.TabIndex = 14;
            this.pnlTempoHoras.Visible = false;
            // 
            // btnDiminuirHoras
            // 
            this.btnDiminuirHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuirHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuirHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirHoras.ForeColor = System.Drawing.Color.Yellow;
            this.btnDiminuirHoras.Location = new System.Drawing.Point(80, 7);
            this.btnDiminuirHoras.Name = "btnDiminuirHoras";
            this.btnDiminuirHoras.Size = new System.Drawing.Size(49, 37);
            this.btnDiminuirHoras.TabIndex = 16;
            this.btnDiminuirHoras.Text = "-";
            this.btnDiminuirHoras.UseVisualStyleBackColor = true;
            this.btnDiminuirHoras.Visible = false;
            this.btnDiminuirHoras.Click += new System.EventHandler(this.BtnDiminuirHoras_Click);
            // 
            // btnAumentarHoras
            // 
            this.btnAumentarHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentarHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentarHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentarHoras.ForeColor = System.Drawing.Color.Yellow;
            this.btnAumentarHoras.Location = new System.Drawing.Point(12, 7);
            this.btnAumentarHoras.Name = "btnAumentarHoras";
            this.btnAumentarHoras.Size = new System.Drawing.Size(49, 37);
            this.btnAumentarHoras.TabIndex = 15;
            this.btnAumentarHoras.Text = "+";
            this.btnAumentarHoras.UseVisualStyleBackColor = true;
            this.btnAumentarHoras.Click += new System.EventHandler(this.BtnAumentarHoras_Click);
            // 
            // tmrCronometro
            // 
            this.tmrCronometro.Interval = 1;
            this.tmrCronometro.Tick += new System.EventHandler(this.TmrCronometro_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.ptbCronometro);
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel7.Location = new System.Drawing.Point(-1, 209);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 377);
            this.panel7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "DEFINIR TEMPO";
            // 
            // ptbCronometro
            // 
            this.ptbCronometro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCronometro.Image = ((System.Drawing.Image)(resources.GetObject("ptbCronometro.Image")));
            this.ptbCronometro.Location = new System.Drawing.Point(95, 40);
            this.ptbCronometro.Name = "ptbCronometro";
            this.ptbCronometro.Size = new System.Drawing.Size(46, 32);
            this.ptbCronometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCronometro.TabIndex = 0;
            this.ptbCronometro.TabStop = false;
            this.ptbCronometro.Click += new System.EventHandler(this.PtbCronometro_Click);
            // 
            // lblMilliseconds
            // 
            this.lblMilliseconds.AutoSize = true;
            this.lblMilliseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilliseconds.ForeColor = System.Drawing.Color.White;
            this.lblMilliseconds.Location = new System.Drawing.Point(144, 182);
            this.lblMilliseconds.Name = "lblMilliseconds";
            this.lblMilliseconds.Size = new System.Drawing.Size(46, 31);
            this.lblMilliseconds.TabIndex = 18;
            this.lblMilliseconds.Text = "00";
            this.lblMilliseconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1249, 587);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlTempoMinutos.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlTempoSegundos.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlTempoHoras.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCronometro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpHistorico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer tmrCronometro;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbLimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptbCronometro;
        private System.Windows.Forms.Panel pnlTempoMinutos;
        private System.Windows.Forms.Button btnDiminuirMinutos;
        private System.Windows.Forms.Button btnAumentarMinutos;
        private System.Windows.Forms.Panel pnlTempoSegundos;
        private System.Windows.Forms.Button btnDiminuirSegundos;
        private System.Windows.Forms.Button btnAumentarSegundos;
        private System.Windows.Forms.Panel pnlTempoHoras;
        private System.Windows.Forms.Button btnDiminuirHoras;
        private System.Windows.Forms.Button btnAumentarHoras;
        private System.Windows.Forms.Label lblMilliseconds;
    }
}

