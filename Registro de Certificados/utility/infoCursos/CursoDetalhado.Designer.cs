namespace Registro_de_Certificados.utility.infoCursos
{
    partial class CursoDetalhado
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.check_valido = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_cargaHoraria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_nomeCurso = new System.Windows.Forms.Label();
            this.lb_peso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_pontos = new System.Windows.Forms.Label();
            this.lb_Fim = new System.Windows.Forms.Label();
            this.lb_Inicio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_valido
            // 
            this.check_valido.AutoSize = true;
            this.check_valido.Location = new System.Drawing.Point(38, 40);
            this.check_valido.Name = "check_valido";
            this.check_valido.Size = new System.Drawing.Size(15, 14);
            this.check_valido.TabIndex = 0;
            this.check_valido.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Fim);
            this.panel1.Controls.Add(this.lb_Inicio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lb_pontos);
            this.panel1.Controls.Add(this.lb_peso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_cargaHoraria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_nomeCurso);
            this.panel1.Controls.Add(this.check_valido);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 94);
            this.panel1.TabIndex = 1;
            // 
            // lb_cargaHoraria
            // 
            this.lb_cargaHoraria.AutoSize = true;
            this.lb_cargaHoraria.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cargaHoraria.Location = new System.Drawing.Point(235, 53);
            this.lb_cargaHoraria.Name = "lb_cargaHoraria";
            this.lb_cargaHoraria.Size = new System.Drawing.Size(18, 19);
            this.lb_cargaHoraria.TabIndex = 11;
            this.lb_cargaHoraria.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Carga horária:";
            // 
            // lb_nomeCurso
            // 
            this.lb_nomeCurso.AutoSize = true;
            this.lb_nomeCurso.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeCurso.Location = new System.Drawing.Point(118, 19);
            this.lb_nomeCurso.Name = "lb_nomeCurso";
            this.lb_nomeCurso.Size = new System.Drawing.Size(125, 19);
            this.lb_nomeCurso.TabIndex = 9;
            this.lb_nomeCurso.Text = "Nome completo";
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.Location = new System.Drawing.Point(534, 51);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(18, 19);
            this.lb_peso.TabIndex = 14;
            this.lb_peso.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pontos";
            // 
            // lb_pontos
            // 
            this.lb_pontos.AutoSize = true;
            this.lb_pontos.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pontos.Location = new System.Drawing.Point(534, 19);
            this.lb_pontos.Name = "lb_pontos";
            this.lb_pontos.Size = new System.Drawing.Size(18, 19);
            this.lb_pontos.TabIndex = 15;
            this.lb_pontos.Text = "0";
            // 
            // lb_Fim
            // 
            this.lb_Fim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_Fim.AutoSize = true;
            this.lb_Fim.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fim.Location = new System.Drawing.Point(921, 51);
            this.lb_Fim.Name = "lb_Fim";
            this.lb_Fim.Size = new System.Drawing.Size(91, 19);
            this.lb_Fim.TabIndex = 19;
            this.lb_Fim.Text = "00/00/0000";
            // 
            // lb_Inicio
            // 
            this.lb_Inicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_Inicio.AutoSize = true;
            this.lb_Inicio.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inicio.Location = new System.Drawing.Point(921, 19);
            this.lb_Inicio.Name = "lb_Inicio";
            this.lb_Inicio.Size = new System.Drawing.Size(91, 19);
            this.lb_Inicio.TabIndex = 18;
            this.lb_Inicio.Text = "00/00/0000";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(809, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data termino:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(828, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data inicio:";
            // 
            // CursoDetalhado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CursoDetalhado";
            this.Size = new System.Drawing.Size(1040, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox check_valido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_pontos;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_cargaHoraria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_nomeCurso;
        private System.Windows.Forms.Label lb_Fim;
        private System.Windows.Forms.Label lb_Inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
