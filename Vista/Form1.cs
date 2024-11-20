using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Modelo;
using Controladora;

namespace Vista
{
    public partial class Form1 : Form
    {
        private static UsuariosContext contexto = new UsuariosContext();
        private GestionarGrupos gestionarGrupos = new GestionarGrupos(contexto);
        private GestionarUsuarios gestionarUsuarios = new GestionarUsuarios(contexto);
        private Usuario usuario;
        private Grupo grupo;

        public Form1()
        {
            InitializeComponent();
            CargarDataGrids();
        }
        //METODOS COMPARTIDOS:
        private bool ValidarTextBox(int selector)
        {
            switch (selector)
            {// 0 es carga de grupo, 1 es carga de usuario
                case 0:
                    if (textBoxNombreGrupo != null && textBoxNombreGrupo.Text != "" && textBoxRoles != null && textBoxRoles.Text != "") return true;
                    break;
                case 1:
                    return true;
                default: return false;
            }
            return false;
        }

        private void CargarDataGrids()
        {
            dataGridViewGrupos.DataSource = gestionarGrupos.ListarGrupos();
        }

        private void buttonCargarGrupo_Click(object sender, EventArgs e)
        {
            if (ValidarTextBox(0))
            {
                grupo = new Grupo();
                grupo.NombreGrupo = textBoxNombreGrupo.Text;
                grupo.Roles = textBoxRoles.Text;
                gestionarGrupos.AgregarUsuario(grupo);
                CargarDataGrids();
            }
        }
    }
}
