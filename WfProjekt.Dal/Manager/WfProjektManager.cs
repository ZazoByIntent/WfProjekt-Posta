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
        private string _connectionString;

        #region Constants
        //const string _connectionString = "Data Source=172.26.160.19;Initial Catalog=UPODb;User ID=razvoj;Password=Razvoj3"; // pridobi iz UI, iz app.config
        const string QUERY_STRING_SELECT = "SELECT TOP (1) [Racun], [PostaId], [DelovnoMestoId], [UporabnikId], [Vrednost], [OznakaValute], [ZnesekPostnine], [Ime], [HisnaSt], [Namen]  FROM [UPODb].[dbo].[dpnBN02]";
        const string QUERY_STRING_UPDATE = "UPDATE [UPODb].[dbo].[dpnBN02] SET DelovnoMestoID = '7' WHERE POSTAID = ";
        const string QUERY_STRING_INSERT = "INSERT INTO [UPODb].[dbo].[dpnBN02] ([Racun], [PostaId], [DelovnoMestoId], [UporabnikId], [Vrednost], [OznakaValute], [ZnesekPostnine], [Ime], [HisnaSt], [Namen]) VALUES (";
        #endregion


        public WfProjektManager(string aConnectionString)
        {
            _connectionString = aConnectionString;
        }

        public WfProjektModel SelectValues()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(QUERY_STRING_SELECT, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (dataReader.Read())
                    return new Mappers.WfProjektMapper().FillFromReader(dataReader);
                else return new WfProjektModel();
            }
        }
        public void UpdateValues(WfProjektModel aModel)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(QUERY_STRING_UPDATE + aModel.IDPoste, connection);
                command.ExecuteNonQuery();
            }
        }

        public void InsertValues(WfProjektModel aModel)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("[UPODb].[dbo].[dpnBN02Insert]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@PoslovnaEnotaID", 1000));
                command.Parameters.Add(new SqlParameter("@PostaId", aModel.IDPoste));
                command.Parameters.Add(new SqlParameter("@DelovnoMestoId", aModel.IDDelovnegaMesta));
                command.Parameters.Add(new SqlParameter("@UporabnikId", aModel.IDUporabnika));
                command.Parameters.Add(new SqlParameter("@DatumCas", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
                command.Parameters.Add(new SqlParameter("@UporabnikSpremId", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
                command.Parameters.Add(new SqlParameter("@DatumCasSprem", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
                command.Parameters.Add(new SqlParameter("@ZapStStranke", 200));
                command.Parameters.Add(new SqlParameter("@DatumValute", "2016-01-22 00:00:00.000"));
                command.Parameters.Add(new SqlParameter("@StoritevId", "803707"));
                command.Parameters.Add(new SqlParameter("@VrstaPosla", "8200"));
                command.Parameters.Add(new SqlParameter("@StTransakcije", 22));
                command.Parameters.Add(new SqlParameter("@StDokumenta", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Storno", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@VezaNaOriginal", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@NacinVnosa", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Vrednost", aModel.vrednost));
                command.Parameters.Add(new SqlParameter("@ValutaId", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@OznakaValute", aModel.oznakaValute));
                command.Parameters.Add(new SqlParameter("@VrednostEUR", aModel.vrednost));
                command.Parameters.Add(new SqlParameter("@Racun", aModel.stRacuna)); 
                command.Parameters.Add(new SqlParameter("@Model", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Sklic", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@ZnesekPostnine", aModel.znesekPostnine));
                command.Parameters.Add(new SqlParameter("@PosebneStoritve", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@TipTransakcijeId", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@StVeznegaDok", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Priimek", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Ime", aModel.ime));
                command.Parameters.Add(new SqlParameter("@NaslovUlica", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Kraj", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@HisnaSt", aModel.hisnaStevilka));
                command.Parameters.Add(new SqlParameter("@HisnaDod", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@PostnaSt", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Namen", aModel.namen)); // MS Wrapper?
                command.Parameters.Add(new SqlParameter("@Sifra", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@DrzavaId", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@PriimekD", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@ImeD", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@NaslovUlicaD", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@KrajD", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@HisnaStD", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@HisnaDodD", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@PostnaStD", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@VrstaDok", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@OsebniDokument", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@DokumentIzdal", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@KrajRojstva", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@DatumRojstva", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@DavcnaSt", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Status", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Status1", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Status2", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Status3", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Stevilo1", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Stevilo2", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Stevilo3", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Datum1", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Datum2", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Datum3", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@DatumPrenosa", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@HostStatus", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@StatusPrenosa", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@NacinKnizenjaPosta", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Obrazec", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@TipReference", DBNull.Value)); 
                command.Parameters.Add(new SqlParameter("@Oznaka1", DBNull.Value));
                command.Parameters.Add(new SqlParameter("@OznakaIzracuna", DBNull.Value));
                command.Parameters.Add(new SqlParameter("@DejanskaPostnina", DBNull.Value));

                command.ExecuteNonQuery();
            }
        }

        /*
         * Napisano z stored procedurami
         * 
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

    }
}
