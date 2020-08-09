public class PigLatinTranslator {
    String translate(String input){

        String[] words = input.split(" ");
        StringBuilder result = new StringBuilder();

        for(String word : words) {

            word = vowelRule(word);

            word = consonantRule(word);

            result.append(word + " ");
        }

        result.deleteCharAt(result.lastIndexOf(" "));

        return result.toString();
    }

    private String consonantRule(String str) {
        if(str.matches("\\b[bcdfghjklmnpqrstyvwxz]\\w*") && !str.startsWith("xr") && ! str.startsWith("yt")){
            StringBuilder strB = new StringBuilder(str);

            if(strB.toString().startsWith("y"))
                strB = strB.append(strB.charAt(0)).deleteCharAt(0);

            while(strB.toString().matches("\\b[bcdfghjklmnpqrstvwxz]\\w*")){
                if(strB.toString().startsWith("qu")){
                    strB.delete(0, 2).append("qu");
                    break;
                }
                strB = strB.append(strB.charAt(0)).deleteCharAt(0);
            }
            strB.append("ay");
            str = strB.toString();
        }

        return str;
    }

    private String vowelRule(String str) {
        if(str.matches("\\b[aeiou]\\w*") || str.startsWith("xr") || str.startsWith("yt"))
            return str+"ay";
        return str;
    }
}
