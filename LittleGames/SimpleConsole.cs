using GameBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleGames
{
    /// <summary>
    /// Adapter to the real console
    /// </summary>
    public class SimpleConsole : IConsole
    {
        public string Choose(string[] prompts)
        {
            for(int i=0; i<prompts.Length;i++)            
            {
                Console.WriteLine("{0} - {1}",i, prompts[i]);
            }
            Console.Write("Your choice (none to end) :");
            string? s=Console.ReadLine();
            string ret = "";
            try
            {
                int val = Convert.ToInt32(s);
                ret = prompts[val];
            }
            catch { };
            
            return ret;
        }

        public void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public string? ReadLine(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
