using System;

namespace NCC_Lab_Krisha
{
    public delegate void Notify(); // delegate
    public class Process
    {
        public event Notify ProcessCompleted; // event
        public void StartProcess()
        {
            Console.WriteLine("\tProcess Started!");
            Console.WriteLine("\tprocessing .......");
            OnProcessCompleted();//raises an even
        }
        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke(); //'?.' is null-conditional operator
        }
    }
     class EventDemo
     {
        public static void Main()
        {
            Process pl = new Process();
            pl.ProcessCompleted += pl_ProcessCompleted; // register with an event
            Console.WriteLine("Process Status:");
            pl.StartProcess();
            Console.WriteLine("\nLab No.: 9(f)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
        // event handler
        public static void pl_ProcessCompleted()
        {
            Console.WriteLine("\tProcess Completed!");
        }
     }
}
