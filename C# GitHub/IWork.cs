using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using work;

namespace work
{
    interface IWorker
    {
        bool ІsWorking { get; }
        string IWork { get; }
    }
    interface IPart
    {
        string Name { get; }
    }

    //**************************   WORKER   **************************//
    class Worker : IWorker
    {
        public bool ІsWorking { get; } = true;
        public string IWork => "I'm working";
    }
    class TeamLeader : IWorker, IEnumerable
    {
        List<House> teamLeaders = new();
        public bool ІsWorking { get; } = true;
        public string IWork => "I'm report the information";
        public string Name => "John";
        IEnumerator IEnumerable.GetEnumerator() => teamLeaders.GetEnumerator();
        public IPart this[int index] => teamLeaders[index];
    }
    class Team : House, IWorker, IEnumerable
    {
        List<IWorker> workers = new List<IWorker>()
        {
            new Worker(),
            new TeamLeader(),
            new Worker(),
            new Worker(),
            new Worker()
        };
        public bool ІsWorking { get; } = true;
        public string IWork => "I'm from the Team";
        public int Lenght => workers.Count;
        //public string Work => new House().Name;
        IEnumerator IEnumerable.GetEnumerator() => workers.GetEnumerator();
        public IWorker this[int index]
        {
            get { return workers[index]; }
            set
            {
                if (index > 0 && index < workers.Count)
                    workers[index] = value;
            }
        }
        public void AddTeam(uint size = 1)
        {
            for (int i = 0; i < size; i++) { workers.Add(this); }
        }
        public void TeamInformation()
        {
            if (workers.Count > 0)
            {
                foreach (Team item in workers)
                {
                    Console.WriteLine($"{item.Name} | {item.IWork} - {new Worker().IWork} | {item.ІsWorking}");
                }
            }
            else
                Console.WriteLine($"[{DateTime.Now}] There are currently no employee");
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
        public void AddHouse(IPart part)
        {
            parts.Add(part);
        }
        public void printHouse()
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