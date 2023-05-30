using Newtonsoft.Json;


namespace Pobediteli
{
    public static class JsonSerialization
    {
        public static void serialize<T>(T obj, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(obj));
        }

        public static T deserialize<T>(string path)
        {
            string text = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(text);
        }
    }

}