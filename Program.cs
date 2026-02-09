using OOPS.Model;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
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


    //public class Program
    //{
    //    public static void Main()
    //    {
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



    //    }
    //}

    //========================================================================================================================================================================================
    // =========Homework=============================================================================================================================================================
    //3-feb-2026

    /// <summary>
    /// PART 1: BASIC CONSTRUCTORS
    /// </summary>

    // //Q1.Default Constructor
    // //Create a class AdminUser with properties AdminId, Name, and IsActive.
    // //The default constructor should set IsActive = true.
    ////Create an object and print the IsActive value


    //  class AdminUser
    // {
    //     public int Adminid {  get; set; }
    //     public string Name {  get; set; }
    //     public bool IsActive { get; set; }


    //     public AdminUser()
    //     {
    //         Adminid = 101;
    //         Name = "mrunalini";
    //         IsActive = true;
    //     }
    //     public override string ToString()
    //     {
    //         return $" IsActive:{IsActive}";
    //     }
    //     public class program
    //     {
    //         public static void Main(string[] args)
    //         {
    //             AdminUser m = new AdminUser();
    //             Console.WriteLine(m);
    //         }
    //     }
    // }

    //==========================================================================================================================================================================

    ////Q2.Parameterized Constructor
    //// Create a class LoginSession with AdminId and LoginTime.
    //// Initialize values using parameterized constructor and print login details


    //class LoginSession
    //{
    //    public int AdminId {  get; set; }
    //    public DateTime LoginTime { get; set; } 

    //    public LoginSession(int adminId, DateTime loginTime)
    //    {
    //        AdminId = adminId;
    //        LoginTime = loginTime;
    //    }
    //    public override string ToString()
    //    {
    //        return $"AdminId:{AdminId},LoginTime:{LoginTime}";
    //    }

    //    public class program
    //    {
    //        public static void Main()
    //        {
    //            LoginSession s = new LoginSession(101, new DateTime(2026,2,3,13,53,0));
    //            Console.WriteLine(s);
    //        }
    //    }
    //}

    //==================================================================================================================================================================

    /// PART 2: OVERLOADING & this KEYWORD

    ////Q3.Constructor Overloading
    ////Create a class UserProfile with Name, Age, and City.
    ////Create three constructors:
    ////1. Name only
    ////2. Name and Age
    ////3. Name, Age, and City
    ////Create objects using all constructors and print details.

    //class UserProfile
    //{
    //    public string Name {  get; set; }
    //    public int age { get; set; }    
    //    public string city {  get; set; }

    //    public UserProfile(string name)
    //    {
    //        this.Name = name;
    //    }
    //    public UserProfile(string name, int age)
    //    {
    //        this.Name=name;
    //        this.age = age;
    //    }
    //    public UserProfile(string name, int age, string city) 
    //    {
    //        this.Name = name;
    //        this.age = age;
    //        this.city = city;
    //    }
    //    public override string ToString()
    //    {
    //       return $"Name:{Name},Age:{age},City:{city}";
    //    }
    //    public class program()
    //    {
    //        public static void Main()
    //        {
    //            UserProfile U1 = new UserProfile("Gayatri");
    //            UserProfile U2 = new UserProfile("Gayatri", 21);
    //            UserProfile U3 = new UserProfile("Gayatri", 21, "Akluj");
    //            Console.WriteLine(U1);
    //            Console.WriteLine(U2);
    //            Console.WriteLine(U3);

    //        }
    //    }
    //}


    //===============================================================================================================================================================================

    // Q4.Constructor Chaining using this
    // Modify UserProfile constructors so that:- Second constructor calls first using this- Third constructor calls second using this
    //Avoid duplicate code.

    //class User
    //{
    //    public string UserName { get; set; }
    //    public string Email { get; set; }
    //    public int Age { get; set; }
    //    public int UserId { get; set; }

    //    //default Constructor
    //    public User()
    //    {
    //        UserName = "";
    //        Email = "";
    //        Age = 0;
    //        UserId = 0;
    //    }
    //    public User (string username) : this()
    //    {
    //        UserName = username;
    //    }
    //    public User (string username,string email):this()
    //    {
    //        Email = email;
    //    }
    //    public User (string username,string email,int age):this()
    //    {
    //        Age=age;    
    //    }
    //    public User (string username,string email,int age,int userId):this()
    //    {
    //        UserId = userId;
    //    }
    //    public override string ToString()
    //    {
    //        return $"User[UserName:{UserName},Email:{Email},Age:{Age},UserId:{UserId}]";
    //    }
    //}
    //class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        User u1=new User("Gayatri");
    //        Console.WriteLine(u1);
    //        User u2 = new User("Gayatri", "gayatri@gemail.com");
    //        Console.WriteLine(u2);
    //        User u3 = new User("Gayatri", "gayatri@gemail.com", 21);
    //        Console.WriteLine(u3);
    //        User u4 = new User("Gayatri", "gayatri@gemail.com", 21, 101);
    //        Console.WriteLine(u4);

    //    }
    //}

    //=============================================================================================================================================================================

    //PART 3: INHERITANCE & base KEYWORD

    //Q5.Constructor Chaining using base
    //Create a base class Admin with constructor accepting Name.
    //Create derived class SuperAdmin with constructor accepting Name and PermissionLevel.
    //Use base keyword to call parent constructor and print details

    //class Admin
    //{
    //    public string Name { get; set; }
    //    public Admin (string name)
    //    {
    //        Name = name;
    //        Console.WriteLine("Admin Called");
    //    }
    //}
    //class SuperAdmin
    //{
    //    public int PermissionLevel { get; set; }
    //    public SuperAdmin(string  name, int permissionLevel)
    //    {

    //    }
    //}
    //==============================================================================================================================================================================

    //===HomeWork======================================================================================================================================================================
    //4-feb-2026

    // Exercise 1: Identify Static vs Instance
    //Given a Calculator class with Add and Multiply methods.Decide whether these methods should be static or instance methods and explain why.

    //public class Calculator
    //{
    //    public static int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //    public static int Multiply(int x, int y)
    //    {
    //        return x * y;
    //    }
    //}
    //public class Program()
    //{
    //    public static void Main(string[] args)
    //    {
    //        int sum = Calculator.Add(12, 22);
    //        int product = Calculator.Multiply(12, 32);
    //        Console.WriteLine(product);
    //        Console.WriteLine(sum);
    //    }
    //}

    //===========================================================================================================================================================================

    // Exercise 2: Convert Static to Instance
    //A User class has a Name property.Modify a static greeting method so that it uses the user's name.
    //Decide whether the method should be static or instance.

    //public class User
    //{
    //    public string Name { get; set; }

    //    public string Greeting()
    //    {
    //        return $"Hello {Name}";
    //    }
    //}
    //public class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        User u1 = new User();
    //        u1.Name = "Gayatri";

    //        User u2 = new User();
    //        u2.Name = "Amit";

    //        Console.WriteLine(u1.Greeting()); 
    //        Console.WriteLine(u2.Greeting());  
    //    }
    //}

    //===========================================================================================================================================================================

    // Exercise 3: Utility vs Behavior
    //An EmailService class has methods for sending email and validating email format.Identify which
    //method should be static and which should be instance, with reasoning    

    //public class EmailServices
    //{

    //    public static bool EmailValidation(string email)
    //    {
    //        bool isValid = email.Contains("@");

    //        return isValid;
    //    }

    //    public void SendEmail(string email, string subject, string body)
    //    {
    //        if (EmailValidation(email) == true)
    //        {
    //            Console.WriteLine($"To : {email}");
    //            Console.WriteLine($"Subject : {subject}");
    //            Console.WriteLine($"Body : {body}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Email is Invalid");
    //        }
    //    }
    //}
    //public class Program
    //{
    //    public static void Main(string[]args)
    //    {
    //        EmailServices email = new EmailServices();

    //        string emailId = "gayatripise2604@gmail.com";
    //        string subject = "Project Update";
    //        string body = "This is a simple message about the project update.";

    //        email.SendEmail(emailId, subject, body);

    //    }
    //}


    //===========================================================================================================================================================================
    // Exercise 4: Static Variable Counter
    //A class contains a static counter incremented in the constructor.Create multiple objects and predict the output

    //public class CounterDemo
    //{
    //    public static int counter = 0;

    //    public CounterDemo()
    //    {
    //        counter++;
    //    }
    //    public class program
    //    {
    //        public static void Main(string[] args)
    //        {
    //            CounterDemo c1 = new CounterDemo();
    //            CounterDemo c2 = new CounterDemo();
    //            CounterDemo c3 = new CounterDemo();
    //            Console.WriteLine("Counter value:" + CounterDemo.counter);

    //        }
    //    }

    //}

    //===========================================================================================================================================================================================
    //Exercise 5: Fix the Compilation Error
    //A static method tries to access an instance variable.Identify the error and fix it using two different approaches







    //==================================================================================================================================================================================
    //6-feb-2026
    ///inheritance
    ///

    using System;
    using System.Net;

    //public class P : Object
    //{
    //    public void M1()
    //    {
    //        Console.WriteLine("p");
    //    }
    //}

    //public class C : P
    //{
    //    // C class automatically inherits M1() from P class
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        // Child class object
    //        C ob1 = new C();
    //        ob1.M1();   // Inherited method call


    //    }
    //}

    //=======================================================================================================================================================================================

    // Upcasting Example
    //public class P : Object
    //{
    //    public void A1()
    //    {
    //        Console.WriteLine("abc");
    //    }

    //}
    //public class C : P
    //{
    //    public void A2()
    //    {
    //        Console.WriteLine("xyz");
    //    }
    //}
    //public class Program
    //{
    //    public static void Main()
    //    {

    //        // Upcasting
    //        P ob2 = new C();   // Parent reference, Child object
    //        ob2.A1();         // Parent method accessible
    //    }
    //}

    //=================================================================================================================================================================================================

    /// <summary>
    /// Constructor Chaining
    /// </summary>
    //public class Bird : Object
    //{
    //    public Bird()
    //    {
    //        Console.WriteLine("Hii Sourabh");
    //    }
    //}
    //public class Sparrow : Bird
    //{
    //}
    //public class SparrowChild : Sparrow
    //{
    //    public SparrowChild() : base()
    //    {
    //        Console.WriteLine("Pawan ji");
    //    }
    //}
    //public class program
    //{
    //    public static void Main(string[]args)
    //    {
    //        Bird sparrow = new SparrowChild();

    //    }
    //}

    //==========================================================================================================================================



    //public class Bird : Object
    //{
    //    public Bird()
    //    {
    //        Console.WriteLine("Hii Sourabh");
    //    }
    //}

    //public class Sparrow : Bird
    //{
    //    public Sparrow(int a)
    //    {
    //        Console.WriteLine("Gauriji");
    //    }
    //}

    //public class SparrowChild : Sparrow
    //{
    //    public SparrowChild() : base(10)
    //    {
    //        Console.WriteLine("Hello World");
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Bird sparrow = new SparrowChild();   
    //    }
    //}



    //============================================================================================================================================================================================================

    // //7-feb-2026
    //  //homework

    ////Circle,Cylinder

    //public  class Circle //parent class
    //{
    //    public double Radius {  get; set; }
    //    public string Color {  get; set; }

    //    public Circle()
    //    {
    //        Radius = 1.5;
    //        Color = "Red";
    //    }
    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //        Color = "Red";
    //    }
    //    public Circle( double radius,string color)
    //    {
    //        Radius = radius;
    //        Color = color;
    //    }
    //    public double Area()
    //    {
    //        return Math.PI* Radius*Radius;
    //    }
    //}
    //public class Cylinder:Circle //child class
    //{
    //    public double Height { get; set; }

    //    public Cylinder():base()
    //    {
    //        Height = 1.5;
    //    }
    //    public Cylinder (double radius,double height):base(radius)
    //    {
    //        Height = height; 
    //    }
    //    public Cylinder (double radius, string color,double height):base(radius,color)
    //    {
    //        Height = height;
    //    }
    //    public double Volume()
    //    {
    //        return base.Area() * Height;
    //    }
    //}
    //public class program
    //{
    //    public static void Main(string[]args)
    //    {
    //        Cylinder ob = new Cylinder(2.0, "Gray", 4.0);

    //        Console.WriteLine(ob);        
    //        Console.WriteLine(ob.Area()); 
    //        Console.WriteLine(ob.Volume());

    //    }
    //}

    //==========================================================================================================================================================================

    ////Person,Student,staff

    //public class Person
    //{
    //    public string Name { get; set; }
    //    public String Address { get; set; }


    //    public Person (string name,string address)
    //    {
    //        Name = name;
    //        Address = address;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Person [name { Name}, address  { Address}]";
    //    }      
    //}
    //public class Student : Person
    //{
    //    public string Program { get; set; }
    //    public int Year { get; set; }
    //    public double Fee { get; set; }

    //    public Student (string name, string address,string program, int year, double fee)  : base(name, address)
    //    {
    //        Program = program;
    //        Year = year;
    //        Fee = fee;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Student [{base.ToString()}, program  {Program}, year {Year}, fee {Fee}]";
    //    }
    //}
    //public class Staff : Person
    //{
    //    public string School { get; set; }
    //    public double Pay { get; set; }

    //    public Staff(string name, string address,
    //                 string school, double pay)
    //        : base(name, address)
    //    {
    //        School = school;
    //        Pay = pay;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Staff[{base.ToString()},school {School}, pay  {Pay}]";
    //    }
    //}
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Student st = new Student("Shivtej","Pune","Computer Science", 3, 54000);
    //        Staff sf = new Staff("Rohan", "Mumbai", "xyz School", 34000);


    //        Console.WriteLine(st);
    //        Console.WriteLine(sf);
    //    }
    //}

    //=============================================================================================================================================================================================

    ////point2D,point3D

    public class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2D()
        {
            X = 0.0f;
            Y = 0.0f;
        }
        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }
        
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
    public class Point3D : Point2D
    {
        public float Z { get; set; }

        public Point3D() : base()
        {
            Z = 0.0f;
        }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            Z = z;
        }
       
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

    }
    class Program
    {
        public static void Main()
        {
            Point2D p2 = new Point2D(2, 6);
          
            Console.WriteLine(p2);
           
            Point3D p3 = new Point3D(4, 2, 5);
         
            Console.WriteLine(p3);
           
        }
    }


    //=====================================================================================================================================================================================================






}










