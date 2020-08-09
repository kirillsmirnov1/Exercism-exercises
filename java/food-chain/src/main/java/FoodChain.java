public class FoodChain {

    final static String starter = "I know an old lady who swallowed a ";

    final static String[] animals = {
            "fly",
            "spider",
            "bird",
            "cat",
            "dog",
            "goat",
            "cow"
    };

    final static String[] animalSpecifier = {
        "It wriggled and jiggled and tickled inside her.\n",
        "How absurd to swallow a bird!\n",
        "Imagine that, to swallow a cat!\n",
        "What a hog, to swallow a dog!\n",
        "Just opened her throat and swallowed a goat!\n",
        "I don't know how she swallowed a cow!\n"
    };

    final static String horseString =   "I know an old lady who swallowed a horse.\n" +
                                        "She's dead, of course!";

    public String verse(int verse) {

        if(verse == 8) return horseString;

        StringBuilder verseString = new StringBuilder(starter).append(animals[verse-1]).append(".\n");

        if(verse > 1){
            verseString.append(animalSpecifier[verse-2]);

            for(int i = verse-1; i > 1; --i){
                verseString.append("She swallowed the ").append(animals[i]).append(" to catch the ").append(animals[i-1]);
                if(i == 2) {
                    verseString.append(" that wriggled and jiggled and tickled inside her.\n");
                } else {
                    verseString.append(".\n");
                }
            }

            verseString.append("She swallowed the spider to catch the fly.\n");
        }

        return verseString.append("I don't know why she swallowed the fly. Perhaps she'll die.").toString();
    }

    public String verses(int startVerse, int endVerse) {
        StringBuilder versesString = new StringBuilder();

        for(int i=startVerse; i<=endVerse; ++i){
            versesString.append(verse(i)).append("\n\n");
        }

        return versesString.deleteCharAt(versesString.lastIndexOf("\n")).deleteCharAt(versesString.lastIndexOf("\n")).toString();
    }
}
