using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R_Base_de_Datos
{
    public partial class Form1 : Form
    {
        Empleados Empleado = new Empleados();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ingreso el nombre");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingreso el DUI");
                txtDUI.Focus();
                return;
            }

            errorProvider1.SetError(txtDUI, "");

            double Salario;

            if (!double.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "No ingreso el salario de forma correcta");
                txtSalario.Focus();
                return;
            }

            errorProvider1.SetError(txtSalario, "");


            Empleado.Nombre = txtNombre.Text;
            Empleado.Dui = txtDUI.Text;
            Empleado.Salario = Convert.ToDouble(txtSalario.Text);
            Empleado.Afp = Empleado.AFP(Empleado.Salario);
            txtAFP.Text = Empleado.Afp.ToString();
            Empleado.Isss = Empleado.ISSS(Empleado.Salario);
            txtISSS.Text = Empleado.Isss.ToString();
            Empleado.Neto = Empleado.NETO(Empleado.Salario);
            txtNeto.Text = Empleado.Neto.ToString();
            labelAregistro.Text = "Registro guardado en la clase";

            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();
            string cadena = "insert into [Empleados] (Nombre, DUI, Salario, AFP, ISSS, NETO) values ('" + Empleado.Nombre + "','" + Empleado.Dui + "','" + Empleado.Salario + "','" + Empleado.Afp + "','" + Empleado.Isss + "','" + Empleado.Neto + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");

            conexion.Close();


        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            Int32 cod;

            if (!Int32.TryParse(txtConsulta.Text, out cod))
            {
                errorProvider1.SetError(txtConsulta, "No ingresó la consulta");
                txtConsulta.Focus();
                return;
            }

            errorProvider1.SetError(txtConsulta, "");

            string cadena = "select id, nombre, dui, salario, afp, isss, neto from Empleados where Id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    dataGridView1.Rows[0].Cells[0].Value = registro.GetInt32(0);
                    dataGridView1.Rows[0].Cells[1].Value = registro.GetString(1);
                    dataGridView1.Rows[0].Cells[2].Value = registro.GetString(2);
                    dataGridView1.Rows[0].Cells[3].Value = registro.GetDecimal(3);
                    dataGridView1.Rows[0].Cells[4].Value = registro.GetDecimal(4);
                    dataGridView1.Rows[0].Cells[5].Value = registro.GetDecimal(5);
                    dataGridView1.Rows[0].Cells[6].Value = registro.GetDecimal(6);
                }
                else
                    MessageBox.Show("No existe un Empleado con el código ingresado");
            
            conexion.Close();

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDUI.Clear();
            txtSalario.Clear();
            txtAFP.Clear();
            txtISSS.Clear();
            txtNeto.Clear();
            txtConsulta.Clear();
        }


        private void btModificar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            try
            {


                string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                string Dnombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Ddui = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string Dsalario = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string DAFP = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string DISSS = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string DNeto = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string cadena = "update [Empleados] set nombre='" + Dnombre + "', dui='" + Ddui + "', salario='" + Dsalario + "', afp='" + DAFP + "', isss='" + DISSS + "', neto='" + DNeto + "' where Id=" + cod;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    MessageBox.Show("Se modificaron los datos del empleado");
                }
            }
            catch (Exception) { MessageBox.Show("No seleccionó el empleado"); }
            conexion.Close();
        }

        private void btVerTodo_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            string cadena = "select id, nombre, dui, salario, afp, isss, neto from Empleados";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = registro.GetInt32(0);
                    dataGridView1.Rows[n].Cells[1].Value = registro.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = registro.GetString(2);
                    dataGridView1.Rows[n].Cells[3].Value = registro.GetDecimal(3);
                    dataGridView1.Rows[n].Cells[4].Value = registro.GetDecimal(4);
                    dataGridView1.Rows[n].Cells[5].Value = registro.GetDecimal(5);
                    dataGridView1.Rows[n].Cells[6].Value = registro.GetDecimal(6);
                }
            }
            else
                MessageBox.Show("No existen un registros");
            conexion.Close();

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
                conexion.Open();
                try
                {
                    string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    string cadena = "delete from [Empleados] where Id=" + cod;
                    SqlCommand comando = new SqlCommand(cadena, conexion);


                    int cant;
                    cant = comando.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        this.dataGridView1.DataSource = null;
                        this.dataGridView1.Rows.Clear();
                        MessageBox.Show("Se borró el registro");
                    }


                }
                catch (Exception) { MessageBox.Show("Debe seleccionar un registro"); }
                conexion.Close();

            }

        }
    }
}
