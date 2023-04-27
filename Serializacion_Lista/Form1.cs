using System.Text.Json;
using System.Text.Json.Serialization;
using static Serializacion_Lista.RegistroPersona;

namespace Serializacion_Lista
{
    public partial class Form1 : Form
    {

        List<Persona> listaPersona = new List<Persona>();

        string nombre = "";
        int valorEdad = 0;
        string correo = "";
        string filename = "Persona.txt";
        string jsonString = string.Empty;



        public Form1()
        {
            InitializeComponent();
            dgvDatos.CellDoubleClick += new DataGridViewCellEventHandler(dgvDatos_CellDoubleClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre válido.");
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 0)
            {
                MessageBox.Show("Debe ingresar una edad válida.");
                return;
            }

            if (!IsValidEmail(txtCorreo.Text))
            {
                MessageBox.Show("Debe ingresar un correo electrónico válido.");
                return;
            }

            Registro();
            Persona per = new Persona();
            per.Nombre = nombre;
            per.Edad = valorEdad;
            per.CorreoElectronico = correo;
            listaPersona.Add(per);
            MessageBox.Show("Datos Registrados...");
            txtNombre.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            btnSerializar.Enabled = true;
            btnDeserializar.Enabled = true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }


        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            //Codigo erroneo
            /*jsonString = JsonSerializer.Serialize(listaPersona);
            File.WriteAllText(filename, jsonString);

            //Muestro datos en dgv
            dgvDatos.DataSource = listaPersona;*/



            // Leer datos existentes del archivo (si los hay)

            if (File.Exists(filename))
            {
                jsonString = File.ReadAllText(filename);
                listaPersona = JsonSerializer.Deserialize<List<Persona>>(jsonString);
            }

            // Agregar nueva persona a la lista
            Persona per = new Persona();
            per.Nombre = nombre;
            per.Edad = valorEdad;
            per.CorreoElectronico = correo;
            listaPersona.Add(per);

            // Serializar todos los datos y escribirlos en el archivo
            jsonString = JsonSerializer.Serialize(listaPersona);
            File.WriteAllText(filename, jsonString);

            // Mostrar los datos en el DataGridView
            dgvDatos.DataSource = listaPersona;
            MessageBox.Show("Datos Registrados...");
            txtNombre.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();


        }



        public void Registro()
        {
            nombre = txtNombre.Text;
            valorEdad = int.Parse(txtEdad.Text);
            correo = txtCorreo.Text;
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                try
                {
                    jsonString = File.ReadAllText(filename);
                    listaPersona = JsonSerializer.Deserialize<List<Persona>>(jsonString);
                    dgvDatos.DataSource = listaPersona;
                    MessageBox.Show("Datos deserializados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al deserializar los datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Borrar los datos de la lista
            listaPersona.Clear();

            // Borrar los datos del archivo
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            // Limpiar el DataGridView
            dgvDatos.DataSource = null;
            dgvDatos.Rows.Clear();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            // Obtener el índice de la fila seleccionada
            int index = e.RowIndex;

            // Borrar la fila seleccionada del DataGridView
            if (index >= 0)
            {
                dgvDatos.Rows.RemoveAt(index);
            }
        }
    }
}