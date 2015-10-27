namespace ProyectoFinal
{
    partial class RegistrosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UsuarioIdTextBox = new System.Windows.Forms.TextBox();
            this.FechamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(116, 61);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(198, 20);
            this.NombreTextBox.TabIndex = 5;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(116, 95);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(198, 20);
            this.UsuarioTextBox.TabIndex = 6;
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Location = new System.Drawing.Point(116, 129);
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(198, 20);
            this.ContrasenaTextBox.TabIndex = 7;
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(116, 160);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(198, 20);
            this.AreaTextBox.TabIndex = 8;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources._1445976510_Delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(248, 239);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(81, 45);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Usuario ID";
            // 
            // UsuarioIdTextBox
            // 
            this.UsuarioIdTextBox.Location = new System.Drawing.Point(116, 33);
            this.UsuarioIdTextBox.Name = "UsuarioIdTextBox";
            this.UsuarioIdTextBox.Size = new System.Drawing.Size(198, 20);
            this.UsuarioIdTextBox.TabIndex = 14;
            // 
            // FechamaskedTextBox
            // 
            this.FechamaskedTextBox.Location = new System.Drawing.Point(116, 192);
            this.FechamaskedTextBox.Mask = "00/00/0000";
            this.FechamaskedTextBox.Name = "FechamaskedTextBox";
            this.FechamaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.FechamaskedTextBox.TabIndex = 15;
            this.FechamaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources._1445977752_Save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(146, 239);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(81, 45);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ProyectoFinal.Properties.Resources._1445976554_Plus__Orange;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(45, 239);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(81, 45);
            this.NuevoButton.TabIndex = 10;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // RegistrosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 307);
            this.Controls.Add(this.FechamaskedTextBox);
            this.Controls.Add(this.UsuarioIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UsuarioIdTextBox;
        private System.Windows.Forms.MaskedTextBox FechamaskedTextBox;
    }
}