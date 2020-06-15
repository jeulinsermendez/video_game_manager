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
    public partial class LisView : Form
    {
        Modelo.VideojocsDAO myVideojocs;

        public LisView()
        {
           
            InitializeComponent();
            myVideojocs= new Modelo.VideojocsDAO();
            carregaListView();
            listBox1.SelectedIndex = 0;

        }

        private void carregaListView()
        {
            List<Modelo.Videojocs> videojocs = new List<Modelo.Videojocs>();
            videojocs = myVideojocs.cargarVideojoc();
            foreach (var v in videojocs)
            {
                
                string[] arr = new string[7];
                ListViewItem itm;
                arr[0] = v.Id;
                arr[1] = v.Nom;
                arr[2] = v.Descripcio;
                arr[3] = v.Plataforma;
                arr[4] = v.Genero;
                arr[5] = v.Preu.ToString()+" €";
                arr[6] = v.FranjaEdat;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            }
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            filtrando(listBox1.SelectedItem.ToString());
           


        }

        private void filtrando(string selectedItem)
        {
            List<Modelo.Videojocs> videojocs = new List<Modelo.Videojocs>();
            videojocs = myVideojocs.cargarVideojoc();
            listView1.Items.Clear();

            foreach (var v in videojocs)
            {
                if (listBox1.SelectedItem.Equals("Tots"))
                {
                    string[] arr = new string[7];
                    ListViewItem itm;

                    arr[0] = v.Id;
                    arr[1] = v.Nom;
                    arr[2] = v.Descripcio;
                    arr[3] = v.Plataforma;
                    arr[4] = v.Genero;
                    arr[5] = v.Preu.ToString() + " €";
                    arr[6] = v.FranjaEdat;
                    itm = new ListViewItem(arr);


                    listView1.Items.Add(itm);

                }
                else
                {
                    if (v.Genero.Equals(selectedItem))
                    {


                        string[] arr = new string[7];
                        ListViewItem itm;

                        arr[0] = v.Id;
                        arr[1] = v.Nom;
                        arr[2] = v.Descripcio;
                        arr[3] = v.Plataforma;
                        arr[4] = v.Genero;
                        arr[5] = v.Preu.ToString() + " €";
                        arr[6] = v.FranjaEdat;
                        itm = new ListViewItem(arr);


                        listView1.Items.Add(itm);

                    }

                }
                
                
                
               
                

            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
