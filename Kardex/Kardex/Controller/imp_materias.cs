using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kardex.View;


namespace Kardex.Controller
{
    class imp_materias
    {
        Materias_form mform = new Materias_form();
     
        public void imprimir(int nua)
        {
            SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB);
            connection.Open();
            SqlParameter nuaParameter = new SqlParameter("@nua", nua);

            SqlCommand command = new SqlCommand("select id_materia, nombre, descrip, creditos from dbo.kardex, dbo.materia where dbo.kardex.NUA=@nua and dbo.kardex.materia=dbo.materia.id_materia;", connection);
            command.Parameters.Add(nuaParameter);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mform.lbl_id.Text += "\n";
                mform.lbl_id.Text += reader.GetInt32(0);
                mform.lbl_materia.Text += "\n";
                mform.lbl_materia.Text += reader.GetString(1);
                mform.lbl_desc.Text += "\n";
                mform.lbl_desc.Text += reader.GetString(2);
                mform.lbl_cred.Text += "\n";
                mform.lbl_cred.Text += reader.GetInt32(3);
            }
            reader.Close();
            connection.Close();
            mform.ShowDialog();
        }
    }
}
