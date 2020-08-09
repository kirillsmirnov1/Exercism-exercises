import java.util.Arrays;

class Matrix {

    private final int rowsNumber, columnsNumber;
    private final int[][] matrix;

    Matrix(String matrixAsString) {
        final String[][] stringMatrix;
        String[] rows = matrixAsString.split("\n");
        rowsNumber = rows.length;
        stringMatrix = new String[rowsNumber][];
        
        for(int i=0; i<rowsNumber; ++i){
            stringMatrix[i] = rows[i].split(" ");
        }

        columnsNumber = stringMatrix[0].length;

        matrix = new int[rowsNumber][columnsNumber];

        for(int row = 0; row < rowsNumber; row++){
            for(int column = 0; column < columnsNumber; column++){
                matrix[row][column] = Integer.parseInt(stringMatrix[row][column]);
            }
        }
    }

    int[] getRow(int rowNumber) {
        return Arrays.copyOf(matrix[rowNumber], columnsNumber);
    }

    int[] getColumn(int columnNumber) {
        int[] column = new int[rowsNumber];
        for(int i = 0; i < rowsNumber; i++){
            column[i] = matrix[i][columnNumber];
        }

        return column;
    }
}