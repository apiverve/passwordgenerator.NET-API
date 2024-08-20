using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("length")]
    public string length { get; set; }

    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("complexity")]
    public string complexity { get; set; }

    [JsonProperty("passwords")]
    public string[] passwords { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
