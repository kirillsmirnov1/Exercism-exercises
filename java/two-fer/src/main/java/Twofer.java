class Twofer {
    String twofer(String name) {
        if(name == null || name.isEmpty() )
            name = new String("you");

        return new String("One for " + name + ", one for me.");
    }
}
