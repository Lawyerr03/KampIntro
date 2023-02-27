using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager (new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth= new DateTime(1995,7,15), Firstname="Muhammed Mustafa",LastName = "ÇELİK", NationalityId = "13753437924"  });
            Console.ReadLine();
          
        }
    }
}
