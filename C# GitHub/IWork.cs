using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    interface IWorker
    {
        string IWork { get; }
        void Work(House house);
    }
    interface IPart
    {
        string Name { get; }
    }

    //**************************   WORKER   **************************//
    class Worker : IWorker
    {
        public string IWork => "I'm working";
        public void Work(House house)
        {
            Console.WriteLine($"{IWork} - {house.Name}");
        }
    }
    class TeamLeader : IWorker, IEnumerable
    {
        public List<IPart> teamLeaders = new List<IPart>();
        public string IWork => "I'm report the information";
        public void Work(House house) { 
            Console.WriteLine($"{IWork} - {house.Name}"); 
            teamLeaders.Add(house); }
        public void AddIPart(IPart part) => teamLeaders.Add(part);
        IEnumerator IEnumerable.GetEnumerator() => teamLeaders.GetEnumerator();

        public void PrintLeader()
        {
            foreach (TeamLeader item in teamLeaders)
            {
                Console.WriteLine(item.IWork);
            }
        }
    }
    class Team : IEnumerable
    {
        public List<IWorker> workers = new()
        {
            new Worker(),
            new TeamLeader(),
            new Worker(),
            new Worker(),
            new Worker()
        };
        public int Lenght => workers.Count;
        IEnumerator IEnumerable.GetEnumerator() => workers.GetEnumerator();
        public void Work(House house)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                workers[i].Work(house);
            }
        }
        public IWorker this[int index]
        {
            get { return workers[index]; }
            set
            {
                if (index > 0 && index < workers.Count)
                    workers[index] = value;
            }
        }
        public void AddTeam(IWorker worker, uint size = 1)
        {
            if (size > 0)
            {
                for (int i = 0; i < size; i++) workers.Add(worker);
            }
        }
    }
    //**************************   HOUSE   **************************//
    class House : IPart, IEnumerable
    {
        public List<IPart> parts = new List<IPart>()
        {
            new Basement(),
            new Walls(),
            new Door(),
            new Window(),
            new Roof()
        };
        public string Name => "House";
        IEnumerator IEnumerable.GetEnumerator()
        { return parts.GetEnumerator(); }
        public IPart this[int index]
        {
            get { return parts[index]; }
            set
            {
                if (index > 0 && index < parts.Count)
                    parts[index] = value;
            }
        }
        public void AddHouse(IPart part, uint size = 1)
        {
            if (size > 0)
            {
                for (int i = 0; i < size; i++) parts.Add(part);
            }
        }
        public void PrintHouse()
        {
            foreach (IPart h in parts)
            {
                Console.WriteLine(h.Name);
            }
        }
    }
    class Basement : IPart
    {
        public string Name => "Basement";
    }
    class Walls : IPart
    {
        public string Name => "Walls";
    }
    class Door : IPart
    {
        public string Name => "Door";
    }
    class Window : IPart
    {
        public string Name => "Window";
    }
    class Roof : IPart
    {
        public string Name => "Roof";
    }
}
