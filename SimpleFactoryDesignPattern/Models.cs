﻿using System;

namespace SimpleFactoryDesignPattern
{
    public abstract class Vehicle
    {
        public abstract void DoSomeWork();
    }

    public class Car : Vehicle
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("Car is doing some work");
        }
    }

    public class Motocicle : Vehicle
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("Motocicle is doing some work");
        }
    }
}