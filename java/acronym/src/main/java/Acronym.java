class Acronym {

    String phrase;

    Acronym(String phrase) {
        this.phrase = phrase;
    }

    String get() {
        StringBuilder acronym = new StringBuilder();

        for(String word : phrase.split(" |-")){
            acronym.append(word.toUpperCase().charAt(0));
        }

        return acronym.toString();
    }

}
