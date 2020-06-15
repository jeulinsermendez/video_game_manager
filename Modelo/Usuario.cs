using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
     public class Usuario
    {
        private String nom;
        private String contra;



        public Usuario()
        {

        }
        public Usuario(string nom, string contra)
        {
            this.Nom = nom;
            this.Contra = contra;
        }

        public string Nom {
            get => nom;
            set => nom = value;
        }
        public string Contra {
            get => contra;
            set => contra = value;
        }
    }
}
