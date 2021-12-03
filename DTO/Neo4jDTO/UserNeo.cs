using Newtonsoft.Json;

namespace DTO
{
    public class UserNeo
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        // firstname + lastname
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
