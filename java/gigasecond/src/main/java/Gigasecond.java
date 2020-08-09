import java.time.LocalDate;
import java.time.LocalDateTime;

class Gigasecond {

    final static private long GIGASECOND = 1000000000;
    final private LocalDateTime birthDateTime;

    Gigasecond(LocalDate birthDate) {
        this.birthDateTime = birthDate.atStartOfDay();
    }

    Gigasecond(LocalDateTime birthDateTime) {
        this.birthDateTime = birthDateTime;
    }

    LocalDateTime getDate() {
        return birthDateTime.plusSeconds(GIGASECOND);
    }

}
