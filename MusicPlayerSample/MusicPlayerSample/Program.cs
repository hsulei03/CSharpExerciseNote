using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerSample
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

        public void Play(Piano piano)
        {
            piano.Go(_content);
        }

        //註利用方法的多載，增加第二種樂器
        public void Play(Saxophone saxophone)
        {
            saxophone.Go(_content);
        }
    }

    public class Piano
    {
        public void Go(string content)
        {
            Console.WriteLine($"鋼琴演奏{content}");
        }
    }

    public class Saxophone
    {
        public void Go(string content)
        {
            Console.WriteLine($"薩克斯風演奏{content}");
        }
    }

    //要再多怎麼辧？再接著寫嗎？
}
