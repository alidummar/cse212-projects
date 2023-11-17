public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
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