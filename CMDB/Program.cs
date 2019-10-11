using System.Collections.Generic;
using System.Linq;

namespace Test_CMDB
{
    public class PC
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string HostName { get; set; }
        public string Model { get; set; }
        public string FormFactor { get; set; }
        public List<CPU> Cpus { get; set; }

        public PC(int id, string name, string model, string hostName, string formFactor)
        {
            Id = id;
            Name = name;
            Model = model;
            HostName = hostName;
            FormFactor = formFactor;
            Cpus = new List<CPU>();
        }

        public void AddCpu(CPU cpu)
        {
            Cpus.Add(cpu);
        }

        public override string ToString()
        {
            return $"PC->Name: {Name}";
        }

    }
    public class CPU
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string Vendor { get; set; }
        public int Pc_id { get; set; }

        public CPU(int id, string details, string vendor)
        {
            Id = id;
            Details = details;
            Vendor = vendor;

        }
        public override string ToString()
        {
            return $"Details {Details}";
        }
    }
    class CMDB
    {
        static void Main(string[] args)
        {
            List<PC> pcs = new List<PC>() { };
            PC valencia = new PC(1, "valencia", "fujitsu", "valancia", "Miditower");
            pcs.Add(valencia);
            PC aquarius = new PC(2, "aquarius", "Apple", "aquarius", "Notebook");
            pcs.Add(aquarius);
            PC talos = new PC(3, "talos", "XEN", "talos", "virtueller Server");
            pcs.Add(talos);
            CPU i7 = new CPU(1, "Core i7-9570", "Intel");
            CPU i5 = new CPU(2, "Core i5-3500", "Intel");
            CPU i3 = new CPU(3, "Core i3-2300", "Intel");
            valencia.AddCpu(i7);
            aquarius.AddCpu(i5);
            talos.AddCpu(i3);

            talos.AddCpu(new CPU(3, "Core i3-2300", "Intel"));


            var tes = from pc in pcs where pc.FormFactor == "Notebook" select pc;



            foreach (PC test in pcs)
            {
                if (test.FormFactor.ToString() == "Notebook")
                {
                    System.Console.WriteLine($"Der PC {test.Name} ist ein Notebook");
                }
                else if (test.FormFactor.ToString() == "Miditower")
                {
                    System.Console.WriteLine($"Der PC {test.Name} ist ein Miditower");
                }
            }

            System.Console.ReadKey();

        }

        private static void GetAttribut()
        {

        }

    }

}
