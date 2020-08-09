import java.util.Arrays;

class Yacht {

    private final int[] dice;
    private final YachtCategory yachtCategory;

    Yacht(int[] dice, YachtCategory yachtCategory) {
        this.dice = dice;
        this.yachtCategory = yachtCategory;
    }

    int score() {
        switch (yachtCategory){
            case YACHT:{
                return Arrays.stream(dice).filter(num -> num == dice[0]).count() == 5 ? 50 : 0;
            }
            case ONES:
            case TWOS:
            case THREES:
            case FOURS:
            case FIVES:
            case SIXES:{
                return (int) Arrays.stream(dice).filter(num -> num == yachtCategory.ordinal()).count() * yachtCategory.ordinal();
            }
            case FULL_HOUSE:{
                Arrays.sort(dice);
                switch((int)Arrays.stream(dice).filter(num -> num == dice[0]).count()){
                    case 2:{
                        if(Arrays.stream(dice).filter(num -> num == dice[4]).count() == 3)
                            return Arrays.stream(dice).sum();
                    }
                    case 3: {
                        if(Arrays.stream(dice).filter(num -> num == dice[4]).count() == 2)
                            return Arrays.stream(dice).sum();
                    }
                    default: return 0;
                }
            }
            case FOUR_OF_A_KIND:{
                Arrays.sort(dice);
                if(Arrays.stream(dice).filter(num -> num == dice[0]).count() >= 4)
                    return 4 * dice[0];
                if(Arrays.stream(dice).filter(num -> num == dice[4]).count() >= 4)
                    return 4 * dice[4];
            }
            case LITTLE_STRAIGHT:{
                Arrays.sort(dice);
                return Arrays.equals(dice, new int[]{1, 2, 3, 4, 5}) ? 30 : 0;
            }
            case BIG_STRAIGHT:{
                Arrays.sort(dice);
                return Arrays.equals(dice, new int[]{2, 3, 4, 5, 6}) ? 30 : 0;
            }
            case CHOICE:{
                return Arrays.stream(dice).sum();
            }
            default: return 0;
        }
    }

}
