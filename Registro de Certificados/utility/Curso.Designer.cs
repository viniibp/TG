namespace Registro_de_Certificados.utility
{
    partial class Curso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_cargaHoraria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Fim = new System.Windows.Forms.Label();
            this.lb_Inicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nomeCurso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_cargaHoraria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_Fim);
            this.panel1.Controls.Add(this.lb_Inicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_nomeCurso);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 79);
            this.panel1.TabIndex = 6;
            // 
            // lb_cargaHoraria
            // 
            this.lb_cargaHoraria.AutoSize = true;
            this.lb_cargaHoraria.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cargaHoraria.Location = new System.Drawing.Point(134, 47);
            this.lb_cargaHoraria.Name = "lb_cargaHoraria";
            this.lb_cargaHoraria.Size = new System.Drawing.Size(18, 19);
            this.lb_cargaHoraria.TabIndex = 8;
            this.lb_cargaHoraria.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carga horária:";
            // 
            // lb_Fim
            // 
            this.lb_Fim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_Fim.AutoSize = true;
            this.lb_Fim.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fim.Location = new System.Drawing.Point(687, 47);
            this.lb_Fim.Name = "lb_Fim";
            this.lb_Fim.Size = new System.Drawing.Size(91, 19);
            this.lb_Fim.TabIndex = 5;
            this.lb_Fim.Text = "00/00/0000";
            // 
            // lb_Inicio
            // 
            this.lb_Inicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_Inicio.AutoSize = true;
            this.lb_Inicio.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inicio.Location = new System.Drawing.Point(687, 15);
            this.lb_Inicio.Name = "lb_Inicio";
            this.lb_Inicio.Size = new System.Drawing.Size(91, 19);
            this.lb_Inicio.TabIndex = 4;
            this.lb_Inicio.Text = "00/00/0000";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data termino:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data inicio:";
            // 
            // lb_nomeCurso
            // 
            this.lb_nomeCurso.AutoSize = true;
            this.lb_nomeCurso.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeCurso.Location = new System.Drawing.Point(17, 13);
            this.lb_nomeCurso.Name = "lb_nomeCurso";
            this.lb_nomeCurso.Size = new System.Drawing.Size(125, 19);
            this.lb_nomeCurso.TabIndex = 1;
            this.lb_nomeCurso.Text = "Nome completo";
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Curso";
            this.Size = new System.Drawing.Size(799, 82);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Fim;
        private System.Windows.Forms.Label lb_Inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_nomeCurso;
        private System.Windows.Forms.Label lb_cargaHoraria;
        private System.Windows.Forms.Label label3;
    }
}
