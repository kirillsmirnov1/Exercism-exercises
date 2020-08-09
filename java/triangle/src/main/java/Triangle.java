class Triangle {

    final private double side1, side2, side3;

    Triangle(double side1, double side2, double side3) throws TriangleException {
        if(Double.compare(side1+side2, side3) <= 0 ||
           Double.compare(side1+side3, side2) <= 0 ||
           Double.compare(side3+side2, side1) <= 0)
            throw new TriangleException();

        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    boolean isEquilateral() {
        return Double.compare(side1, side2) == 0 && Double.compare(side3, side2) == 0;
    }

    boolean isIsosceles() {
        return Double.compare(side1, side2) == 0 || Double.compare(side3, side1) == 0 || Double.compare(side3, side2) == 0;
    }

    boolean isScalene() {
        return !isIsosceles();
    }

}
