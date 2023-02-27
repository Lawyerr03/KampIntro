using System;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }


    }
}
