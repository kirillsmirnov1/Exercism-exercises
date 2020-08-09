public class BeerSong {

    static final String noMore = "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n\n";

    public String sing(int from, int num) {
        StringBuilder song = new StringBuilder();

        for(int i = from; i > from - num && i > 0; --i){
            if(i == 1){
                song.append("1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n\n");
            } else {
                song.append(i)
                    .append(" bottles of beer on the wall, ")
                    .append(i)
                    .append(" bottles of beer.\nTake one down and pass it around, ")
                    .append(i-1);
                if(i == 2)
                    song.append(" bottle of beer on the wall.\n\n");
                else
                    song.append(" bottles of beer on the wall.\n\n");
            }
        }

        if(from - num < 0)
            song.append(noMore);

        return song.toString();
    }

    public String singSong() {
        return  sing(99, 99) + noMore;
    }
}
