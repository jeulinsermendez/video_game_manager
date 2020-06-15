using System;

namespace Modelo
{
    public class Category
    {

        //atributs
        private int id;
        private string description;

        //constructors

            

        public Category(int id, string description)
        {
            this.id = id;
            this.description = description;
        }
        public Category()
        {
        }

        public int Id {
            get => id;
            set => id = value;
        }
        public string Description {
            get => description;
            set => description = value;
        }
        //metodes de mes per escriure,...

    }
}
