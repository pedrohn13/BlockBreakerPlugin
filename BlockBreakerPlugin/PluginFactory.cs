using Photon.Hive.Plugin;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBreakerPlugin
{
    class PluginFactory : IPluginFactory
    {
        public IGamePlugin Create(
              IPluginHost gameHost,
              string pluginName, // name of plugin requested by client
              Dictionary<string, string> config, // plugin settings
              out string errorMsg)
        {
            var plugin = new BlockBreakerPlugin();
            if (plugin.SetupInstance(gameHost, config, out errorMsg))
            {
                return plugin;
            }
            return null;
        }
    }
}
