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

        public List<AppRefData> GetPayrollState(int countryId)
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_PayrollState_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@countryId", SqlDbType.Int);
            cmd.Parameters["@countryId"].Value = countryId;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["State_Id"]), KeyName = reader["Payroll_State"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<AppRefData> GetSalesPerson()
        {
            List<AppRefData> getComps = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_SalesPerson_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["EmployeeDetails_Id"]), KeyName = reader["SalesPerson"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }

        public List<Project> GetProjectList()
        {
            DataSet ds = new DataSet();
            List<Project> SelectListNew = new List<Project>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_list_Prabhu_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(ds);
            }
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Project obj = new Project();
                    obj.Customer_Name = Convert.ToString(ds.Tables[0].Rows[i]["CustomerName"]);
                    obj.Project_Name = Convert.ToString(ds.Tables[0].Rows[i]["ProjectName"]);
                    obj.Project_Id = Convert.ToString(ds.Tables[0].Rows[i]["ProjectId"]);
                    obj.ProjectStartDate = Convert.ToString(ds.Tables[0].Rows[i]["StartDate"]);
                    obj.ProjectEndDate = Convert.ToString(ds.Tables[0].Rows[i]["EndDate"]);
                    obj.Project_Status = Convert.ToString(ds.Tables[0].Rows[i]["ProjectStatus"]);
                    obj.LocationGroup = Convert.ToString(ds.Tables[0].Rows[i]["LocationGroup"]);
                    obj.State_Name = Convert.ToString(ds.Tables[0].Rows[i]["PayRollState"]);
                    obj.SalesPersonName = Convert.ToString(ds.Tables[0].Rows[i]["SalesPerson"]);
                    obj.ProjectCategory = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCategory"]);
                    obj.Project_Type = Convert.ToString(ds.Tables[0].Rows[i]["ProjectType"]);
                    obj.Sub_Domain = Convert.ToString(ds.Tables[0].Rows[i]["SubDomain"]);
                    obj.TimeSheetRepresentative = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetRepresentative"]);
                    obj.InvoiceGroup = Convert.ToString(ds.Tables[0].Rows[i]["ClientInvoiceGroup"]);
                    obj.TimesheetType = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetType"]);
                    obj.IsVmsTimeSheet = Convert.ToString(ds.Tables[0].Rows[i]["IsVmsTimeSheet"]);
                    obj.PracticeType = Convert.ToString(ds.Tables[0].Rows[i]["PracticeType"]);
                    obj.Recruiter = Convert.ToString(ds.Tables[0].Rows[i]["Recruiter"]);
                    SelectListNew.Add(obj);
                }
            }

            return SelectListNew;
        }

        public DataSet GetList(ProjectAddEditViewModel pmodel)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ToString());
            SqlCommand cmd = new SqlCommand("Get_list_Prabhu_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet myrec = new DataSet();
            da.Fill(myrec);
            return myrec;
        }

    }
}