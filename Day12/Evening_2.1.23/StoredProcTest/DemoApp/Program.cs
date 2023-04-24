using System.Data;

string customerId = args[0].ToUpper();
int productNo = int.Parse(args[1]);
int quantity = int.Parse(args[2]);
using var con = new Microsoft.Data.SqlClient.SqlConnection("Data Source=cdaclab.bkc.met.edu;Database=Shop1;User Id=dac1;Password=Dac1@1234;Encrypt=false");
con.Open();
using var cmd = con.CreateCommand();
cmd.CommandType = CommandType.StoredProcedure;
cmd.CommandText = "PlaceOrder";
cmd.Parameters.AddWithValue("@Customer", customerId);
cmd.Parameters.AddWithValue("@Product", productNo);
cmd.Parameters.AddWithValue("@Quantity", quantity);
var orderIdParam = cmd.Parameters.Add("@OrderId", SqlDbType.Int);
orderIdParam.Direction = ParameterDirection.Output;
try
{
    cmd.ExecuteNonQuery();
    Console.WriteLine("New Order Number: {0}", orderIdParam.Value);
}
catch
{
    Console.WriteLine("Order Failed!");
}
