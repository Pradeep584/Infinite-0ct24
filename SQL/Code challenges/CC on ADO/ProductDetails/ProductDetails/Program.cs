using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductDetails
{
   public class Program
    {
        public static SqlConnection con = null; 
        public static  SqlCommand cmd = null;
        public static IDataReader reader = null;

        void insert()
        {
            con = new SqlConnection("Data source = ICS-LT-D244D6D0; database=Pradeep_db; trusted_connection = true;");
            con.Open();

            cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;

          
            Console.WriteLine("Enter The ProductName: ");
            string ProductName = Console.ReadLine();
            Console.WriteLine("Enter the Price: ");
            float Price = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the discountprice: ");
           float DiscountedPrice = Convert.ToInt32(Console.ReadLine());
            DiscountedPrice = Price - (Price * 0.10f);

          
            cmd.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.VarChar, 25)).Value = ProductName;
            cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float)).Value = Price;
            cmd.Parameters.Add(new SqlParameter("@DiscountedPrice", SqlDbType.Float)).Value = DiscountedPrice;

            int result = cmd.ExecuteNonQuery();
            if(result > 0)
            {
                Console.WriteLine("Successfully inserted ");
            }
            con.Close();
        }
        
        void select()
        {
            con = new SqlConnection("Data source = ICS-LT-D244D6D0; database=Pradeep_db; trusted_connection = true;");
            con.Open();

            cmd = new SqlCommand("sp_select", con);
            cmd.CommandType = CommandType.StoredProcedure;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ProductId:" + reader[0]+"\t"+ "ProductName:" + reader[1]+"\t" + "Price:" + reader[2]+"\t"+"Discounted_price:"+reader[3]);
            }
            con.Close();

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.insert();
            p.select();
            Console.Read();

        }
    }
}
