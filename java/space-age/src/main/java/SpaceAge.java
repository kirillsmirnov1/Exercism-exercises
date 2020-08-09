import java.util.HashMap;

class SpaceAge {

    final static double earthSeconds = 31557600d;

    static final HashMap<String, Double> ages;
    static{
        ages = new HashMap<>();
        ages.put("Earth"  ,               earthSeconds);
        ages.put("Mercury", 0.2408467   * earthSeconds);
        ages.put("Venus"  , 0.61519726  * earthSeconds);
        ages.put("Mars"   , 1.8808158   * earthSeconds);
        ages.put("Jupiter", 11.862615   * earthSeconds);
        ages.put("Saturn" , 29.447498   * earthSeconds);
        ages.put("Uranus" , 84.016846   * earthSeconds);
        ages.put("Neptune", 164.79132   * earthSeconds);
    }

    double seconds;

    SpaceAge(double seconds) {
        this.seconds = seconds;
    }

    double onEarth() {
        return seconds / ages.get("Earth");
    }

    double onMercury() {
        return seconds / ages.get("Mercury");
    }

    double onVenus() {
        return seconds / ages.get("Venus");
    }

    double onMars() {
        return seconds / ages.get("Mars");
    }

    double onJupiter() {
        return seconds / ages.get("Jupiter");
    }

    double onSaturn() {
        return seconds / ages.get("Saturn");
    }

    double onUranus() {
        return seconds / ages.get("Uranus");
    }

    double onNeptune() {
        return seconds / ages.get("Neptune");
    }

}
