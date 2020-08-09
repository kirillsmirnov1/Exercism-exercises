public class RomanNumeral {
    private final int number;
    private static final char[] ROMAN_NUMERALS = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};

    RomanNumeral(int number){
        this.number = number;
    }

    public String getRomanNumeral() {

        StringBuilder romanNumeral = new StringBuilder();
        String numberString = String.valueOf(number);

        for(int i=0; i<numberString.length(); ++i){
            final int currentNumber = Character.getNumericValue(numberString.charAt(i));
            final int tenthPower = numberString.length() - i - 1;

            switch (currentNumber){
                case 9:
                    romanNumeral.append(ROMAN_NUMERALS[tenthPower*2]).append(ROMAN_NUMERALS[tenthPower*2+2]);
                    break;
                case 8:
                case 7:
                case 6:
                case 5:
                    romanNumeral.append(ROMAN_NUMERALS[tenthPower*2+1]);
                    for(int j=0; j<currentNumber-5; ++j){
                        romanNumeral.append(ROMAN_NUMERALS[tenthPower*2]);
                    }
                    break;
                case 4:
                    romanNumeral.append(ROMAN_NUMERALS[tenthPower*2]).append(ROMAN_NUMERALS[tenthPower*2+1]);
                    break;
                case 3:
                case 2:
                case 1:
                    for(int j=0; j<currentNumber; ++j){
                        romanNumeral.append(ROMAN_NUMERALS[tenthPower*2]);
                    }
                    break;
            }
        }

        return romanNumeral.toString();
    }
}
