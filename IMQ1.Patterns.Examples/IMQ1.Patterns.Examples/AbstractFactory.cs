using System;

namespace IMQ1.Patterns.Examples
{
    abstract class HumenFactory
    {
        public abstract GoodGuy CreateGoodGuy();
        public abstract Killer CreateKiller();
    }

    class PeopleFactory : HumenFactory
    {
        public override GoodGuy CreateGoodGuy()
        {
            return new Ilya();
        }
        public override Killer CreateKiller()
        {
            return new Sergey();
        }
    }

    abstract class GoodGuy
    {
    }

    abstract class Killer
    {
        public abstract void Kill(GoodGuy gg);
    }

    class Ilya : GoodGuy
    {
    }

    class Sergey : Killer
    {
        public override void Kill(GoodGuy gg)
        {
            Console.WriteLine(GetType().Name +
              " kills" + gg.GetType().Name);
        }
    }

    class PeopleWorld
    {
        private GoodGuy _goodGuy;
        private Killer _killer;

        public PeopleWorld(HumenFactory factory)
        {
            _killer = factory.CreateKiller();
            _goodGuy = factory.CreateGoodGuy();
        }

        public void RunFoodChain()
        {
            _killer.Kill(_goodGuy);
        }
    }
}
}
