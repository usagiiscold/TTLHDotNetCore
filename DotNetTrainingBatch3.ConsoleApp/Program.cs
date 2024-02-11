// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

//F5 ==> run

// Ctrl + K,C ==>disable
// Ctrl + K,U ==>Enable
//console.readline();

//Ctrl + .
// F9 ==> Break point`
// shifr + f5=> stop


#region Read
SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(); 
sqlConnectionStringBuilder.DataSource = "DESKTOP-PPOKNAC\\MSSQLSERVER1";
sqlConnectionStringBuilder.InitialCatalog = "TestDb";
sqlConnectionStringBuilder.UserID = "sa";
sqlConnectionStringBuilder.Password = "sa@123";

string query = "select * from tbl_blog";
SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
sqlConnection.Open();

SqlCommand cmd = new SqlCommand(query, sqlConnection);
SqlDataAdapter adapter = new SqlDataAdapter(cmd);

DataTable dt = new DataTable();
adapter.Fill(dt);

sqlConnection.Close(); 

//Dataset
//Datatable
//datarow
//Datacolumn
foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine(dr["Blogld"]);
    Console.WriteLine(dr["BlogTitle"]);
    Console.WriteLine(dr["BlogAuthor"]);
    Console.WriteLine(dr["BlogContent"]);
}

#endregion
Console.ReadKey();
