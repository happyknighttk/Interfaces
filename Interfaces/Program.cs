using System;

namespace Interfaces
{
    internal class Program
    {
        // interface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            projectManager.Add(new EmployeeManager());


        }
    }
    interface IPersonManager //şablon
    {
        //public void Add()
        //{
        //    Console.WriteLine("Eklendi"); //Implemented operation
        //}
        void Add(); //Unimplemented operation
        void Update();
    }
    // inherits - class ------------- implements - interface
    class CustomerManager: IPersonManager 
    {
        public void Add() {
            Console.WriteLine("Müşteri Eklendi"); // müşteri ekleme kodları
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager: IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Çalışan Eklendi"); // çalışan ekleme kodları
        }

        public void Update()
        {
            Console.WriteLine("Çalışan Güncellendi");
        }
    }
    class InternManager: IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("InternManager Eklendi"); // InternManager ekleme kodları
        }

        public void Update()
        {
            Console.WriteLine("InternManager Güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
