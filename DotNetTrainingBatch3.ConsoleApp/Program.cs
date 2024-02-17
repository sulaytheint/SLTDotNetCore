// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using System.Data;

Console.WriteLine("Hello, World!");

// run F5
//stop => Shift+F5 

//comment Ctrl+K,C
//F9 => Break point


//Console.ReadLine();

#region "Read"
SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
sqlConnectionStringBuilder.DataSource = "DESKTOP-CQ7NSKT\\SQL2019";
sqlConnectionStringBuilder.InitialCatalog = "Test";
sqlConnectionStringBuilder.UserID = "euek";
sqlConnectionStringBuilder.Password = "p@ssw0rd";

String query = "Select * from Table_Blog";
SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
sqlConnection.Open();

SqlCommand cmd = new SqlCommand(query, sqlConnection);
SqlDataAdapter adapter = new SqlDataAdapter(cmd);

DataTable dt = new DataTable();
adapter.Fill(dt);

sqlConnection.Close();


//DataSet 
//DataTable
//DataRow 
//DataColumn

foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine(dr["BlogId"]);
    Console.WriteLine(dr["BlogTitle"]);
    Console.WriteLine(dr["BlogContent"]);
    Console.WriteLine(dr["BlogAuthor"]);
}

#endregion

Console.ReadKey();