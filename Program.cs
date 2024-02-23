using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Dapper;


// Server=localhost;Database=master;Trusted_Connection=True;

namespace HelloWorld
{
    public class Program
    {
      public static void Main(string[] args)
      {
          var connectionString =
              "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=True;Trusted_Connection=True;";
          IDbConnection dbConnection = new SqlConnection(connectionString);
          var sqlCommand = "SELECT GETDATE()";
           var rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
           Console.WriteLine("here");
            Console.WriteLine(rightNow);
            
            var myComputer = new Computer()
            {
                Motherboard = "ASUS",
                CPUCores = 8,
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = new DateTime(2021, 1, 1),
                Price = 1500.00M,
                VideoCard = "NVIDIA"
            };
       
        }
    }
}


