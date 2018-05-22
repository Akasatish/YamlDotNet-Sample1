using System;
using System.Collections.Generic;

using YamlDotNet.Serialization;

namespace YamlDotNet_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                new SerializerBuilder().Build().Serialize(
                  new DeserializerBuilder().Build().Deserialize<Dictionary<string, string>>(
                      "key1: value1\nkey2: value2")));
        }
    }
}