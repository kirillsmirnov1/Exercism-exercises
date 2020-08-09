class LargestSeriesProductCalculator {

    private final String inputNumber;

    LargestSeriesProductCalculator(String inputNumber) {
        if(!inputNumber.matches("[0-9]+") && inputNumber.length() != 0)
            throw new IllegalArgumentException("String to search may only contain digits.");
        this.inputNumber = inputNumber;
    }

    long calculateLargestProductForSeriesLength(int numberOfDigits) {
        long result = 0;

        if(numberOfDigits < 0)
            throw new IllegalArgumentException("Series length must be non-negative.");
        if(numberOfDigits > inputNumber.length())
            throw new IllegalArgumentException("Series length must be less than or equal to the length of the string to search.");

        for(int i=0; i<inputNumber.length()-numberOfDigits+1; ++i){
            String part = inputNumber.substring(i, i+numberOfDigits);
            long tmp = 1;

            //System.out.println(part.toCharArray());

            for(Character ch : part.toCharArray()){
                tmp *= (ch.charValue() - '0');
            }

            if(tmp > result) result = tmp;
        }

        return result;
    }
}
