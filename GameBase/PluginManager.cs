using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase
{
    public class PluginManager
    {
        private string pluginsPath;

        public PluginManager(string path) 
        {
            this.pluginsPath = path;
        }

        public void LoadPlugins()
        {
            string[] files = Directory.GetFiles(pluginsPath, "*.dll");
            foreach (string file in files)
            {
                var assembly = System.Reflection.Assembly.LoadFrom(file);
                var init = assembly.GetType("Plugin.Init");
                var method = init?.GetMethod("Register");
                method?.Invoke(null, null);
            }
        }
    }
}
