class ArmstrongNumbers {

	boolean isArmstrongNumber(int numberToCheck) {
		char[] numberAsString = ("" + numberToCheck).toCharArray();
		int resultingNumber = 0;

		for(char ch : numberAsString){
			resultingNumber += Math.pow( (double) Character.getNumericValue(ch), (double) numberAsString.length);
		}

		return resultingNumber == numberToCheck;
	}

}
