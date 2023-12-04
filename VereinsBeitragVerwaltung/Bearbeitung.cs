using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VereinsBeitragVerwaltung
{
    public partial class Bearbeitung : Form
    {
        Mitglied mitgliedInBearbeitung = null;
        public Mitglied mitglied { get; set; }
        public Bearbeitung(Mitglied mitglied)
        {
            //Mitglied = mitglied;
            InitializeComponent();
            if(mitglied != null )
            {

            }
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)    // Speichern
        {
            string name = textBoxName.Text;
            if( name.Length == 0)
            {
                textBoxName.Focus();
                return;
            }
            decimal age = (int) numericUpDownAge.Value;
            if (age == 0)
            {
                numericUpDownAge.Focus();
                return;
            }
            double beitrag = (double) numericUpDownBeitrag.Value;
            if (beitrag == 0.0)
            {
                numericUpDownBeitrag.Focus();
                return;
            }
            if (mitgliedInBearbeitung == null)
            {
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                command.CommandText = "INSERT INTO `mitglied` (`id`, `name`, `age`, `beitrag`) VALUES (NULL, @name, @age, @beitrag)";
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("age", age);
                command.Parameters.AddWithValue("beitrag", beitrag);
                command.ExecuteNonQuery();
                int id = (int)command.LastInsertedId;
                Datenbank.Close();

                // TODO ordentlich in die DB speichern und dabei die ID bekommen
                Mitglied m = new Mitglied(id, name, (int)age, beitrag);
                //mitglied.Add(m);
                //mitglied.Items.Add(m.ToString());
            }
            else
            {
                // Update
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                command.CommandText = "UPDATE `mitglied` SET `name` = '@name', `age` = '@age', `beitrag` = '@beitrag' WHERE `mitglied`.`id` = 5 ";
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("age", age);
                command.Parameters.AddWithValue("beitrag", beitrag);
                command.Parameters.AddWithValue("id", mitgliedInBearbeitung.Id);
                command.Prepare();
                command.ExecuteNonQuery();
                Datenbank.Close();

                mitglied.Name = name;
                mitglied.Age = (int)age;
                mitglied.Beitrag = beitrag;

                //.Items[indexInBearbeitung] = flussInBearbeitung.ToString();
            }

            textBoxName.Text = "";
            numericUpDownAge.Value = 0;
            numericUpDownBeitrag.Value = 0;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
