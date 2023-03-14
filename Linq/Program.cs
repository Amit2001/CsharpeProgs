using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Linq{
    class LinqProgram{

    static void Main(string [] args){

     //string[] dogs = {"Leo sharma","Tipsy","Jackey sharma","Oreo","browny-The Stray Dog","Jackey-The Stray"};
     //var items = from item in dogs where item.Contains("sharma") orderby item descending select item;
    //foreach(string item in items){
    //    Console.Write(item+" ");
    //
    // Console.ReadLine();
    
    queryIntArray();
    queryArrayList();
    queryCollection();
    
    
    }

    static void queryIntArray(){
        int [] array = {5,10,15,20,25,30,35,40};
        var gt20 = from item in array where item>20 orderby item select item;
        Console.WriteLine("Data type of this var is : "+ gt20.GetType());
        int[] gt20Array = gt20.ToArray();
        foreach(int item in gt20Array){
            Console.Write(item+" ");
        } 
    }

    static void queryArrayList(){
        ArrayList studentList = new ArrayList(){
            new Student{Name="Amit",Class="4",Age=21},
            new Student{Name="Nancy",Class="9",Age=26},
            new Student{Name="Mansi",Class="7",Age=25},
            new Student{Name="Shubham",Class="8",Age=26},
            new Student{Name="Riya",Class="5",Age=23},
            new Student{Name="Ashish",Class="4",Age=22},
            new Student{Name="Shivani",Class="1",Age=18}
        };

        var famStudentEnum = studentList.OfType<Student>();
        var famStudents = from item in famStudentEnum where item.Age>22 orderby item.Name ascending select item;

        foreach(var item in famStudents){
            Console.Write(item.Name+"------");
        } 

    }


    static void queryCollection(){
        var animalList = new List<Animal>(){
             new Animal{Name="German Shepherd",Height=25,Weight=77},
             new Animal{Name="Chihuahua",Height=7,Weight=4},
             new Animal{Name="Saint Bernard",Height=30,Weight=200}
        };

        var bigDogs = from dog in animalList where (dog.Height>25 && dog.Weight>70) orderby dog.Name select dog;
        foreach(Animal dog in bigDogs){
            Console.Write(dog.Name+" have height "+dog.Height+" and have weight "+dog.Weight);
        } 


    }


}

   

    public class Student{
        public string Name { get; set; }
        public string Class { get; set; }

        public int Age { get; set; }
    } 

    public class Animal{
        public string Name { get; set; }
        public int Height { get; set; }

        public int Weight { get; set; }
    } 


}