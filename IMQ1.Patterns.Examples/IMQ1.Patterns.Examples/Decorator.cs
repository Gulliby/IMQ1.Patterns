using System;

namespace IMQ1.Patterns.Examples
{
    abstract class Team
    {
        public abstract void Utomitsia();
    }

    class SuperTeam : Team
    {
        public override void Utomitsia()
        {
            Console.WriteLine("Mi utomilis!");
        }
    }

    abstract class Etap : Team
    {
        protected Team team;

        public void SetTeam(Team team)
        {
            this.team = team;
        }

        public override void Utomitsia()
        {
            if (team != null)
            {
                team.Utomitsia();
            }
        }
    }

    class FristEtap : Etap
    {
        public override void Utomitsia()
        {
            base.Utomitsia();
            Console.WriteLine("No Etap perviy mi ne zafeylili.");
        }
    }

    class SecondEtap : Etap
    {
        public override void Utomitsia()
        {
            base.Utomitsia();
            AddedBehavior();
            Console.WriteLine("Ftoroy etap pohoze zafeylili.");
        }

        void AddedBehavior()
        {
            Console.WriteLine("1+1=3");
        }
    }
}
