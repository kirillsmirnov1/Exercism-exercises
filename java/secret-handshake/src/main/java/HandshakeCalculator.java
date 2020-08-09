import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

class HandshakeCalculator {

    List<Signal> calculateHandshake(int number) {
        ArrayList<Signal> handshake = new ArrayList<>();

        if((number & 1) == 1)
            handshake.add(Signal.WINK);
        if((number & 2) == 2)
            handshake.add(Signal.DOUBLE_BLINK);
        if((number & 4) == 4)
            handshake.add(Signal.CLOSE_YOUR_EYES);
        if((number & 8) == 8)
            handshake.add(Signal.JUMP);

        if((number & 16) == 16)
            Collections.reverse(handshake);

        return handshake;
    }

}
