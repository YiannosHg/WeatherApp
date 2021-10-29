// Classes that hold the variables from API
public class WeatherApiResponse
{
    public Location location { get; set; }
    public Current current { get; set; }
}

public class Location
{
    public string name { get; set; }
    public string region { get; set; }
    public string country { get; set; }
    public string localtime { get; set; }
}

public class Current
{
    public float temp_c { get; set; }
    public float temp_f { get; set; }
    public Condition condition { get; set; }
}

public class Condition
{
    public string text { get; set; }
    public string icon { get; set; }
}
