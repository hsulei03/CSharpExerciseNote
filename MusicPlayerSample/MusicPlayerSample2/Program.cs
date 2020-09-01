using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new MusicPlayer("告白氣球");
            var piano = new Piano();
            player.Play(piano);

            //註利用方法的多載，增加第二種樂器
            var saxophone = new Saxophone();
            player.Play(saxophone);


            //要再多怎麼辧？再接著寫嗎？
            Console.ReadLine();
        }
    }


    public class MusicPlayer
    {
        private string _content;

        //建構式
        public MusicPlayer(string content)
        {
            _content = content;
        }

        //搭配介面即可
        public void Play(IMusicInstrument instrument)
        {
            instrument.Go(_content);
        }

        //public void Play(Saxophone saxophone)
        //{
        //    saxophone.Go(_content);
        //}
    }



    //兩個類別使用的方法都一樣，改幅介面取代
    public interface IMusicInstrument
    {
        void Go(string content);
    }

    internal class Piano : IMusicInstrument
    { 
        //實作介面
        public void Go(string content)
        {
            Console.WriteLine($"鋼琴演奏{content}");
        }
    }

    internal class Saxophone:IMusicInstrument
    {
        //實作介面
        public void Go(string content)
        {
            Console.WriteLine($"薩克斯風演奏{content}");
        }
    }

}
