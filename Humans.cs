using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Humans
    {
        public Humans Mother { get; set; }
        public Humans Father { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }

        void Info(int indent = 0)
        {
            Console.WriteLine($"{new String ('-',indent)} Имя {this.Name}");
        }
        public virtual void Print (int indent = 0)
        {
            Info (indent);
        }

    public void ShowParents()
    {
        Console.WriteLine($"Mother: {Mother?.Name}");
        Console.WriteLine($"Father: {Father?.Name}");
    }


 
}
}
