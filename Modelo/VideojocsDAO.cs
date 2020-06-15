using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Modelo
{
   public class VideojocsDAO
    {
        List<Videojocs> videojocsArray = new List<Videojocs>();
        int contaCampo;

        public VideojocsDAO()
        {
            loadVideojocs();
        }


        private void loadVideojocs()
        {
            contaCampo = 0;

            try
            {
                using (StreamReader fichero = new StreamReader("Videojocs.txt"))
                {
                    string linea;
                    string[] videojoc;
                    Videojocs v = null;

                    while ((linea = fichero.ReadLine()) != null)
                    {
                        videojoc = linea.Split(';');
                        v = new Videojocs();
                        v.Id = videojoc[0];
                        v.Nom = videojoc[1];
                        v.Descripcio = videojoc[2];
                        v.Plataforma = videojoc[3];
                        v.Genero = videojoc[4];
                        v.Preu = Double.Parse(videojoc[5]);
                        v.FranjaEdat = videojoc[6];
                        videojocsArray.Add(v);
                        contaCampo++;

                    }
                }
            }
            catch (FileNotFoundException error)
            {

                Console.WriteLine("Eoeoeoeoeeo"+error.Message);
                videojocsArray = null;
            }

            
        }

        public List<Videojocs> cargarVideojoc()
        {


            return videojocsArray;

        }

    }
   


}
