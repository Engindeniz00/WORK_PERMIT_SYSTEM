using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WORK_PERMIT_SYSSTEM
{
    public static class Utils
    {
        private static string baglantiAdr = "Data Source=DESKTOP-7SDHT04;Initial Catalog=IZINYONETIMSISTEMI;Integrated Security=True";
        private static SqlConnection sqlConnection;
        public static int KullaniciId;
        public static string KullaniciAdi;
        private static string connStr() 
        {
            return baglantiAdr;
        }

        private static void BaglantiSagla()
        {
            sqlConnection = new SqlConnection(connStr());

            try
            {
                BaglantiAc();
            }
            catch(Exception)
            {

            }

        }


        public static DataTable TabloGetir(string sorgu)
        {
            BaglantiSagla();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand(sorgu);
            sqlDataAdapter.SelectCommand.Connection = sqlConnection;
            DataTable dtTable = new DataTable();
            sqlDataAdapter.Fill(dtTable);
            BaglantiKapat();
            return dtTable;
        }

        public static bool SorguCalistir(string sorgu)
        {
            BaglantiSagla();
            SqlCommand sqlCommand = new SqlCommand(sorgu);
            sqlCommand.Connection = sqlConnection;
            try
            {
                sqlCommand.ExecuteNonQuery();
                BaglantiKapat();
                return true;
            }
            catch
            {
                BaglantiKapat();
                return false;
            }
        }


        public static string TekDegerAlString(string sorgu)
        {
            string deger="";
            BaglantiSagla();
            SqlCommand sqlCommand = new SqlCommand(sorgu, sqlConnection);
            try
            {
                deger = sqlCommand.ExecuteScalar().ToString();
                BaglantiKapat();
                return deger;
            }
            catch
            {
                BaglantiKapat();
                return deger;
            }

        }

        public static int TekDegerAlInt(string sorgu)
        {
            int deger = 0;
            BaglantiSagla();
            SqlCommand sqlCommand = new SqlCommand(sorgu, sqlConnection);
            try
            {
                deger = Convert.ToInt32(sqlCommand.ExecuteNonQuery(), null);
                BaglantiKapat();
                return deger;
            }
            catch
            {
                BaglantiKapat();
                return deger;
            }
        }


        private static void BaglantiAc()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        private static void BaglantiKapat()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }


    }
}
