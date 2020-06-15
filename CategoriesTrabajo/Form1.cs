using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoriesTrabajo
{
    public partial class Form1 : Form
    {
        List<Button> buttoons = new List<Button>();

       
        int numButtons;
        Modelo.CategoryDao catDao = new Modelo.CategoryDao();
        List<Modelo.Category> categorias;
        LisView myListView;
        public Form1()
        {

            InitializeComponent();
            categorias = catDao.loadCategory();
            PrintButtons();
        }

        private void PrintButtons()
        {
            int position = 0;
           
            foreach(Modelo.Category c in categorias){
                Button b = new Button();
                b.Location = new System.Drawing.Point(100, 30+ position);
                b.Name =  c.Id.ToString();
                b.Text = c.Description;
               
                b.Size = new System.Drawing.Size(75, 23);
               b.Click += new System.EventHandler(this.Button1_Click);
                Controls.Add(b);
                position = position + 50;
            }
            
        }

        private void loadData()
        {
            /**
             *  this.button1.Location = new System.Drawing.Point(188, 55);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(75, 23);
                this.button1.Text = "button1";*/

           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            myListView = new LisView();
            String nomBoton;
            
            Button b = (Button)sender;
            nomBoton = b.Text;
            if (nomBoton.Equals("Juegos")){

                myListView.Show();
            }
            else
            {
                MessageBox.Show("Este es el boton de " + b.Text);

            }
                
        }
    }
}
