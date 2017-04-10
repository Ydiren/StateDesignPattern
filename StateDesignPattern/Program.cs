using System;

namespace StateDesignPattern
{
    /// <summary>
    /// Example of State Design Pattern taken from https://thomasjaeger.wordpress.com/2012/12/13/the-state-design-pattern-vs-state-machine-2/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Device
            Device device = new Device();

            // Check the status of the device
            Console.WriteLine("The device mode is " + device.Mode);

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Let's do some actions on the device
            Console.WriteLine("Trying to open the door...");
            device.Door.Open();

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Let's break the door
            Console.WriteLine("Breaking the door...");
            device.Door.Break();

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Fix the door
            Console.WriteLine("Fixing the door...");
            device.Door.Fix();

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Try to lock the door
            Console.WriteLine("Trying to lock the door...");
            device.Door.Lock();

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Try to open the door
            Console.WriteLine("Trying to open the door...");
            device.Door.Open();

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Try to unlock the door
            Console.WriteLine("Trying to unlock the door...");
            device.Door.Unlock();

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Switch to Test Configuration
            Console.WriteLine("Trying to switch to test configuration...");
            device.Configuration.SetTestConfiguration();

            // Check the status of the device
            Console.WriteLine("The configuration is " + device.Configuration);

            // Break the door under Test Configuration
            Console.WriteLine("Trying to break the door under test configuration...");
            device.Door.Break();

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Switch to Production Configuration
            Console.WriteLine("Trying to switch to production configuration...");
            device.Configuration.SetProductionConfiguration();

            // Check the status of the device
            Console.WriteLine("The configuration is " + device.Configuration);

            // Break the door under production Configuration
            Console.WriteLine("Trying to break the door under production configuration...");
            device.Door.Break();

            // Check the status of the device
            Console.WriteLine("The door is " + device.Door.DoorState);

            // Power down
            Console.WriteLine("Trying to power down the device...");
            device.Mode.SetModeToPowerDown();

            // Check the status of the device
            Console.WriteLine("The device mode is " + device.Mode);

            Console.ReadLine();
        }
    }
}