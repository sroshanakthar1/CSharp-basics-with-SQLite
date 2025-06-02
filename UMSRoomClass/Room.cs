using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSRoomClass
{
    internal class Room
    {
        private string roomID;
        private string roomName;
        private string roomType;

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }
        public Room(string id, string name, string type)
        {
            RoomID = id;
            RoomName = name;
            RoomType = type;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Room: {RoomName}, Type: {RoomType}");
        }
    }
}
