using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample001
{
    public class Parent  //父類別
    {
        public virtual string Name
        {
            get
            {
                return "父類別";
            }
            set
            {
                Name = value;
            }
        }

        public virtual void PrintClassName()
        {
            Console.WriteLine("父類別 " + Name);
        }
    }

    //=================================================================//
    public class Derivative : Parent
    {
        public override string Name       
        {
            get
            {
                return "(衍生)子類別";
            }
            set
            {
                Name = value;
            }
        }
    
        public override void PrintClassName()
        {
            Console.WriteLine("(衍生)子類別 " + Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            p1.PrintClassName();

            //Derivative d2 = new Derivative();

            Parent d2 = new Derivative();
            //沒有加virtual and override 會導致不同的結果
            //確保結果正確的話
            //1.父類別的屬性及方法加上了virtual修飾詞
            //2.子類別的屬性及方法加上了override的修飾詞

            d2.PrintClassName();

            Console.ReadLine();
        }
    }
}
