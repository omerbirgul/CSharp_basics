namespace Gercek_Hayatta_Interface;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        System.Console.WriteLine("Add funtion");
        customerManager.Add(new OracleCustomerDal());
        customerManager.Add(new SqlServerCustomerDal());
        System.Console.WriteLine("********************************");

        System.Console.WriteLine("delete funtion");
        customerManager.Delete(new OracleCustomerDal());
        customerManager.Delete(new SqlServerCustomerDal());
        System.Console.WriteLine("********************************");

        System.Console.WriteLine("Update funtion");
        customerManager.Update(new OracleCustomerDal());
        customerManager.Update(new SqlServerCustomerDal());
        System.Console.WriteLine("********************************");
    }
}
