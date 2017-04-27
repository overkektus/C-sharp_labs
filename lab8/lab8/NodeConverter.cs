using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lab7
{
    /*
    class NodeConverter : JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var array = JArray.Load(reader);
            var target = new List<Airport>();

            if (array.HasValues)
            {
                foreach (var child in array.Children())
                {
                    if ((string)child["_class"] == "airplane")
                    {
                        target.Add()
                    }
                    var node = CreateNode(child);

                    serializer.Populate(child.CreateReader(), node);
                    target.Add(node);
                }
            }
            return target;
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

    }
    */
}
