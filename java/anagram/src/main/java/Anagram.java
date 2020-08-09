import java.util.List;
import java.util.stream.Collectors;

public class Anagram {
    final String originalWord;

    Anagram(String originalWord){
        this.originalWord = originalWord.toLowerCase();
    }

    public List<String> match(List<String> testedList) {
        return testedList
                .stream()
                .filter(str -> str.length() == originalWord.length())
                .filter(str -> !originalWord.equals(str.toLowerCase()))
                .filter(str -> removeTest(str.toLowerCase()))
                .collect(Collectors.toList());
    }

    boolean removeTest(String checkWord){
        for(Character letter : originalWord.toCharArray()){
            if(checkWord.contains(letter.toString()))
                checkWord = checkWord.replaceFirst(letter.toString(), "");
        }
        return checkWord.isEmpty();
    }
}
