using OOPS.Model;
using System;
namespace Program
{


    //public class Employee
    //{
    //   //employee releted Data Memeber 
    //   public int id = 101;
    //   public string name = "Mahi";
    //   public decimal salary = 30000;

    //   public decimal IncreamentSalary(double per)
    //   {
    //       salary = salary + (salary * (decimal)(per / 100));
    //       return salary;
    //   }
    //   public void DisplayEmployeeDetails()
    //   {
    //       Console.WriteLine($"Employee Id: {id}");
    //       Console.WriteLine($"Employee Name: {name}");
    //       Console.WriteLine($"Employee Salary: {salary}");
    //       Console.WriteLine("++++++++++++++++++++++++++++++++");
    //   }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        int a = 10;
    //        string b = "Hello";
    //        decimal c = 20.5m;


    //        Employee emp = new Employee();
    //        Employee emp2 = new Employee();
    //        Console.WriteLine("++++++++++++++++++++++++++++++++");

    //        emp.DisplayEmployeeDetails();
    //        emp2.DisplayEmployeeDetails();
    //        Console.WriteLine("++++++++++++++++++++++++++++++++");

    //        emp2.salary = 60000;
    //        emp2.name = "Ravi";
    //        emp2.id = 102;
    //        Console.WriteLine("After Updation of Employee 2 Details");
    //        Console.WriteLine("++++++++++++++++++++++++++++++++");

    //        emp2.DisplayEmployeeDetails();
    //        emp.DisplayEmployeeDetails();
    //        Console.WriteLine("++++++++++++++++++++++++++++++++");
    //        Console.WriteLine($"Salary after Increament: {emp.IncreamentSalary(10)}");
    //        emp.DisplayEmployeeDetails();



    //    }
    //}



    //============================================================================================================================================
    //===========================HomeWork==================================================================================================

    //public class Person
    //{

    //    public string Name = "Amit";
    //    public int Age = 25;
    //    public string Gender = "Male";
    //    public string City = "Pune";

    //    public void DisplayPerson()
    //    {
    //        Console.WriteLine($"Name : {Name}");
    //        Console.WriteLine($"Age : {Age}");
    //        Console.WriteLine($"Gender : {Gender}");
    //        Console.WriteLine($"City : {City}");
    //        Console.WriteLine();
    //    }
    //}

    //class Program
    //{
    //    public static void Main( string[] args )
    //    {
    //        Person p = new Person();
    //        p.DisplayPerson();
    //    }
    //}

    //=========================================================================================================================================================




    //public class Student
    //{

    //    public int rollNo = 101;
    //    public string name = "geet";
    //    public int marks = 75;
    //    public string course = "BCA";

    //    public string ResultStatus()
    //    {
    //        return marks >= 40 ? "Pass" : "Fail";
    //    }

    //    public void DisplayStudentInfo()
    //    {
    //        Console.WriteLine($"Student Roll No : {rollNo}");
    //        Console.WriteLine($"Student Name : {name}");
    //        Console.WriteLine($"Course  : {course}");
    //        Console.WriteLine($"Mark: {marks}");
    //        Console.WriteLine($"Result : {ResultStatus()}");
    //        Console.WriteLine();
    //    }
    //}
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Student p = new Student();
    //        p.DisplayStudentInfo();

    //    }
    //}


    //===================================================================================================================================================================

    //public class College
    //{
    //    public int collegeId = 1;
    //    public string collegeName = "DPU College";
    //    public string city = "Pune";
    //    public string grade = "A";

    //    public void DisplayCollege()
    //    {
    //        Console.WriteLine($"College Id: {collegeId}");
    //        Console.WriteLine($"College Name: {collegeName}");
    //        Console.WriteLine($"City: {city}");
    //        Console.WriteLine($"Grade: {grade}");
    //        Console.WriteLine();
    //    }
    //}
    // public class program
    //{
    //    public static void Main( string[] args )
    //    {
    //        College c = new College();
    //        c.DisplayCollege();
    //    }
    //}




    //===================================================================================================================================================================


    //public class Watch
    //{
    //    public string brand = "Titan";
    //    public decimal price = 5000;
    //    public string color = "Black";
    //    public int warranty = 2;

    //    public decimal ApplyDiscount(int percent)
    //    {
    //        price = price - (price * percent / 100);
    //        return price;
    //    }

    //    public void DisplayWatchDetails()
    //    {
    //        Console.WriteLine($"Brand: {brand}");
    //        Console.WriteLine($"Color: {color}");
    //        Console.WriteLine($"Price: {price}");
    //        Console.WriteLine($"Warranty : {warranty} Years");
    //        Console.WriteLine();
    //    }

    //    public class Program
    //    {
    //        public static void Main(string[] args)
    //        {
    //            Watch watch = new Watch();
    //            watch.DisplayWatchDetails();
    //            Console.WriteLine("After Discount:" + watch.ApplyDiscount(25));
    //        }
    //    }
    //}



    //==============================================================================================================================================================================

    //public class Mobile
    //{
    //   public String mobileBrand = "iphone";
    //   public decimal price = 123000;
    //   public string color = "white";
    //   public int warranty = 1;

    //   public decimal ApplyDiscount(int percent)
    //   {
    //       price = price - (price * percent / 100);
    //       return price;
    //   }
    //   public void DisplayMobileDetails()
    //   {
    //       Console.WriteLine($"Brand: {mobileBrand}");
    //       Console.WriteLine($"Color: {color}");
    //       Console.WriteLine($"Price: {price}");
    //       Console.WriteLine($"Warranty : {warranty} Years");
    //       Console.WriteLine();

    //   }
    //   public class Program
    //   {
    //       public static void Main(string[] args)
    //       {
    //           Mobile Mobile = new Mobile();
    //           Mobile.DisplayMobileDetails();
    //           Console.WriteLine("After Discount:" + Mobile.ApplyDiscount(15));
    //       } 
    //   }


    //}


    //================================================================================================================================================================================


    //public class Laptop
    //{
    //    public string LpBrand = "HP";
    //    public int ram = 8;
    //    public int storage = 512;
    //    public decimal price = 55000;
    //    public int warranty = 1;

    //    public decimal ApplyDiscount(int percent)
    //    {
    //        price = price - (price * percent / 100);
    //        return price;
    //    }
    //    public void DisplayLaptopDetails()
    //    {
    //        Console.WriteLine($"Brand: {LpBrand}");
    //        Console.WriteLine($"ram: {ram}");
    //        Console.WriteLine($"storage: {storage}");
    //        Console.WriteLine($"Price: {price}");
    //        Console.WriteLine($"Warranty : {warranty} Years");
    //        Console.WriteLine();
    //    }
    //    public class Program
    //    {
    //        public static void Main(string[] args)
    //        {
    //            Laptop lp = new Laptop();
    //            lp.DisplayLaptopDetails();
    //            Console.WriteLine("After Discount:" + lp.ApplyDiscount(15));
    //        }
    //    }

    //}


    //========================================================================================================================================================================

    //public class Table
    //{
    //  public double length = 5.5;
    //   public double width = 3.0;
    //   public string material = "wood";

    //   public void DisplayTableDetails()
    //   {
    //       Console.WriteLine($"length: {length}");
    //       Console.WriteLine($"width:{width}");
    //       Console.WriteLine($"material:{material}");

    //   }
    //   public class Program
    //   {
    //       public static void Main(string[] args)
    //       {
    //           Table table = new Table();
    //           table.DisplayTableDetails();
    //           Console.WriteLine();
    //       }
    //   }

    //}

    //=============================================================================================================================================================================


    // public class Product
    //{
    //    public int Id = 1;
    //    public string ProdName = "Headphone";
    //    public decimal ProdPrice = 1200;

    //    public void DisplayProductDetails()
    //    {
    //        Console.WriteLine($"Id: {Id}");
    //        Console.WriteLine($"Prodname:{ProdName}");
    //        Console.WriteLine($"Prodprice:{ProdPrice}");
    //    }
    //    public class Program
    //    {
    //        public static void Main( string[] args )
    //        {
    //            Product p = new Product();
    //            p.DisplayProductDetails();
    //        }
    //    }
    //}

    //===============================================================================================================================================================================


    //public class Customer
    //{
    //    public int Id = 1;
    //    public string CustomerName = "Shivtej";
    //    public string City = "pune";

    //    public void DisplayCustomerDetails()
    //    {
    //        Console.WriteLine($"id:{Id}");
    //        Console.WriteLine($"name:{CustomerName}");
    //        Console.WriteLine($"city:{City}");
    //    }
    //    public class Program
    //    {
    //        public static void Main( string[] args )
    //        {
    //            Customer c= new Customer();
    //            c.DisplayCustomerDetails();
    //        }
    //    }       
    //}


    //=======================================================================================================================================================================================

    //public class Invoice
    //{
    //    public int id = 11;
    //    public string customerName = "Shivtej";
    //    public decimal amount = 12254;
    //    public string invoiceDate = "26-04-2025";

    //    public void DisplayInvoiceDetails()
    //    {
    //        Console.WriteLine($"id:{id}");
    //        Console.WriteLine($"CName:{customerName}");
    //        Console.WriteLine($"Invoice Date: {invoiceDate}");
    //        Console.WriteLine($"Amount: {amount}");
    //    }
    //    public class Program
    //    {
    //        public static void Main(string[] args)
    //        {
    //            Invoice c = new Invoice();
    //            c.DisplayInvoiceDetails();
    //        }
    //    }

    //}

    //===================================================================================================================================================================



    //public class Person     //class declaration
    //{
    //    public int id = 1;
    //    public string name = "Amit";
    //    public int age = 25;
    //    public string city = "Pune";

    //    public void DisplayPersonDetails()
    //    {
    //        Console.WriteLine($"Person Id: {id}");
    //        Console.WriteLine($"Name : {name}");
    //        Console.WriteLine($"Age : {age}");
    //        Console.WriteLine($"City : {city}");
    //        Console.WriteLine();
    //    }
    //}

    //public class Program
    //{
    //    // Main method 
    //    public static void Main(string[] args)
    //    {
    //        Person p1 = new Person();
    //        Person p2 = new Person();

    //        Console.WriteLine();

    //        p1.DisplayPersonDetails();
    //        p2.DisplayPersonDetails();

    //        Console.WriteLine("++++++++++++++++++++++++++++++++++");

    //        p2.id = 2;
    //        p2.name = "Ravi";
    //        p2.age = 30;
    //        p2.city = "Mumbai";

    //        Console.WriteLine("After Updation of Person 2 Details");
    //        Console.WriteLine("++++++++++++++++++++++++++++++++");

    //        p2.DisplayPersonDetails();
    //        p1.DisplayPersonDetails();
    //    }
    //}


    //===========================================================================================================================================================

    //public class College
    //{
    //    public int collegeId = 1;
    //    public string collegeName = "DPU College";
    //    public string city = "Pune";
    //    public string grade = "A+";

    //    public void DisplayCollegeDetails()
    //    {
    //        Console.WriteLine($"College Id: {collegeId}");
    //        Console.WriteLine($"College Name: {collegeName}");
    //        Console.WriteLine($"City: {city}");
    //        Console.WriteLine($"Grade: {grade}");
    //        Console.WriteLine();
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        College c1 = new College();
    //        College c2 = new College();

    //        Console.WriteLine();

    //        c1.DisplayCollegeDetails();
    //        c2.DisplayCollegeDetails();

    //        Console.WriteLine("++++++++++++++++++++++++++++++++");

    //        c2.collegeId = 2;
    //        c2.collegeName = "Pillai College";
    //        c2.city = "Mumbai";
    //        c2.grade = "A";

    //        Console.WriteLine("After Updation of College 2 Details");
    //        Console.WriteLine("++++++++++++++++++++++++++++++++");

    //        c2.DisplayCollegeDetails();
    //        c1.DisplayCollegeDetails();
    //    }
    //}

    //==============================================================================================================================================


    //public class Watch
    //{
    //    public string brand = "Titan";
    //    public decimal price = 5000;
    //    public string color = "Black";
    //    public int warranty = 2;

    //    public decimal ApplyDiscount(int percent)
    //    {
    //        price = price - (price * percent / 100);
    //        return price;
    //    }

    //    public void DisplayWatchDetails()
    //    {
    //        Console.WriteLine($"Brand: {brand}");
    //        Console.WriteLine($"Color: {color}");
    //        Console.WriteLine($"Price: {price}");
    //        Console.WriteLine($"Warranty: {warranty} Years");
    //        Console.WriteLine();
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Watch w1 = new Watch();
    //        Watch w2 = new Watch();

    //        Console.WriteLine();

    //        w1.DisplayWatchDetails();
    //        w2.DisplayWatchDetails();

    //        Console.WriteLine("++++++++++++++++++++++++++++++++");

    //        w2.brand = "Fastrack";
    //        w2.color = "Blue";
    //        w2.price = 7000;
    //        w2.warranty = 3;

    //        Console.WriteLine("After Updation of Watch 2 Details");
    //        Console.WriteLine("++++++++++++++++++++++++++++++++");

    //        w2.DisplayWatchDetails();
    //        w1.DisplayWatchDetails();

    //        Console.WriteLine("++++++++++++++++++++++++++++++++");
    //        Console.WriteLine($"Price after Discount: {w1.ApplyDiscount(10)}");
    //        w1.DisplayWatchDetails();
    //    }
    //}

    //===============================================================================================================================================









    //==========================================================================================================================================================
    //Constructor
    //---------HomeWork-----------------------------------------------------------------------------------------------------------------------------------------


    //using of Constructor


    public class Program
    {
        public static void Main()
        {
            //1.Person

            //Person p = new Person();
            //p.DisplayPersonDetails();


            /////2.Student
            //Student s = new Student();
            //s.DisplayStudent();
            //Console.WriteLine(s.IsPass());


            ////3.college
            //College college = new College();
            //college.DisplayCollage();



            ////4.Mobile
            //Mobile mobile = new Mobile();
            //mobile.ApplyDiscount(15);
            //mobile.DisplayMobile();


            ////5.Laptop
            //Laptop lp= new Laptop();
            //lp.DisplayLaptop();


            ////6.Table
            //Table t = new Table();
            //t.DisplayTable();


            ////7.Product
            //Product prod=new Product();
            //prod.DisplayProduct();


            ////8.Customer
            //Customer c = new Customer();
            //c.DisplayCustomer();


            ////9.Invoice
            //Invoice invoice = new Invoice();
            //invoice.DisplayInvoice();


            ////10.Watch 
            //Watch W = new Watch();
            //W.DisplayWatch();




        }
    }














}