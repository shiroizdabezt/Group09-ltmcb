using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group9
{
    internal class RoomCode
    {
        public string roomCode { get; set; }
        private static string error = "Room code doesn't exist!";
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        public static bool IsEqual(RoomCode room1, RoomCode room2)
        {
            if (room1 == null || room2 == null) return false;
            if (room1.roomCode != room2.roomCode)
            {
                error = "Wrong room code";
                return false;
            }
            return true;
        }
    }
}
