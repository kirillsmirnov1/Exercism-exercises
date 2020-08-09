public class House {

    final String[] subjects = {
        "house that Jack built",
        "malt",
        "rat",
        "cat",
        "dog",
        "cow with the crumpled horn",
        "maiden all forlorn",
        "man all tattered and torn",
        "priest all shaven and shorn",
        "rooster that crowed in the morn",
        "farmer sowing his corn",
        "horse and the hound and the horn"
    };

    final String[] verbs = {
        "lay in ",
        "ate ",
        "killed ",
        "worried ",
        "tossed ",
        "milked ",
        "kissed ",
        "married ",
        "woke ",
        "kept ",
        "belonged to "
    };

    String verse(int line){
        StringBuilder verse = new StringBuilder();

        verse.append("This is the ").append(subjects[line-1]);

        for(int i=line-2; i>=0; --i){
            verse.append(" that ").append(verbs[i]).append("the ").append(subjects[i]);
        }

        verse.append(".");

        return  verse.toString();
    }
    String verses(int from, int to){
        StringBuilder verses = new StringBuilder();

        for(int i = from; i <= to; ++i){
            verses.append(verse(i)).append("\n");
        }

        verses.deleteCharAt(verses.lastIndexOf("\n"));

        return verses.toString();
    }
    String sing(){
        return verses(1, 12);
    }
}
