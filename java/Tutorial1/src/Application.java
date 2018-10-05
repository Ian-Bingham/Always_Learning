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



        // get user input
        Scanner scanner1 = new Scanner(System.in);
        System.out.println("Enter a line of text: ");
        String line = scanner1.nextLine();  // nextInt(), nextDouble()
        System.out.println("You entered: " + line);


        // do while loop
        Scanner scanner2 = new Scanner(System.in);
        int value = 0;
        do {
            System.out.println("Enter a number: ");
            value = scanner2.nextInt();
        }
        while(value != 5);
        System.out.println("You got 5!");


        // switch statement
        Scanner scanner3 = new Scanner(System.in);
        System.out.println("Enter a command: ");
        String text = scanner3.nextLine();
        switch(text){
            case "start":
                System.out.println("Machine started!");
                break;
            case "stop":
                System.out.println("Machine stopped!");
                break;
            default:
                System.out.println("Command not recognized");
                break;
        }
    }

}
