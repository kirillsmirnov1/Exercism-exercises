import java.util.ArrayList;
import java.util.List;

public class Series {

    private final String numberString;

    Series(String str){
        numberString = str;
    }

    List<String> slices(int n){

        if(n > numberString.length()) throw new IllegalArgumentException("Slice size is too big.");
        if(n < 1) throw new IllegalArgumentException("Slice size is too small.");

        List<String> list = new ArrayList<>();
        int series = numberString.length() - n + 1;

        for(int i=0; i < series; ++i){
            list.add(numberString.substring(i, i+n));
        }

        return list;
    }
}
