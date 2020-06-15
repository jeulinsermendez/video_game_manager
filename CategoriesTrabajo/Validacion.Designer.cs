namespace CategoriesTrabajo
{
    partial class Validacion
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
            this.btnValidacion = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContra = new System.Windows.Forms.Label();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidacion
            // 
            this.btnValidacion.Location = new System.Drawing.Point(267, 133);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(75, 23);
            this.btnValidacion.TabIndex = 0;
            this.btnValidacion.Text = "Validar";
            this.btnValidacion.UseVisualStyleBackColor = true;
            this.btnValidacion.Click += new System.EventHandler(this.BtnValidacion_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(267, 81);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(215, 84);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Location = new System.Drawing.Point(197, 110);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(64, 13);
            this.lbContra.TabIndex = 4;
            this.lbContra.Text = "Contraseña:";
            // 
            // tbContra
            // 
            this.tbContra.Location = new System.Drawing.Point(267, 107);
            this.tbContra.Name = "tbContra";
            this.tbContra.Size = new System.Drawing.Size(100, 20);
            this.tbContra.TabIndex = 3;
            // 
            // Validacion
            // 
            this.AcceptButton = this.btnValidacion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btnValidacion);
            this.Name = "Validacion";
            this.Text = "Validacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidacion;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.TextBox tbContra;
    }
}