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
        #region variables
        private static string baglantiAdr = "Data Source=.;Initial Catalog=IZINYONETIMSISTEMI;Integrated Security=True";
        private static SqlConnection sqlConnection;
        public static int KullaniciId;
        public static string KullaniciAdi;
        public static int izinIndex;
        public static int izinKullaniciId;
        public static int personelUnvanId;
        public static int izinBelgeSelectedIndex;
        public static int izinBelgeSelectedPersonelID;
        public static int izinBelgeSelectedDurumID;
        public static int izinBelgeSelectedUnvanID;
        public static int izinBelgeSelectedIzinID;
       
        #endregion variables

        #region sql_baglanti
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

        #endregion sql_baglanti

        #region datetime_operations

        public static int HesaplaGun(DateTime _ilkGun, DateTime _sonGun)
        {
            TimeSpan subtrDays = _sonGun.Subtract(_ilkGun);
            int gun_top = Convert.ToInt32(subtrDays.Days.ToString());
            while(_ilkGun != _sonGun)
            {
                if(_ilkGun.DayOfWeek == DayOfWeek.Saturday || _ilkGun.DayOfWeek == DayOfWeek.Sunday)
                {
                    gun_top--;
                }
                _ilkGun = _ilkGun.AddDays(1);
            }
            return gun_top+1;                           
        }

        public static int HesaplaSaat(DateTime _ilkGun, DateTime _sonGun)
        {
            int saat = 0;
            do
            {
                if (_ilkGun.DayOfWeek != DayOfWeek.Saturday && _ilkGun.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (_ilkGun.Hour >= 8 && _ilkGun.Hour < 18 && (_ilkGun.Hour < 12 || _ilkGun.Hour >= 13))
                    {
                        saat++;
                    }
                }
                _ilkGun = _ilkGun.AddHours(1);
            } while (_ilkGun.Hour != _sonGun.Hour || _ilkGun.Date != _sonGun.Date);
            return saat;
        }




        #endregion datetime_operations

    }
}
