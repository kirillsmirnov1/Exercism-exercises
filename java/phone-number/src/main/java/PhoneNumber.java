public class PhoneNumber {

    private final String inputNumber;

    PhoneNumber(String input){

        StringBuilder str = new StringBuilder(input.replaceAll("\\(|\\)|\\.| |\\+|-", ""));

        if(!str.toString().matches("[0-9]+"))
            throw new IllegalArgumentException("Illegal character in phone number. Only digits, spaces, parentheses, hyphens or dots accepted.");

        if(str.charAt(0) == '1' && str.length() == 11)
            str.deleteCharAt(0);

        if(str.length() == 11)
            throw new IllegalArgumentException("Can only have 11 digits if number starts with '1'");
        if(str.length() != 10)
            throw new IllegalArgumentException("Number must be 10 or 11 digits");
        if(str.charAt(0) == '0' || str.charAt(0) == '1' || str.charAt(3) == '0' || str.charAt(3) == '1')
            throw new IllegalArgumentException("Illegal Area Or Exchange Code. Only 2-9 are valid digits");

        inputNumber = str.toString();
    }

    String getNumber(){
        return inputNumber;
    }
}
