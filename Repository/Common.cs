using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebApplication2.Models;
using System.Web.Mvc;
using WebApplication2.ViewModel;

namespace WebApplication2.Repository
{
    public class Common
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }

        public List<AppRefData> GetAppRefData(int parentId)
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("getStatus_Training_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@parentId", SqlDbType.Int);
            cmd.Parameters["@parentId"].Value = parentId;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["KeyId"]), KeyName = reader["KeyName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<AppRefData> GetLocGroup()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_LocationGroup_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["LOCATION_ID"]), KeyName = reader["LOCATION_NAME"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<AppRefData> GetProjCat()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_ProjCat_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["KeyID"]), KeyName = reader["KeyName"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<AppRefData> GetProjType()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_ProjType_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["KeyID"]), KeyName = reader["KeyName"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<AppRefData> GetSubdomain()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_Sub_Domain_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["KeyID"]), KeyName = reader["KeyName"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<AppRefData> GetTimeSheet()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_TimeSheet_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["EmployeeDetails_Id"]), KeyName = reader["TimeSheetRepresentative"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<AppRefData> GetTimeSheetType()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_TimeSheetType_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["KeyID"]), KeyName = reader["KeyName"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<AppRefData> GetPracticeType()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_PracticeType_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["KeyID"]), KeyName = reader["KeyName"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<AppRefData> GetRecruiter()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_Recruiter_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["RecruiterId"]), KeyName = reader["Recruiter"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<AppRefData> GetInvoiceGroup()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_InvoiceGroup_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["KeyID"]), KeyName = reader["InvoiceGroup"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

      
    }
}