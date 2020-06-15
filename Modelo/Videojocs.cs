using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Videojocs
    {
        string id;
        string nom;
        string descripcio;
        string plataforma;
        string genero;
        double preu;
        string franjaEdat;

        public Videojocs()
        {
        }

        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Descripcio { get => descripcio; set => descripcio = value; }
        public string Plataforma { get => plataforma; set => plataforma = value; }
        public string Genero { get => genero; set => genero = value; }
        public double Preu { get => preu; set => preu = value; }
        public string FranjaEdat { get => franjaEdat; set => franjaEdat = value; }

      

     
    }
}
