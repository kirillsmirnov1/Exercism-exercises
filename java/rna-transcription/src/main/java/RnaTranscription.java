class RnaTranscription {

    String transcribe(String dnaStrand) {
        return dnaStrand
                .replaceAll("G", "K")
                .replaceAll("C", "G")
                .replaceAll("K", "C")
                .replaceAll("A", "U")
                .replaceAll("T", "A");
    }

}
