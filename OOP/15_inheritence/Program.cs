using System;
namespace _15_inheritence;

class Program
{
    static void Main(string[] args)
    {
        SqlServer sqlServer = new SqlServer();
        sqlServer.Add();

        MySql mySql = new MySql();
        mySql.Add();
        
    }

}

class Database
{
    public virtual void Add()
    {
        System.Console.WriteLine("added by default");
    }

    public virtual void Delete()
    {
        System.Console.WriteLine("deleted by default");

    }
}


class SqlServer:Database
{
    public override void Add()
    {
    System.Console.WriteLine("sql added by virtual");
    base.Add();
    }
}

class MySql:Database
{


}