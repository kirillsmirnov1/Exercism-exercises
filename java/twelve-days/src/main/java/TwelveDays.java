class TwelveDays {

    final String[] lines = {"a Partridge in a Pear Tree.\n",
                            "two Turtle Doves, and ",
                            "three French Hens, ",
                            "four Calling Birds, ",
                            "five Gold Rings, ",
                            "six Geese-a-Laying, ",
                            "seven Swans-a-Swimming, ",
                            "eight Maids-a-Milking, ",
                            "nine Ladies Dancing, ",
                            "ten Lords-a-Leaping, ",
                            "eleven Pipers Piping, ",
                            "twelve Drummers Drumming, "};

    final String[] days = { "first ",
                            "second ",
                            "third ",
                            "fourth ",
                            "fifth ",
                            "sixth ",
                            "seventh ",
                            "eighth ",
                            "ninth ",
                            "tenth ",
                            "eleventh ",
                            "twelfth "};

    String verse(int verseNumber) {
        StringBuilder verse = new StringBuilder();

        verse.append("On the ").append(days[verseNumber-1]).append("day of Christmas my true love gave to me, ");

        for(int i = verseNumber-1; i >= 0; --i){
            verse.append(lines[i]);
        }

        return verse.toString();
    }

    String verses(int startVerse, int endVerse) {
        StringBuilder verses = new StringBuilder();

        for(int i=startVerse; i<=endVerse; ++i){
            verses.append(verse(i));
            verses.append("\n");
        }
        verses.deleteCharAt(verses.lastIndexOf("\n"));

        return  verses.toString();
    }
    
    String sing() {
        return verses(1, 12);
    }
}
