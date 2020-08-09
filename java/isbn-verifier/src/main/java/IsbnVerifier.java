import java.util.stream.IntStream;

class IsbnVerifier {

    boolean isValid(String stringToVerify) {
        String stv = stringToVerify.replaceAll("-", "");

        return stv.matches("[0-9]{9}([0-9]|X)")
                &&
                (IntStream
                .range(0, 9)
                .map(i -> (stv.charAt(i) - '0')*(10-i))
                .sum()
                + (stv.charAt(9) == 'X' ? 10 : (stv.charAt(9) - '0')))
                % 11 == 0;
    }

}
