import java.util.ArrayList;
import java.util.List;

class ProteinTranslator {

    List<String> translate(String rnaSequence) {
        ArrayList<String> result = new ArrayList<>();

        for(int i=0; i<rnaSequence.length(); i+=3){
            switch (rnaSequence.substring(i, i+3)){
                case "AUG" : result.add("Methionine"); break;

                case "UUU" :
                case "UUC" : result.add("Phenylalanine"); break;

                case "UUA" :
                case "UUG" : result.add("Leucine"); break;

                case "UCU" :
                case "UCC" :
                case "UCA" :
                case "UCG" : result.add("Serine"); break;

                case "UAU" :
                case "UAC" : result.add("Tyrosine"); break;

                case "UGU" :
                case "UGC" : result.add("Cysteine"); break;

                case "UGG" : result.add("Tryptophan"); break;

                case "UAA" :
                case "UAG" :
                case "UGA" : return result;
            }
        }
        return result;
    }
}