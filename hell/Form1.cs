using entregable1;

namespace hell
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button_play_Click(object sender, EventArgs e)
        {

           Character character = new Character(textBoxName.Text);  //crea el personaje

            Combatsystem combatsystem = new Combatsystem();        // crea el objeto sistema de combate

            Form2 form2 = new Form2(combatsystem, character);      //crea el form2, lo muestra y esconde el fom1

            // Show Form2
            form2.Show(); 

            // Hide Form1
            this.Hide();

            combatsystem.CombatMode(character, form2);  // inicia el combate


        }

    }

}
