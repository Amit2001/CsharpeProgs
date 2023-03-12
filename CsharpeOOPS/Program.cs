using System;
namespace OOPS{
    class CsharpeOOPS{
        static void Main(string [] args){
            Triangle triangle = new Triangle();
            Console.WriteLine("Enter Length Of Triangle : ");
            triangle.SetLength(float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Breadth Of Triangle : ");
            triangle.SetBreath(float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Height Of Triangle : ");
            triangle.SetHeight(float.Parse(Console.ReadLine()));


            Console.Write("Area Of triangle  : ");
            Console.WriteLine(triangle.Area());
            Console.Write("Perimeter Of triangle  : ");
            Console.WriteLine(triangle.Perimeter());
                
        }
        
    }

    class Triangle{
        private float length,breath,height;
        
        public void SetLength(float length){
            this.length = length;
        }
        public void SetBreath(float breath){
            this.breath = breath;
        }
        public void SetHeight(float height){
            this.height = height;
        }

        public float GetHeight(){
            return height;
        }

        public float GetLength(){
            return length;
        }

        public float GetBreath(){
            return breath;
        }


        public float Area(){
            return length*breath*height;
        }

        public float Perimeter(){
            return length+breath+height;
        }
    }
}