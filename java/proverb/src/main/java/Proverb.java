class Proverb {

    final String[] words;

    Proverb(String[] words) {
        this.words = words;
    }

    String recite() {

        StringBuilder result = new StringBuilder("");

        if(words.length == 0) return result.toString();

        for(int i=0; i<words.length-1; ++i){
            result.append("For want of a ").append(words[i]).append(" the ").append(words[i+1]).append(" was lost.\n");
        }

        result.append("And all for the want of a ").append(words[0]).append(".");

        return result.toString();
    }

}
