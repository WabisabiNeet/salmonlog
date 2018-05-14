using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonlogNotifyPluginBase
{
    public interface ISalmonlogPluginMetadata
    {
        string Name { get; }

        string Version { get; }
    }

    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SalmonlogPluginExportAttribute : ExportAttribute, ISalmonlogPluginMetadata
    {
        public string Name { get; private set; }

        public string Version { get; private set; }

        public SalmonlogPluginExportAttribute(string name, string version)
            : base(typeof(ISalmonlogNotifyPluginBase))
        {
            Name = name;
            Version = version;
        }
    }
}
