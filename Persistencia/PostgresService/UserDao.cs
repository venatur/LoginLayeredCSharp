using System;
using System.Collections.Generic;
using System.Data;
using Common;
using Common.Cache;

namespace Persistencia
{
    public class UserDao : ConnectionPSQL
    {
        public bool Login(string user, string password)
        {
            using (var connection = GetConnection())
            {
                Console.Write(user, password);
                
                var sql = "SELECT * FROM users where username="+"'"+user+"' and password= '"+password+"'" ;
                connection.Open();
                using var cmd = new Npgsql.NpgsqlCommand(sql, connection);
                Npgsql.NpgsqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UserLoginCache.idUser = dr.GetInt32(0);
                        UserLoginCache.Username = dr.GetString(1);
                        UserLoginCache.Email = dr.GetString(3);
                        UserLoginCache.F_name = dr.GetString(4);
                        UserLoginCache.L_name = dr.GetString(5);
                        UserLoginCache.Role = dr.GetString(6);
                    }
                    
                    return true;
                }
                else
                    return false;
                
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var sql = "select * from users where username =@user or email=@mail";
                using (var cmd = new Npgsql.NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@user",userRequesting);
                    cmd.Parameters.AddWithValue("@mail", userRequesting);
                    cmd.CommandType = CommandType.Text;
                    Npgsql.NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string username = reader.GetString(1);
                        string password = reader.GetString(2);
                        string email = reader.GetString(3);
                        var mailService = new EmailService.SystemSupportMail();
                        mailService.sendMail(
                            subject: "System: Password Recovery request",
                            body: "Hi " + username + "\n you requested to recover your password.\n" +
                            "your current password is " + password,
                            recipientMail: new List<string> { email });
                        return "Hi " + username + "\n you requested to recover your password.\n" +
                            "your current password is " + password;

                    }
                    else
                        return "Sorry you dont have any accout with us";

                }
                

            }
        }
    }
}
