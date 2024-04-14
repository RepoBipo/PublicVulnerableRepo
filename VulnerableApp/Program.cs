using Newtonsoft.Json;

namespace VulnerableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var highlyNestedPayload = args[0];

            var parsedJson = JsonConvert.DeserializeObject(highlyNestedPayload);

            Console.WriteLine(parsedJson);
        }
    }
}
