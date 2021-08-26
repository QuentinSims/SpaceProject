using System;
namespace SpaceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);

            MoonRover apollo = new MoonRover("Apollo 15", 1971);

            MarsRover sojourner = new MarsRover("Sojourner", 1997);

            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = { lunokhod, apollo, sojourner };

            //DirectAll(rovers);

            IDirectable[] probes = { lunokhod, apollo, sojourner, sputnik };

            DirectAll(probes);

            Object[] spaceProbes = { lunokhod, apollo, sojourner, sputnik };
            foreach (Object spaceProbe in spaceProbes)
            {
                Console.WriteLine(spaceProbe.GetType());
            }

        }
        public static void DirectAll(IDirectable[] probes)
        {
            foreach (IDirectable probe in probes)
            {
                Console.WriteLine(probe.GetInfo());
                Console.WriteLine(probe.Explore());
                Console.WriteLine(probe.Collect());
            }
        }
    }
}
