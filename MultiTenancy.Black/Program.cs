using MultiTenancy.Core.Common;
using MultiTenancy.Core.Entities;
using MultiTenancy.DataAccess.Repository;
using System;
using System.Linq;

namespace MultiTenancy.Black
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IoC.Init();
            var repo = DI.Resolve<IRepository<Employee>>();
            var names = repo.All().ToList();
            names.ForEach(e => Console.WriteLine($"{e.Id,-2}| {e.Name,-10}"));
            Console.ReadLine();
        }
    }
}