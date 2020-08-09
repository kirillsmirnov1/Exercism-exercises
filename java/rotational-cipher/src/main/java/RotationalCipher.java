class RotationalCipher {

    private final int shiftKey;

    private final static int NUMBER_OF_LETTERS = 26;

    RotationalCipher(int shiftKey) {
        this.shiftKey = shiftKey;
    }

    String rotate(String data) {
        StringBuilder str = new StringBuilder();

        for(Character ch : data.toCharArray()){
            str.append(rotateSymbol(ch));
        }

        return str.toString();
    }

    private Character rotateSymbol(char symbol){
        if(symbol >= 'a' && symbol <= 'z'){
            symbol += shiftKey;
            if(symbol > 'z')
                symbol -= NUMBER_OF_LETTERS;
            return  symbol;
        } else if(symbol >= 'A' && symbol <= 'Z'){
            symbol += shiftKey;
            if(symbol > 'Z')
                symbol -= NUMBER_OF_LETTERS;
            return  symbol;
        }

        return symbol;
    }

}
