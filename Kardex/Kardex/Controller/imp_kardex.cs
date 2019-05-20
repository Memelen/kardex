using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kardex.View;

namespace Kardex.Controller
{
    class imp_kardex
    {
        Kardex_form kform = new Kardex_form();

        public void imprimir(int nua)
        {
            SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB);
            connection.Open();
            SqlParameter nuaParameter = new SqlParameter("@nua", nua);

            SqlCommand command = new SqlCommand("select nombre, op, grupo, cali, estatus, semestre from dbo.kardex, dbo.materia where dbo.kardex.NUA=@nua and dbo.kardex.materia=dbo.materia.id_materia;", connection);
            command.Parameters.Add(nuaParameter);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                kform.lbl_materia.Text += "\n";
                kform.lbl_materia.Text += reader.GetString(0);
                kform.lbl_op.Text += "\n";
                kform.lbl_op.Text += reader.GetInt32(1);
                kform.lbl_grupo.Text += "\n";
                kform.lbl_grupo.Text += reader.GetString(2);
                kform.lbl_calif.Text += "\n";
                kform.lbl_calif.Text += reader.GetInt32(3);
                kform.lbl_estatus.Text += "\n";
                kform.lbl_estatus.Text += reader.GetString(4);
                kform.lbl_semestre.Text += "\n";
                kform.lbl_semestre.Text += reader.GetString(5);
            }
            reader.Close();
            connection.Close();
            kform.ShowDialog();
        }
    }
}
