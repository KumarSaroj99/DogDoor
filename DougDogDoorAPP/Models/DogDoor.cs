using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougDogDoorAPP.Models
{
    internal class DogDoor
    {
        static DogDoor _instance;
        private bool open;

        private DogDoor()
        {
            this.open = false;
        }
        public static DogDoor GetInstance()
        {
            if( _instance == null )
                _instance = new DogDoor();
            return _instance;
        }

        public void Open()
        {
            
            open = true;
            // Automatically close the door after 5 seconds
            Timer timer = new Timer(Close, null, 5000, Timeout.Infinite);
        }

        public void Close(object state = null)
        {
            
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }
    }
}
