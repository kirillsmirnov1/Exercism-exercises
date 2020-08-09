import java.time.DayOfWeek;
import java.time.LocalDate;

public class Meetup {

    private final int month, year;

    public Meetup(int month, int year) {
        this.month = month;
        this.year  = year;
    }

    public LocalDate day(DayOfWeek dayOfWeek, MeetupSchedule meetupSchedule) {
//        LocalDate date = LocalDate.of(year, month, 1);

        switch(meetupSchedule){
            case FIRST:{
                LocalDate date = LocalDate.of(year, month, 1);

                return date.plusDays((dayOfWeek.getValue() + 7 - date.getDayOfWeek().getValue()) % 7);
            }
            case SECOND: {
                LocalDate date = LocalDate.of(year, month, 8);

                return date.plusDays((dayOfWeek.getValue() + 7 - date.getDayOfWeek().getValue()) % 7);
            }
            case THIRD: {
                LocalDate date = LocalDate.of(year, month, 15);

                return date.plusDays((dayOfWeek.getValue() + 7 - date.getDayOfWeek().getValue()) % 7);
            }
            case FOURTH: {
                LocalDate date = LocalDate.of(year, month, 22);

                return date.plusDays((dayOfWeek.getValue() + 7 - date.getDayOfWeek().getValue()) % 7);
            }
            case LAST: {
                LocalDate date = LocalDate.of(year, month, 1).plusMonths(1).minusDays(1);

                return date.minusDays((date.getDayOfWeek().getValue() - dayOfWeek.getValue() + 7 ) % 7);
            }
            case TEENTH: {
                LocalDate date = LocalDate.of(year, month, 13);

                return date.plusDays((dayOfWeek.getValue() + 7 - date.getDayOfWeek().getValue()) % 7);
            }
        }

        return null;
    }
}
