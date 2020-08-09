import java.util.ArrayList;

class NaturalNumber {
    private final int number;

    NaturalNumber(int number){

        if(number < 1)
            throw new IllegalArgumentException("You must supply a natural number (positive integer)");

        this.number = number;
    }

    public Classification getClassification() {
        ArrayList<Integer> factors = new ArrayList<>();
        final int aliquotSum;

        for(int i=1; i<number; ++i){
            if(number%i == 0)
                factors.add(i);
        }

        aliquotSum = factors.stream().mapToInt(Integer::intValue).sum();

        if(aliquotSum == number) return Classification.PERFECT;
        if(aliquotSum >  number) return Classification.ABUNDANT;

        return Classification.DEFICIENT;
    }
}
