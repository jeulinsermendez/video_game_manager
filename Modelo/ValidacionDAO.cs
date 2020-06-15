using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Modelo
{
    public class ValidacionDAO
    {
        List<Usuario> usuariosArray = new List<Usuario>();
        public ValidacionDAO()
        {
            loadUsuarios();

        }

        private void loadUsuarios()
        {
           

            try
            {
                using (StreamReader fichero = new StreamReader("Usuarios.txt"))
                {
                    string linea;
                    string[] usuario;
                    Usuario u = null;

                    while ((linea = fichero.ReadLine()) != null)
                    {
                        usuario = linea.Split(';');
                        u = new Usuario();
                        u.Nom = usuario[0];
                        u.Contra = usuario[1];
                  
                        usuariosArray.Add(u);
                       

                    }
                }
            }
            catch (FileNotFoundException error)
            {

                Console.WriteLine("Eoeoeoeoeeo" + error.Message);
                usuariosArray = null;
            }


        }
        public List<Usuario> cargarUsuarios()
        {
           



            return usuariosArray;
        }


    }
}
