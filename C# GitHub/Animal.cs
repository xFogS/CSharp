using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public virtual void Name() { Console.WriteLine("No Name"); }
        public virtual void Voice() { Console.WriteLine("~~~~~~"); }
    }

    public class OnTheEarth : Animal {}
    public sealed class Cat : OnTheEarth
    {
        public override void Name() { Console.WriteLine("Cat"); }
        public override void Voice() { Console.WriteLine("Mau mau"); }
    }
    public sealed class Dog : OnTheEarth 
    {
        public override void Name() { Console.WriteLine("Dog"); }
        public override void Voice() { Console.WriteLine("Gaw Gaw"); }
    }

    public sealed class Hamster : OnTheEarth 
    {
        public override void Name() { Console.WriteLine("Hamster"); }
        public override void Voice() { base.Voice(); }
    }

    public sealed class HermitСrab : OnTheEarth
    {
        public override void Name() { Console.WriteLine("Hermit Сrab"); }
        public override void Voice() { base.Voice(); }
    }

    public class Bird : Animal {}
    public sealed class Eagle : Bird
    {
        public override void Name() { Console.WriteLine("Eagle"); }
        public override void Voice() { Console.WriteLine("ia ia ia ia"); }
    }

    public sealed class Parrot : Bird 
    {
        public override void Name() { Console.WriteLine("Parrot"); }
        public override void Voice() { Console.WriteLine("kaka ka kaka ka"); }
    }
    public sealed class Magpie : Bird
    {
        public override void Name() { Console.WriteLine("Magpie"); }
        public override void Voice() { Console.WriteLine("kakaka"); }
    }
    public sealed class Swallow : Bird
    {
        public override void Name() { Console.WriteLine("Swallow"); }
        public override void Voice() { Console.WriteLine("cwi cwi cwi"); }
    }
    public class Fish : Animal {}
    public sealed class Crab : Fish 
    {
        public override void Name() { Console.WriteLine("Crab"); }
        public override void Voice() { base.Voice(); }
    }
    public sealed class Jellyfish : Fish
    {
        public override void Name() { Console.WriteLine("Jellyfish"); }
        public override void Voice() { base.Voice(); }
    }
    public sealed class Oysters : Fish
    {
        public override void Name() { Console.WriteLine("Oysters"); }
        public override void Voice() { base.Voice(); }
    }
    public sealed class Shark : Fish
    {
        public override void Name() { Console.WriteLine("Shark"); }
        public override void Voice() { base.Voice(); }
    }
}
