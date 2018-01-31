using Photon.Hive.Plugin;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBreakerPlugin
{
    public class BlockBreakerPlugin : PluginBase
    {
        public BlockBreakerPlugin()
        {
        }

        public override string Name
        {
            get
            {
                return "BlockBreakerPlugin";
            }
        }

        public override void OnCreateGame(ICreateGameCallInfo info)
        {
            base.OnCreateGame(info);
            Console.WriteLine("SALA CRIADA!!!");
        }

        public override void OnRaiseEvent(IRaiseEventCallInfo info)
        {
            base.OnRaiseEvent(info);
            
        }
    }
}
