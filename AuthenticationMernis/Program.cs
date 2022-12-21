using AuthenticationMernis.Abstract;
using AuthenticationMernis.Adapters;
using AuthenticationMernis.Concrete;
using AuthenticationMernis.Entities;

BaseCustomerManager customerManager =new StarbucksCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer {DateOfBirth= new DateTime(1945,07,03), Name= "Mervegül", LastName="Aydın", NationalityId="55555555555"});

Console.ReadLine();