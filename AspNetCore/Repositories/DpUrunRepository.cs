using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Entities;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace AspNetCore.Repositories
{
    public class DpUrunRepository
    {
         public List<Urun> GetAll()
        {
            using var connection = new SqlConnection("server=DESKTOP-2V7PJIR; database=Deneme; User Id=ZGN; Password=123; trusted_connection=true;");
            return connection.GetAll<Urun>().ToList();
        }
    }
}
