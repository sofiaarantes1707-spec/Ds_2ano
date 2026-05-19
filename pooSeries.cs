using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace form_19_05
{

    //partial --> 
    //get --> 
    //set --> 

    public partial class Series_Medicas : Form
    {
        //criando as propriedades/atributos

        string name //new Nome();
        {
            get; //atribui/recebe
            set; //ler/define o valor
        }
        int Data
        {
            get;
            set;
        }
        string Descricao
        {
            get;
            set;
        }
        string[] Doctors
        {
            get;
            set;
        }

        //série: objeto
        //toda série vai ter um nome, data, medicos e descricao

        // métodos

        public void Doc()
        {
            string[] Doctor = new string[18] { "Meredith Grey", "Derek Shepherd", "Cristina Yang", "Alex Karev"," Izzie Stevens", "George OMalley", "Miranda Bailey", "Richard Webber", "Callie Torres", "Arizona Robbins"," Mark Sloan", "Lexie Grey", "Owen Hunt", "Amelia Shepherd", "Jackson Avery", "April Kepner", "Jo Wilson", "Maggie Pierce"};
        }

        public void GreysAnatomy()
        {
            this.name = "Greys anatomy";
            this.Data = 2005;
            this.Descricao = "aojsajsajsoajjda";
            // this.Doctors = 
            Doc();
            Console.WriteLine(this.Doctors[0]);
        }
        public void NewArmsterdam()
        {
            this.name = "New Armsterdam";
            //InitializeComponent();
        }


        public void DrHouse()
        {
            this.name = "Doctor House";
        }


        public void TheGoodDoctor ()
        {
            this.name = "The Good Doctor";
        }


        public void ER()
        {
            this.name = "ER";
            this.Descricao;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
