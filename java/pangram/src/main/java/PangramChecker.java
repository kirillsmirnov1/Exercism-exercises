public class PangramChecker {

    final String abc = "abcdefghijklmnopqrstuvwxyz";

    public boolean isPangram(String input) {
        input = input.toLowerCase();
        for(char letter : abc.toCharArray()){
            if(! input.contains("" + letter))
                return false;
        }
        return true;
    }
}
