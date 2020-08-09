import java.util.HashMap;
import java.util.Map;

class Scrabble {

    final private String word;

    private static final Map<Character, Integer> values;
    static{
        values = new HashMap<>();
        values.put('A',1);
        values.put('E',1);
        values.put('I',1);
        values.put('O',1);
        values.put('U',1);
        values.put('L',1);
        values.put('N',1);
        values.put('R',1);
        values.put('S',1);
        values.put('T',1);
        values.put('D',2);
        values.put('G',2);
        values.put('B',3);
        values.put('C',3);
        values.put('M',3);
        values.put('P',3);
        values.put('F',4);
        values.put('H',4);
        values.put('V',4);
        values.put('W',4);
        values.put('Y',4);
        values.put('K',5);
        values.put('J',8);
        values.put('X',8);
        values.put('Q',10);
        values.put('Z',10);
    }

    Scrabble(String word) {
        this.word = word;
    }

    int getScore() {
        return word
                .toUpperCase()
                .chars()
                .mapToObj(c -> (char) c)
                .mapToInt(values::get)
                .sum();
    }

}
