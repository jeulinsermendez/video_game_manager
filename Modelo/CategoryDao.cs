using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Modelo
{
    public class CategoryDao
    {

        
        
        

        public CategoryDao()
        {          
        }

        

        public List<Category> loadCategory()
        {
            List<Category> categories = new List<Category>();

            try {
                using (StreamReader fichero = new StreamReader("categorias.txt"))
                {
                    string linea;
                    string[] categorias;
                    Category cat = null;

                    while ((linea = fichero.ReadLine()) != null)
                    {
                        categorias = linea.Split(';');
                        cat = new Category();
                        cat.Id = Int32.Parse(categorias[0]);
                        cat.Description = categorias[1];

                        categories.Add(cat);

                    }
                }
            } catch (FileNotFoundException error)
            {

                Console.WriteLine(error.Message);
                categories = null;
            }

            return categories;
        }




        //metodes que treballen amb l'arxiu
        //un constructor
        //loadCategories() carregar l'arxiu a una List<Category>
        //------------------
        //saveCategories() escriure a l'arxiu
        //addCategories() per afegir a la List
        //modifyCategory() per modificar a la List
        //i tot el que se'm demani

    }
}
