import java.util.Scanner;

public class Fortune {
    public static void main(String args[]){
        Scanner sc = new Scanner(System.in); // defines the sc object in class Scanner

        System.out.println("Greetings mortal. Welcome to Fortune Teller. Please enter your name. ");
        String name = sc.nextLine();

        System.out.println("Thank you " +name+ ". I will need more information to determine your fortune. Please enter your age.");
        int age = sc.nextInt();

        System.out.println("What is your most recent GPA?");
        double GPA = sc.nextDouble();

        System.out.println("If you were dying what sentence would you construct with the last of your breath? ");
        sc.nextLine();
        String phrase = sc.nextLine();

        System.out.println("What is your favorite animal? ");
        String animal = sc.nextLine();

        System.out.println("If you could meet any celebrity who would it be? ");
        String celebrity = sc.nextLine();

        System.out.println("How many people are in your immediate family? ");
        int family = sc.nextInt();
        double decimalLucky = ((age/GPA)*family);
        int lucky = (int)decimalLucky; //casts a double as an integer

        System.out.println("Congratulations! Your lucky number is " +lucky+ "! In " +lucky+ " years you will be greeted by " +celebrity+ ".");
        System.out.println("Unfortunately, they ate a diseased " +animal+ " after being dared by their Twitter fans. ");
        System.out.println("As " +celebrity+ " fell to the ground they whispered in your ear with their last breath \'" +phrase+ "\'... ");
        System.out.println("At least you will be lucky enough to be graced with the presence of " +celebrity+ " right?");
        System.out.print("Thank you " +name+ " for using Fortune Teller. Please tell your other mortal friends.");

    }
}
