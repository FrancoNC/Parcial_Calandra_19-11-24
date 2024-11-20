namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxGrupo = new GroupBox();
            label1 = new Label();
            textBoxRoles = new TextBox();
            labelRoles = new Label();
            dataGridViewGrupos = new DataGridView();
            buttonCargarGrupo = new Button();
            label3 = new Label();
            textBoxNombreGrupo = new TextBox();
            labelNombre = new Label();
            labelUsuario = new Label();
            textBox1 = new TextBox();
            labelCargaUsuarios = new Label();
            textBox2 = new TextBox();
            labelEmail = new Label();
            textBoxApellido = new TextBox();
            labelApellido = new Label();
            textBoxClave = new TextBox();
            labelClave = new Label();
            label4 = new Label();
            textBoxNombrePersona = new TextBox();
            labelNombrePersona = new Label();
            checkBoxHabilitado = new CheckBox();
            textBoxClaveRepetir = new TextBox();
            labelClaveRepetir = new Label();
            buttonCargar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            groupBoxGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).BeginInit();
            SuspendLayout();
            // 
            // groupBoxGrupo
            // 
            groupBoxGrupo.Controls.Add(label1);
            groupBoxGrupo.Controls.Add(textBoxRoles);
            groupBoxGrupo.Controls.Add(labelRoles);
            groupBoxGrupo.Controls.Add(dataGridViewGrupos);
            groupBoxGrupo.Controls.Add(buttonCargarGrupo);
            groupBoxGrupo.Controls.Add(label3);
            groupBoxGrupo.Controls.Add(textBoxNombreGrupo);
            groupBoxGrupo.Controls.Add(labelNombre);
            groupBoxGrupo.Location = new Point(831, 257);
            groupBoxGrupo.Name = "groupBoxGrupo";
            groupBoxGrupo.Size = new Size(374, 380);
            groupBoxGrupo.TabIndex = 0;
            groupBoxGrupo.TabStop = false;
            groupBoxGrupo.Text = "Grupos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 93);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 21;
            // 
            // textBoxRoles
            // 
            textBoxRoles.Location = new Point(149, 69);
            textBoxRoles.Name = "textBoxRoles";
            textBoxRoles.Size = new Size(125, 27);
            textBoxRoles.TabIndex = 20;
            // 
            // labelRoles
            // 
            labelRoles.AutoSize = true;
            labelRoles.Location = new Point(149, 36);
            labelRoles.Name = "labelRoles";
            labelRoles.Size = new Size(45, 20);
            labelRoles.TabIndex = 19;
            labelRoles.Text = "Roles";
            // 
            // dataGridViewGrupos
            // 
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Location = new Point(21, 184);
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.RowHeadersWidth = 51;
            dataGridViewGrupos.Size = new Size(347, 188);
            dataGridViewGrupos.TabIndex = 18;
            // 
            // buttonCargarGrupo
            // 
            buttonCargarGrupo.Location = new Point(6, 114);
            buttonCargarGrupo.Name = "buttonCargarGrupo";
            buttonCargarGrupo.Size = new Size(94, 29);
            buttonCargarGrupo.TabIndex = 17;
            buttonCargarGrupo.Text = "Cargar";
            buttonCargarGrupo.UseVisualStyleBackColor = true;
            buttonCargarGrupo.Click += buttonCargarGrupo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 93);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 16;
            // 
            // textBoxNombreGrupo
            // 
            textBoxNombreGrupo.Location = new Point(6, 69);
            textBoxNombreGrupo.Name = "textBoxNombreGrupo";
            textBoxNombreGrupo.Size = new Size(125, 27);
            textBoxNombreGrupo.TabIndex = 15;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(6, 36);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(109, 20);
            labelNombre.TabIndex = 14;
            labelNombre.Text = "Nombre Grupo";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(12, 77);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 20);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // labelCargaUsuarios
            // 
            labelCargaUsuarios.AutoSize = true;
            labelCargaUsuarios.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCargaUsuarios.Location = new Point(12, 9);
            labelCargaUsuarios.Name = "labelCargaUsuarios";
            labelCargaUsuarios.Size = new Size(200, 31);
            labelCargaUsuarios.TabIndex = 3;
            labelCargaUsuarios.Text = "Carga de Usuarios";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(152, 77);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(173, 207);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(125, 27);
            textBoxApellido.TabIndex = 7;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(173, 171);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(66, 20);
            labelApellido.TabIndex = 6;
            labelApellido.Text = "Apellido";
            // 
            // textBoxClave
            // 
            textBoxClave.Location = new Point(6, 287);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.Size = new Size(125, 27);
            textBoxClave.TabIndex = 9;
            // 
            // labelClave
            // 
            labelClave.AutoSize = true;
            labelClave.Location = new Point(6, 264);
            labelClave.Name = "labelClave";
            labelClave.Size = new Size(45, 20);
            labelClave.TabIndex = 8;
            labelClave.Text = "Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 328);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 10;
            label4.Text = "Estado";
            // 
            // textBoxNombrePersona
            // 
            textBoxNombrePersona.Location = new Point(6, 207);
            textBoxNombrePersona.Name = "textBoxNombrePersona";
            textBoxNombrePersona.Size = new Size(125, 27);
            textBoxNombrePersona.TabIndex = 13;
            // 
            // labelNombrePersona
            // 
            labelNombrePersona.AutoSize = true;
            labelNombrePersona.Location = new Point(6, 171);
            labelNombrePersona.Name = "labelNombrePersona";
            labelNombrePersona.Size = new Size(64, 20);
            labelNombrePersona.TabIndex = 12;
            labelNombrePersona.Text = "Nombre";
            // 
            // checkBoxHabilitado
            // 
            checkBoxHabilitado.AutoSize = true;
            checkBoxHabilitado.Location = new Point(185, 354);
            checkBoxHabilitado.Name = "checkBoxHabilitado";
            checkBoxHabilitado.Size = new Size(102, 24);
            checkBoxHabilitado.TabIndex = 14;
            checkBoxHabilitado.Text = "Habilitado";
            checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // textBoxClaveRepetir
            // 
            textBoxClaveRepetir.Location = new Point(6, 357);
            textBoxClaveRepetir.Name = "textBoxClaveRepetir";
            textBoxClaveRepetir.Size = new Size(125, 27);
            textBoxClaveRepetir.TabIndex = 16;
            // 
            // labelClaveRepetir
            // 
            labelClaveRepetir.AutoSize = true;
            labelClaveRepetir.Location = new Point(6, 328);
            labelClaveRepetir.Name = "labelClaveRepetir";
            labelClaveRepetir.Size = new Size(108, 20);
            labelClaveRepetir.TabIndex = 15;
            labelClaveRepetir.Text = "Repita la Clave";
            // 
            // buttonCargar
            // 
            buttonCargar.Location = new Point(75, 408);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(212, 52);
            buttonCargar.TabIndex = 17;
            buttonCargar.Text = "Cargar";
            buttonCargar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(75, 481);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(212, 52);
            buttonModificar.TabIndex = 18;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(75, 553);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(212, 52);
            buttonEliminar.TabIndex = 19;
            buttonEliminar.Text = "buttonEliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 649);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonCargar);
            Controls.Add(textBoxClaveRepetir);
            Controls.Add(labelClaveRepetir);
            Controls.Add(checkBoxHabilitado);
            Controls.Add(textBoxNombrePersona);
            Controls.Add(labelNombrePersona);
            Controls.Add(label4);
            Controls.Add(textBoxClave);
            Controls.Add(labelClave);
            Controls.Add(textBoxApellido);
            Controls.Add(labelApellido);
            Controls.Add(textBox2);
            Controls.Add(labelEmail);
            Controls.Add(labelCargaUsuarios);
            Controls.Add(textBox1);
            Controls.Add(labelUsuario);
            Controls.Add(groupBoxGrupo);
            Name = "Form1";
            Text = "Form1";
            groupBoxGrupo.ResumeLayout(false);
            groupBoxGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxGrupo;
        private Label labelUsuario;
        private TextBox textBox1;
        private Label labelCargaUsuarios;
        private TextBox textBox2;
        private Label labelEmail;
        private TextBox textBoxApellido;
        private Label labelApellido;
        private TextBox textBoxClave;
        private Label labelClave;
        private Label label4;
        private TextBox textBoxNombrePersona;
        private Label labelNombrePersona;
        private Label label3;
        private TextBox textBoxNombreGrupo;
        private Label labelNombre;
        private DataGridView dataGridViewGrupos;
        private Button buttonCargarGrupo;
        private Label label1;
        private TextBox textBoxRoles;
        private Label labelRoles;
        private CheckBox checkBoxHabilitado;
        private TextBox textBoxClaveRepetir;
        private Label labelClaveRepetir;
        private Button buttonCargar;
        private Button buttonModificar;
        private Button buttonEliminar;
    }
}
