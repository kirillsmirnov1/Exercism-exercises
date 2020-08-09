import java.util.ArrayList;
import java.util.List;

public class Allergies {

    private final int allergenIds;

    public Allergies(int id) {
        allergenIds = id;
    }

    boolean isAllergicTo(Allergen allergen){
        return (allergen.getScore() & allergenIds) > 0;
    }

    public List<Allergen> getList() {
        ArrayList<Allergen> allergenList = new ArrayList<>();

        for(Allergen allergen : Allergen.values()){
            if(isAllergicTo(allergen))
                allergenList.add(allergen);
        }

        return allergenList;
    }
}
