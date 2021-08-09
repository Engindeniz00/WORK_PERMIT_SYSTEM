using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;




namespace WORK_PERMIT_SYSSTEM
{
    public static class SQLiteUtils
    {
        private static SQLiteConnection sQlLiteConnection;
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void BaglantiSagla()
        {
            sQlLiteConnection = new SQLiteConnection(LoadConnectionString());
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
            SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sorgu, sQlLiteConnection);
            DataTable dataTable = new DataTable();
            sQLiteDataAdapter.Fill(dataTable);
            BaglantiKapat();
            return dataTable;
        }

        public static bool SorguCalistir(string sorgu)
        {
            BaglantiSagla();
            SQLiteCommand sQLiteCommand = new SQLiteCommand(sorgu, sQlLiteConnection);

            try
            {
                sQLiteCommand.ExecuteNonQuery();
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
            string deger = "";
            BaglantiSagla();
            SQLiteCommand sQLiteCommand = new SQLiteCommand(sorgu, sQlLiteConnection);
            try
            {
                deger = sQLiteCommand.ExecuteScalar().ToString();
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
            SQLiteCommand sQLiteCommand = new SQLiteCommand(sorgu, sQlLiteConnection);
            try
            {
                deger = Convert.ToInt32(sQLiteCommand.ExecuteNonQuery(), null);
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
            if (sQlLiteConnection.State == ConnectionState.Closed)
                sQlLiteConnection.Open();
        }
        private static void BaglantiKapat()
        {
            if (sQlLiteConnection.State == ConnectionState.Open)
                sQlLiteConnection.Close();
        }
    }
}
