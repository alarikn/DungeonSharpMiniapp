// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

using System.Collections.Generic;
using Newtonsoft.Json;
public class MonsterResult
{
    [JsonProperty("index")]
    public string Index { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}

public class MonsterRoot
{
    [JsonProperty("count")]
    public int Count { get; set; }

    [JsonProperty("results")]
    public List<MonsterResult> Results { get; set; }
}
