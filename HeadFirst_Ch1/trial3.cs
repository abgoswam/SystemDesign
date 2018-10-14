using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_Ch1
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("i can fly with wings");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("i can fly with wings");
        }
    }

    public interface IQuackBehavior
    {
        void Quack();
    }

    public class RealQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("i really do quack");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("i only do mute quacks");
        }
    }
    public abstract class Duck
    {
        public IFlyBehavior flyBehaviour;
        public IQuackBehavior quackBehaviour;

        public void performFly() { flyBehaviour.Fly(); }
        public void performQuack() { quackBehaviour.Quack(); }

        public abstract void display();
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new RealQuack();
        }

        public override void display()
        {
            Console.WriteLine("i am a MallardDuck");
        }
    }
}
