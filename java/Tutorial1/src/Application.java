import java.util.Scanner;

public class Application {

    public static void main(String[] args){

        System.out.println("Hello world!");

        // Primitive Data Types
        byte myByte = 2;  // 8-bit signed, two's compliment
        short myShort = 576; // 16-bit
        int myInt = 88;  // 32-bit
        long myLong = 2;  // 64-bit
        float myFloat = 1.2f;  // 32-bit
        double myDouble = 5.4;  // 64-bit
        char myChar = 'q';  // single, 16-bit unicode character
        boolean myBool = true;  // true or false


//        // get user input
//        Scanner scanner1 = new Scanner(System.in);
//        System.out.println("Enter a line of text: ");
//        String line = scanner1.nextLine();  // nextInt(), nextDouble()
//        System.out.println("You entered: " + line);
//
//
//        // do while loop
//        Scanner scanner2 = new Scanner(System.in);
//        int value = 0;
//        do {
//            System.out.println("Enter a number: ");
//            value = scanner2.nextInt();
//        }
//        while(value != 5);
//        System.out.println("You got 5!");
//
//
//        // switch statement
//        Scanner scanner3 = new Scanner(System.in);
//        System.out.println("Enter a command: ");
//        String text = scanner3.nextLine();
//        switch(text){
//            case "start":
//                System.out.println("Machine started!");
//                break;
//            case "stop":
//                System.out.println("Machine stopped!");
//                break;
//            default:
//                System.out.println("Command not recognized");
//                break;
//        }


//        // arrays
//        int[] nums = new int[3];  // this array will hold 3 ints; values default to 0
//        nums[0] = 2;
//        nums[1] = 92;
//        nums[2] = 37;

        int[] nums = {2, 92, 37};  // same as the above 4 lines
        for(int i=0; i < nums.length; i++){
            System.out.println("nums: " + nums[i]);
        }


        String[] fruitArray = {"apple", "banana", "kiwi"};
        for(String fruit: fruitArray) {
            System.out.println("fruitArray: " + fruit);
        }


        // multi-dimensional arrays
        int[][] grid = {
                {3, 154, 8912},
                {8, 4},
                {12, 44, 2}
        };
        System.out.println(grid[1][1]);  // prints 4
        System.out.println(grid[0][2]);  // prints 8912
        System.out.println();
        for(int row = 0; row < grid.length; row++){
            for(int col = 0; col < grid[row].length; col++){
                System.out.print(grid[row][col] + "\t");
            }
            System.out.println();
        }
    }

}
