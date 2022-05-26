using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IPlayerManage
    {
        void Play();
        void Stop();
    }


    public class AudioManage : IPlayerManage
    {
        public void Play()
        {
            Console.WriteLine("Playing Audio");
        }

        public void Stop()
        {
            Console.WriteLine("Playing Video");
        }
    }

    public class VideoManage : IPlayerManage
    {
        public void Play()
        {
            Console.WriteLine("Playing Video");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Video");
        }
    }

    public class GameManage : IPlayerManage
    {
        public void Play()
        {
            Console.WriteLine("Playing Game");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Game");
        }
    }
}
