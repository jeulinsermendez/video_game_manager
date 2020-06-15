using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoriesTrabajo
{

    public partial class Validacion : Form
    {
        String usuario;
        String contra;
        List<Modelo.Usuario> usuariosArray = new List<Modelo.Usuario>();
        Modelo.ValidacionDAO myValid = new Modelo.ValidacionDAO();
        Modelo.Usuario result;


        public Validacion()
        {
            InitializeComponent();
            usuariosArray = myValid.cargarUsuarios();

        }

        private void BtnValidacion_Click(object sender, EventArgs e)
        {
            result = null;
            usuario = tbUsuario.Text;
            contra = tbContra.Text;
           
            Form1 form = new Form1();
            Boolean user = false;
            Boolean cont = false;

            foreach (var u in usuariosArray)
            {
                if (!u.Nom.Equals(usuario))
                {

                    user = false;
                    
                    
                    
                }
                else
                {
                    user = true;
                    if (!u.Contra.Equals(contra))
                    {
                        cont = false;
                        
                        
                    }
                    else
                    {

                        
                        
                        cont = true;
                        form.Show();

                    }

                }


            }
                   


        }
    }
}
