using System;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Web.Configuration;
using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Web.Configuration;
using Microsoft.ApplicationBlocks.Data;

namespace Proyecto
{
    public class ClsInscripciones
    {
        public int Ced_Inscrip { get; set; }
        public string Nom_Inscrip { get; set; }
        public string Edad_Inscrip { get; set; }
        public string Genero_Inscrip { get; set; }
        public int Tiempo_Inscrip { get; set; }
    }
    
        public ClsInscripciones()
        {
            Ced_Inscrip = 0;
            Nom_Inscrip = "";
            Edad_Inscrip = "";
            Genero_Inscrip = "";
            Tiempo_Inscrip = 0;
        }

        public ClsInscripciones(int auxced, string auxnom, string auxedad, string auxgenero, int auxtiempo)
        {
            Ced_Inscrip = auxced;
            Nom_Inscrip = auxnom;
            Edad_Inscrip = auxedad;
            Genero_Inscrip = auxgenero;
            Tiempo_Inscrip = auxtiempo;
        }
    
    public void Guardar_Participante()
    {
        SqlParameter[] Parametros = new SqlParameter[4];

        System.Data.SqlDbType Ced_Inscrip = default;
        Parametros[0] = new SqlParameter("@Ced", Ced_Inscrip);
        System.Data.SqlDbType Nom_Inscrip = default;
        Parametros[1] = new SqlParameter("@Nom", Nom_Inscrip);
        System.Data.SqlDbType Edad_Inscrip = default;
        Parametros[2] = new SqlParameter("@Edad", Edad_Inscrip);
        System.Data.SqlDbType Genero_Inscrip = default;
        Parametros[3] = new SqlParameter("@Genero", Genero_Inscrip);
        System.Data.SqlDbType Tiempo_Inscrip = default;
        Parametros[4] = new SqlParameter("@Tiempo", Tiempo_Inscrip);

        SqlHelper.ExecuteNonQuery(WebConfigurationManager.ConnectionStrings["Conexion"].ConnectionString, System.Data.CommandType.StoredProcedure, "Name", Parametros);
    }
}
 