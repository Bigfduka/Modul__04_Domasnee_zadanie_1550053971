using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Cs.Model
{
    partial class Car
    {
        static int wheel { get; set; }
        static  string color { get; set; }

        private int capacity { get; set; }
        private int price { get; set; }
        private int speed { get; set; }
        private int Weight { get; set; }
        private string model { get; set; }


        static Car()
        {
            wheel = 4;
            color = "black";
        }
        public Car()
        { }
        public Car(int capacity)
        {
            this.capacity = capacity;
        }
        public Car(int capacity, int price)
        {
            this.capacity = capacity;
            this.price = price;

        }
        public Car(int capacity, int price,int speed)
        {
            this.capacity = capacity;
            this.price = price;
            this.speed = speed;
        }
        public Car(int capacity, int price, int speed, int Weight)
        {
            this.capacity = capacity;
            this.price = price;
            this.speed = speed;
            this.Weight = Weight;

        }
        public Car(int capacity, int price, int speed, int Weight, string model)
        {
            this.capacity = capacity;
            this.price = price;
            this.speed = speed;
            this.Weight = Weight;
            this.model = model;

        }



        static  void Model(ref  string model)
        {
            return;
        }
        static void weight( int Weight)
        {

            return;
        }
        static void Price(int price)
        {
            return;
        }
        static void Speed(int speed)
        {
            return;
        }
       
    }



}
