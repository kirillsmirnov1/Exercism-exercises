class Darts {

    private final double distance;

    Darts(double x, double y) {
        distance = Math.sqrt(x*x+y*y);
    }

    int score() {
        if(distance <=  1d) return 10;
        if(distance <=  5d) return  5;
        if(distance <= 10d) return  1;

        return 0;
    }

}
