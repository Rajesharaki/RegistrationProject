using Registration.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Repositories
{
    public class IRegisterRepository : IRegister
    {
        public void InsertRegisterRecord(RegistrationModel model)
        {
            using (var con=new SqlConnection(""))
            {
                var cmd = new SqlCommand("SpName", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", model.Name);
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                cmd.Parameters.AddWithValue("@Gender", model.Gender);
                cmd.Parameters.AddWithValue("@Language", model.Language);
                cmd.Parameters.AddWithValue("@Zipcode", model.Zipcode);
                cmd.Parameters.AddWithValue("@About", model.About);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
