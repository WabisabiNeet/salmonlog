using SalmonlogNotifyPluginBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalmonlogCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // コンテナを作るところはお馴染み
            // Extensionsフォルダにあるアセンブリのカタログ
            var catalog = new DirectoryCatalog("plugin");
            var container = new CompositionContainer(catalog);

            // ISalmonlogNotifyPluginBaseを全部くれ頼む
            var plugins = container.GetExports<ISalmonlogNotifyPluginBase, ISalmonlogPluginMetadata>();
            foreach (var p in plugins)
            {
                Console.WriteLine($"PluginName:{p.Metadata.Name}({p.Metadata.Version})");
            }

        }
    }
}
