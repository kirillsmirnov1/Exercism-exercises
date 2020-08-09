import java.util.regex.Pattern;

public class Bob {
    String hey(String input){
        String output = "Whatever.";
        boolean question, yell;

        if(!Pattern.compile("[!-~]").matcher(input).find()) return "Fine. Be that way!";

        question = input.replaceAll(" ", "").endsWith("?");
        yell = input
                .chars()
                .filter(Character::isLetter)
                .count() > 0
                &
                input
                .chars()
                .filter(Character::isLetter)
                .allMatch(c -> c >= (int)'A' && c <= (int)'Z');

        if(question && yell) return "Calm down, I know what I'm doing!";
        if(question) return "Sure.";
        if(yell) return "Whoa, chill out!";


        return output;
    }
}
