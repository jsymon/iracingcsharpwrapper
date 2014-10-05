using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;
namespace ConsoleApplication1
{
    public class FuncYaml
    {
        YamlNode RootNode { get; set; }

        public FuncYaml(string yaml)
        {
            var yamlStream = InitStream(yaml);
            if (!yamlStream.Documents.Any()
                || (RootNode = yamlStream.Documents[0].RootNode) == null)
                throw new Exception("Invalid YAML string");
        }

        private YamlStream InitStream(string yaml)
        {
            var tr = new StringReader(yaml);
            var yamlStream = new YamlStream();
            yamlStream.Load(tr);
            return yamlStream;
        }

        public string GetValue(params string[] tags)
        {
            string value = null;
            var parent = RootNode as YamlMappingNode;
            if (parent != null)
            {
                for (int i = 0; i < tags.Length; i++)
                {
                    var node = parent.Children.FirstOrDefault(a => (a.Key as YamlScalarNode).Value == tags[i]);
                    if (!node.Equals(default(KeyValuePair<YamlNode, YamlNode>)))
                    {
                        if (i == tags.Length - 1 && node.Value is YamlScalarNode)
                            value = (node.Value as YamlScalarNode).Value;
                        else if (i < tags.Length - 1 && node.Value is YamlMappingNode)
                            parent = node.Value as YamlMappingNode;
                        else
                            break;
                    }
                }
            }
            return value;
        }
    }
}
