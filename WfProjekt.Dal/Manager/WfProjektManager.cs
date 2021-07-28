using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using WfProjekt.Model;

namespace WfProjekt.Dal.Manager
{
    public class WfProjektManager
    {
        const string _connection = "Data Source=172.26.160.19;Initial Catalog=UPODb;User ID=razvoj;Password=Razvoj3";
        const string queryStringSelect = "SELECT TOP (1) [Racun], [PostaId], [DelovnoMestoId], [UporabnikId], [Vrednost], [OznakaValute], [ZnesekPostnine], [Ime], [HisnaSt], [Namen]  FROM [UPODb].[dbo].[dpnBN02]";
        const string queryStringUpdate = "UPDATE [UPODb].[dbo].[dpnBN02] SET DelovnoMestoID = '6' WHERE POSTAID = ";
        const string queryStringInsert = "INSERT INTO [UPODb].[dbo].[dpnBN02] ([Racun], [PostaId], [DelovnoMestoId], [UporabnikId], [Vrednost], [OznakaValute], [ZnesekPostnine], [Ime], [HisnaSt], [Namen]) VALUES (";

        
        public static WfProjektModel selectValues()
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                SqlCommand command = new SqlCommand(queryStringSelect, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                WfProjektModel aModel = new WfProjektModel();
                if (dataReader.Read())
                    aModel = Mappers.WfProjektMapper.FillFromReader(dataReader);
                return aModel;
            }
        }

        /*
        public static WfProjektModel selectValues()
        {
                using (SqlConnection connection = new SqlConnection(_connection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("[UPODb].[dbo].[dpnBN02Select]", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader activeReader = command.ExecuteReader();
                    WfProjektModel aModel = new WfProjektModel();
                    if (activeReader.Read())
                        aModel = Mappers.WfProjektMapper.FillFromReader(activeReader);
                    return aModel;
                }
        }
        
        */

        public void updateValues(WfProjektModel aModel)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryStringUpdate + aModel.IDPoste, connection);
                command.ExecuteNonQuery();
            }
        }

        public void insertValues(WfProjektModel aModel)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("[UPODb].[dbo].[dpnBN02Update]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@PoslovnaEnotaID", 1000));
                command.Parameters.Add(new SqlParameter("@PostaId", aModel.IDPoste));
                command.Parameters.Add(new SqlParameter("@UporabnikId", aModel.IDUporabnika));
                command.Parameters.Add(new SqlParameter("@DatumCas", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
                command.Parameters.Add(new SqlParameter("@DatumValute", "2016-01-22 00:00:00.000"));
                command.Parameters.Add(new SqlParameter("@VrstaPosla", "8200"));
                command.Parameters.Add(new SqlParameter("@StTransakcije", aModel.stRacuna));
                command.Parameters.Add(new SqlParameter("@Vrednost", aModel.vrednost));
                command.Parameters.Add(new SqlParameter("VrednostEUR", aModel.vrednost));
                command.Parameters.Add(new SqlParameter("@ZnesekPostnine", aModel.znesekPostnine));
                command.Parameters.Add(new SqlParameter("@DelovnoMestoId", aModel.IDDelovnegaMesta));
                command.Parameters.Add(new SqlParameter("@OznakaValute", aModel.oznakaValute));
                command.Parameters.Add(new SqlParameter("@Ime", aModel.ime));
                command.Parameters.Add(new SqlParameter("@HisnaSt", aModel.hisnaStevilka));
                command.Parameters.Add(new SqlParameter("@Namen", aModel.namen));

                command.ExecuteNonQuery();
            }
        }

    }
}
