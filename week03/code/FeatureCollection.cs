public class FeatureCollection {
    // TODO: Address Earthquake Problem - Implement your solution in this section
    // Create any additional classes required for the solution
    public Metadata metadata { get; set; }
    public List<Feature> features { get; set; }
}

public class Metadata {
    public long generated { get; set; }
    public int count { get; set; }
}

public class Feature {
    public Properties properties { get; set; }
}

public class Properties {
    public float mag { get; set; }
    public string place { get; set; }
    public long time { get; set; }
    public string type { get; set; }
}