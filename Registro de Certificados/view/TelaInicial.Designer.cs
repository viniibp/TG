namespace Registro_de_Certificados.view
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_tempoRegistrado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cargaHorariaTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_qtdCursos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_dateTime = new System.Windows.Forms.Label();
            this.lb_sec = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Fundo = new System.Windows.Forms.Panel();
            this.baseCursos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_logoff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Fundo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_registro);
            this.panel1.Controls.Add(this.lbl_cargo);
            this.panel1.Controls.Add(this.lbl_nome);
            this.panel1.Location = new System.Drawing.Point(254, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 84);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Experiencia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Perfil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_registro
            // 
            this.lbl_registro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(738, 61);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(63, 15);
            this.lbl_registro.TabIndex = 2;
            this.lbl_registro.Text = "Registro";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(8, 43);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(41, 15);
            this.lbl_cargo.TabIndex = 1;
            this.lbl_cargo.Text = "Cargo";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(8, 14);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(127, 18);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome completo";
            // 
            // lbl_tempoRegistrado
            // 
            this.lbl_tempoRegistrado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tempoRegistrado.AutoSize = true;
            this.lbl_tempoRegistrado.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempoRegistrado.Location = new System.Drawing.Point(161, 15);
            this.lbl_tempoRegistrado.Name = "lbl_tempoRegistrado";
            this.lbl_tempoRegistrado.Size = new System.Drawing.Size(42, 15);
            this.lbl_tempoRegistrado.TabIndex = 8;
            this.lbl_tempoRegistrado.Text = "Valor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempo registrado:";
            // 
            // lbl_cargaHorariaTotal
            // 
            this.lbl_cargaHorariaTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cargaHorariaTotal.AutoSize = true;
            this.lbl_cargaHorariaTotal.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargaHorariaTotal.Location = new System.Drawing.Point(175, 18);
            this.lbl_cargaHorariaTotal.Name = "lbl_cargaHorariaTotal";
            this.lbl_cargaHorariaTotal.Size = new System.Drawing.Size(42, 15);
            this.lbl_cargaHorariaTotal.TabIndex = 6;
            this.lbl_cargaHorariaTotal.Text = "Valor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carga Horaria Total:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cursos:";
            // 
            // lbl_qtdCursos
            // 
            this.lbl_qtdCursos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_qtdCursos.AutoSize = true;
            this.lbl_qtdCursos.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdCursos.Location = new System.Drawing.Point(146, 16);
            this.lbl_qtdCursos.Name = "lbl_qtdCursos";
            this.lbl_qtdCursos.Size = new System.Drawing.Size(42, 15);
            this.lbl_qtdCursos.TabIndex = 3;
            this.lbl_qtdCursos.Text = "Valor";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.pb_foto);
            this.panel3.Location = new System.Drawing.Point(1, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 165);
            this.panel3.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(46, 144);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(151, 13);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 10;
            // 
            // pb_foto
            // 
            this.pb_foto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_foto.ErrorImage")));
            this.pb_foto.Image = global::Registro_de_Certificados.Properties.Resources.user_placeholder;
            this.pb_foto.ImageLocation = "";
            this.pb_foto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_foto.InitialImage")));
            this.pb_foto.Location = new System.Drawing.Point(46, 8);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(151, 128);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 3;
            this.pb_foto.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_qtdCursos, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 227);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(243, 48);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.19341F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.80659F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_cargaHorariaTotal, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 281);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 52);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lb_dateTime);
            this.panel2.Controls.Add(this.lb_sec);
            this.panel2.Controls.Add(this.circularProgressBar1);
            this.panel2.Location = new System.Drawing.Point(3, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 133);
            this.panel2.TabIndex = 5;
            // 
            // lb_dateTime
            // 
            this.lb_dateTime.AutoSize = true;
            this.lb_dateTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dateTime.Location = new System.Drawing.Point(99, 60);
            this.lb_dateTime.Name = "lb_dateTime";
            this.lb_dateTime.Size = new System.Drawing.Size(51, 19);
            this.lb_dateTime.TabIndex = 2;
            this.lb_dateTime.Text = "00:00";
            // 
            // lb_sec
            // 
            this.lb_sec.AutoSize = true;
            this.lb_sec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sec.Location = new System.Drawing.Point(117, 34);
            this.lb_sec.Name = "lb_sec";
            this.lb_sec.Size = new System.Drawing.Size(13, 14);
            this.lb_sec.TabIndex = 1;
            this.lb_sec.Text = "0";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(60, 10);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 59;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -14;
            this.circularProgressBar1.OuterWidth = 14;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 14;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(126, 113);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 1;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 59;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar2.Enabled = false;
            this.monthCalendar2.Location = new System.Drawing.Point(9, 464);
            this.monthCalendar2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowTodayCircle = false;
            this.monthCalendar2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.02058F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.97942F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_tempoRegistrado, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 629);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(243, 45);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // Fundo
            // 
            this.Fundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fundo.AutoScroll = true;
            this.Fundo.Controls.Add(this.baseCursos);
            this.Fundo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Fundo.Location = new System.Drawing.Point(254, 93);
            this.Fundo.Name = "Fundo";
            this.Fundo.Size = new System.Drawing.Size(809, 547);
            this.Fundo.TabIndex = 5;
            // 
            // baseCursos
            // 
            this.baseCursos.AutoSize = true;
            this.baseCursos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baseCursos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.baseCursos.Location = new System.Drawing.Point(3, 3);
            this.baseCursos.Name = "baseCursos";
            this.baseCursos.Size = new System.Drawing.Size(0, 0);
            this.baseCursos.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button_logoff);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.monthCalendar2);
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(1, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 677);
            this.panel4.TabIndex = 6;
            // 
            // button_logoff
            // 
            this.button_logoff.Location = new System.Drawing.Point(143, 192);
            this.button_logoff.Name = "button_logoff";
            this.button_logoff.Size = new System.Drawing.Size(75, 23);
            this.button_logoff.TabIndex = 8;
            this.button_logoff.Text = "Disconnect";
            this.button_logoff.UseVisualStyleBackColor = true;
            this.button_logoff.Click += new System.EventHandler(this.button_logoff_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(919, 647);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adicionar Curso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TelaInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Fundo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Disposer);
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Fundo.ResumeLayout(false);
            this.Fundo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label lbl_cargaHorariaTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_qtdCursos;
        private System.Windows.Forms.Label lbl_tempoRegistrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Fundo;
        private System.Windows.Forms.FlowLayoutPanel baseCursos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_logoff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label lb_dateTime;
        private System.Windows.Forms.Label lb_sec;
        private System.Windows.Forms.Button button3;
    }
}