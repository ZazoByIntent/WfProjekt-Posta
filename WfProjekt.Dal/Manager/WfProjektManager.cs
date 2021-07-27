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
        const string queryStringUpdate = "UPDATE [UPODb].[dbo].[dpnBN02] SET DelovnoMestoID = '5' WHERE POSTAID = ";
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
                SqlCommand command = new SqlCommand(queryStringInsert + aModel.stRacuna + "," + aModel.IDPoste + "," + aModel.IDDelovnegaMesta + "," + aModel.IDUporabnika + "," + aModel.vrednost + ",'" + aModel.oznakaValute + "'," + aModel.znesekPostnine + "," + aModel.ime + "," + aModel.hisnaStevilka + ",'" + aModel.namen + "')", connection);
                command.ExecuteNonQuery();
            }
        }

    }
}
