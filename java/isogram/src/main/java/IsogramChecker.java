class IsogramChecker {

    boolean isIsogram(String phrase) {

        String testString = phrase.replaceAll(" |-", "").toLowerCase();

        return  testString.length()
                ==
                (int)testString.chars().distinct().count();
    }

}
