
namespace Miceli.Escritorio
{
    partial class Alta
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textNombreApellido = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNotaPromedio = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNotaPromedio = new System.Windows.Forms.Label();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(24, 176);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(139, 176);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textNombreApellido
            // 
            this.textNombreApellido.Location = new System.Drawing.Point(114, 45);
            this.textNombreApellido.Name = "textNombreApellido";
            this.textNombreApellido.Size = new System.Drawing.Size(100, 20);
            this.textNombreApellido.TabIndex = 2;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(114, 97);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 4;
            // 
            // textNotaPromedio
            // 
            this.textNotaPromedio.Location = new System.Drawing.Point(114, 123);
            this.textNotaPromedio.Name = "textNotaPromedio";
            this.textNotaPromedio.Size = new System.Drawing.Size(100, 20);
            this.textNotaPromedio.TabIndex = 5;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(114, 19);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(100, 20);
            this.textDni.TabIndex = 6;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(21, 22);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 13);
            this.labelDni.TabIndex = 7;
            this.labelDni.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre Apellido";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(21, 74);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(91, 13);
            this.labelFechaNacimiento.TabIndex = 9;
            this.labelFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(21, 100);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            // 
            // labelNotaPromedio
            // 
            this.labelNotaPromedio.AutoSize = true;
            this.labelNotaPromedio.Location = new System.Drawing.Point(21, 126);
            this.labelNotaPromedio.Name = "labelNotaPromedio";
            this.labelNotaPromedio.Size = new System.Drawing.Size(77, 13);
            this.labelNotaPromedio.TabIndex = 11;
            this.labelNotaPromedio.Text = "Nota Promedio";
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(114, 71);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dateTimeFechaNacimiento.TabIndex = 12;
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 211);
            this.Controls.Add(this.dateTimeFechaNacimiento);
            this.Controls.Add(this.labelNotaPromedio);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textNotaPromedio);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNombreApellido);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "Alta";
            this.Text = "Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textNombreApellido;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNotaPromedio;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNotaPromedio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
    }
}