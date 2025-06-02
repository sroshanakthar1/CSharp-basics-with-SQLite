namespace UMSRoomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room lab1 = new Room("R001", "Lab 1", "Lab");
            Room hallA = new Room("R002", "Hall A", "Hall");

            // Display room details
            lab1.DisplayDetails();
            hallA.DisplayDetails();
        }
    }
}
