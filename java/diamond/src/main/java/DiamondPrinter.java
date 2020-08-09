import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

class DiamondPrinter {

    List<String> printToList(char a) {
        ArrayList<String> diamond = new ArrayList<>();
        int distance = a - 'A';
        int length = distance*2+1;


        for(int i=0; i <= distance; ++i){
            StringBuilder line = new StringBuilder(String.join("", Collections.nCopies(length, " ")));
            line.replace(distance-i, distance-i+1, String.valueOf(Character.toChars('A'+i)));
            line.replace(distance+i, distance+i+1, String.valueOf(Character.toChars('A'+i)));

            diamond.add(i, line.toString());
            if(i < distance)
                diamond.add(i, line.toString());
        }

        return diamond;
    }

}
