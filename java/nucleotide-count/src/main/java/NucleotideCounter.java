import java.util.HashMap;
import java.util.Map;

class NucleotideCounter {
    private final String nucleotide;
    NucleotideCounter(String input){

        if(!input.matches("[ACGT]*"))
            throw new IllegalArgumentException();

        nucleotide = input;
    }

    Map<Character, Integer> nucleotideCounts(){
        HashMap<Character, Integer> counter = new HashMap<>();

        counter.put('A', 0);
        counter.put('C', 0);
        counter.put('G', 0);
        counter.put('T', 0);

        for(Character ch : nucleotide.toCharArray()){
            counter.put(ch, counter.get(ch) + 1);
        }

        return counter;
    }
}
