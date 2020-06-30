namespace Registro_de_Certificados.utility
{
    partial class Telefone
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
            this.button_edit = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.lb_numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(243, 7);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(40, 31);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_remove
            // 
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(287, 7);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(34, 31);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "X";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.Location = new System.Drawing.Point(83, 7);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(86, 31);
            this.lb_numero.TabIndex = 3;
            this.lb_numero.Text = "label1";
            // 
            // Telefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_edit);
            this.Name = "Telefone";
            this.Size = new System.Drawing.Size(322, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Label lb_numero;
    }
}
