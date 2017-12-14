using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTapi;
using CRUD;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Crud crud = new Crud(); 
            List<Country> lCountry = crud.ImportCountries();
            dataGridViewCountries.DataSource = lCountry;

            dataGridViewCountries.AutoGenerateColumns = false;
        }
    }
}
