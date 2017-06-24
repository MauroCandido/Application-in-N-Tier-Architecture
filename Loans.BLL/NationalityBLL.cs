using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loans.DAL;
using Loans.DTO;
using System.Data;

namespace Loans.BLL
{
   public class NationalityBLL
    {

        public void Insert(NationalityDTO oNationality)
        {
            string sql = "";
            try
            {
                string[] parameters       = new string[0];
                string[] parametersValues = new string[0];
                parameters[0] = "@nationality";
                parametersValues[0] = oNationality.nationality;

                //sql = "INSERT INTO Nationality (nationality) values (@nationality)";
                sql = "spNationality_INS";
                AcessoDB.CRUD(sql, parameters, parametersValues);
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(NationalityDTO oNationality)
        {
            string sql = "";
            try
            {
                string[] parameters = new string[2];
                string[] parametersValues = new string[2];
                parameters[0] = "@ID";
                parameters[1] = "@nationality";

                parametersValues[0] = oNationality.id.ToString();
                parametersValues[1] = oNationality.nationality;
                sql = "UPDATE Nationality SET nationality = @nationality where ID = @ID ";
                //sql = "spNationality_INS";
                AcessoDB.CRUD(sql, parameters, parametersValues, false);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable Fill()
        {
            string sql = "SELECT * FROM NATIONALITY";
            try
            {
                return AcessoDB.GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
        
}
