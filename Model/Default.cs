using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPS.Model
{
    //public class Person
    //{
    //    //Properties
    //    private int age;
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Gender { get; set; }
    //    public string City { get; set; }

    //    //Default Constructor
    //    public Person()
    //    {
    //        Name = "Amit";
    //        Age = 25;
    //        Gender = "Male";
    //        City = "Pune";

    //    }
    //    //Parameterized Constructor
    //    public void DisplayPersonDetails()
    //    {
    //        Console.WriteLine($"Person[Name:{Name}, Age:{Age},Gender:{Gender},City:{City}");
    //    }
    //    //ToString() Method
    //    public override string ToString()
    //    {
    //        return $"Person[Name:{Name}, Age: {Age},Gender: {Gender},City: {City}]";
    //    }

    //}

    ////==================================================================================================================================

    //public class Student
    //{
    //    private int marks;
    //    public int RollNo { get; set; }
    //    public string Name { get; set; }
    //    public int Marks { get; set; }
    //    public string Course { get; set; }

    //    // Default constructor
    //    public Student()
    //    {
    //        RollNo = 101;
    //        Name = "geet";
    //        Marks = 75;
    //        Course = "BCA";
    //    }
    //    public void DisplayStudent()
    //    {
    //        Console.WriteLine($"Student[RollNO :{RollNo}, Name :{Name}, Marks :{Marks},Course:{Course}]");

    //    }
    //    public bool IsPass() => Marks > 36;

    //    public override string ToString()
    //    {
    //        return $"Student [RollNo:{RollNo}, Name:{Name}, Course:{Course}, Marks:{Marks}]";
    //    }

    //}


    //===================================================================================================================================


    //public class College
    //{
    //    public int collegeId { get; set; }
    //    public string collegeName { get; set; }
    //    public string city { get; set; }
    //    public string grade { get; set; }

    //    public College()
    //    {
    //        collegeId = 101;
    //        collegeName = "DPU";
    //        city = "pune";
    //        grade = "A";

    //    }
    //    public void DisplayCollage()
    //    {
    //        Console.WriteLine($"Collage[CollageId:{collegeId},CollegeName:{collegeName},city:{city},grade{grade}]");
    //    }
    //    public override string ToString()
    //    {
    //        return $"College[CollageId:{collegeId},CollegeName: {collegeName},city: {city},grade{grade}]";
    //    }
    //}



    //====================================================================================================================================================================================================================================================

    //public class Mobile
    //{
    //    public String mobileBrand {  get; set; }
    //    public decimal price {  get; set; }
    //    public string color {  get; set; }
    //    public int warranty {  get; set; }
    //    decimal  discountprice;

    //    public decimal ApplyDiscount(int percent)
    //    {
    //        discountprice = price - (price * (decimal)(percent / 100));
    //        return discountprice;
    //    }
    //    public Mobile()
    //    {
    //        mobileBrand = "iphone";
    //        price = 112340;
    //        color = "white";
    //        warranty = 1;

    //    }
    //    public void DisplayMobile()
    //    {
    //        Console.WriteLine($"Mobile[mobileBrand:{mobileBrand},price:{price},color:{color},warrenty:{warranty},Discountprice:{discountprice}]");
    //    }
    //    public override string ToString()
    //    {
    //        return $"Mobile[mobileBrand:{mobileBrand},price:{price},color:{color},warrenty:{warranty},Discountprice:{discountprice}]";
    //    }


    //}


    ///===================================================================================================================================================================================================================================

    //public class Laptop
    //{
    //    public string LpBrand {  get; set; }
    //    public int ram {  get; set; }
    //    public int storage {  get; set; }
    //    public decimal price {  get; set; }
    //    public int warranty {  get; set; }


    //    public Laptop()
    //    {
    //        LpBrand = "HP";
    //        ram = 8;
    //        storage = 512;
    //        price = 55000;
    //        warranty = 1;

    //    }
    //    public void DisplayLaptop()
    //    {
    //        Console.WriteLine($"Laptop[LpBrand:{LpBrand},ram:{ram},storage:{storage},price:{price},warranty:{warranty}]");

    //    }
    //    public override string ToString()
    //    {
    //        return $"Laptop[LpBrand:{ LpBrand},ram: { ram},storage: { storage},price: { price},warranty: { warranty}]";

    //    }

    //}

    ////==============================================================================================================================================================================================================================



    //public class Table
    //{
    //    public double length { get; set; }
    //    public double width {  get; set; }
    //    public string material {  get; set; }

    //    public Table()
    //    {
    //       length = 5.5;
    //        width = 3.0;
    //        material = "wood";
    //    }
    //    public void DisplayTable()
    //    {
    //        Console.WriteLine($"Table[length:{length},width:{width},material:{material}]");
    //    }
    //    public override string ToString()
    //    {
    //        return $"Table[length:{length},width:{width},material:{material}]";
    //    }


    //}

    //============================================================================================================================================



    //public class Product
    //{
    //    public int Id {  get; set; }
    //    public string ProdName {  get; set; }
    //    public decimal ProdPrice {  get; set; }

    //    public Product()
    //    {
    //        Id = 1;
    //        ProdName = "Headphone";
    //        ProdPrice = 1200;
    //    }
    //    public void DisplayProduct()
    //    {
    //        Console.WriteLine($"Product[Id:{Id},prodName:{ProdName},prodPrice:{ProdPrice}]");
    //    }
    //    public override string ToString()
    //    {
    //        return $"Product[Id:{{Id}},prodName:{{ProdName}},prodPrice:{{ProdPrice]";
    //    }
    //}


    //==========================================================================================================================================================


    //public class Customer
    //{
    //    public int Id {  get; set; }
    //    public string CustomerName {  get; set; }
    //    public string City {  get; set; }

    //    public Customer()
    //    {
    //        Id = 11;
    //        CustomerName = "shivtej";
    //        City = "pune";
    //    }
    //    public void DisplayCustomer()
    //    {
    //        Console.WriteLine($"Customer[id:{Id},customerName:{CustomerName},city:{City}]");
    //    }
    //    public override string ToString()
    //    {
    //        return $"Customer[id:{Id},customerName:{CustomerName},city:{City}]";
    //    }

    //}

    //==============================================================================================================================================================

    //public class Invoice
    //{
    //    public int id {  get; set; }
    //    public string customerName {  get; set; }
    //    public decimal amount {  get; set; }
    //    public string invoiceDate {  get; set; }

    //    public Invoice()
    //    {
    //        id = 11;
    //        customerName = "shivtej";
    //        amount = 12254;
    //        invoiceDate = "26-04-2025";
    //    }
    //    public void DisplayInvoice()
    //    {
    //        Console.WriteLine($"Invoice[id:{id},customerName:{customerName},amount:{amount},invoiceDate:{invoiceDate}]");
    //    }
    //    public override string ToString()
    //    {
    //        return $"Invoice[id:{id},customerName:{customerName},amount:{amount},invoiceDate:{invoiceDate}]";
    //    }

    //}



    //==============================================================================================================================================================================


    //public class Watch
    //{
    //    public string brand {  get; set; }
    //    public decimal price {  get; set; }
    //    public string color {  get; set; }
    //    public int warranty {  get; set; }

        
    //    public Watch()
    //    {
    //        brand = "Titan";
    //        price = 5000;
    //        color = "Black";
    //        warranty = 2;

    //    }

    //    public void DisplayWatch()
    //    {
    //        Console.WriteLine($"Watch[brand:{brand},price:{price},color:{color},warranty:{warranty}]");
    //    }
    //    public override string ToString()
    //    {
    //        return $"Watch[brand:{brand},price:{price},color:{color},warranty:{warranty}]";
    //    }
    //}
    









}





















