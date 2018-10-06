
class Person {

    // instance variables
    private String name;
    private int age;

    // methods
    public void speak(){
        System.out.printf("My name is %s and I am %d years old.\n", name, age);
    }

    public void eat(String food, int quantity){
        System.out.printf("%s likes to eat %d %s a day.\n", name, quantity, food);
    }

    public int calculateYearsToRetirement(){
        int yearsLeft = 65 - age;
        return yearsLeft;
    }

    public String getName(){
        return name;
    }

    public int getAge(){
        return age;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }

}


class Machine {

    private String name;
    private int code;

    // constructor - used for initialization
    // default parameter values are NOT supported in Java - must overload methods
    public Machine(){
        // if you want to call a constructor within a constructor it MUST be the first line
        this("Georgie", 7);
    }

    public Machine(String name){
        this(name, 3);
    }

    public Machine(String name, int code){
        this.name = name;
        this.code = code;
    }

    public String getName(){
        return name;
    }

    public int getCode(){
        return code;
    }
}


class Thing {

    public String name;  // instance variables belong to the OBJECT
    public static String description;  // static variables belong to the CLASS

    // Good uses for static variables:
    // 1) creating constants for a class (e.q. Math.PI)
    // 2) keeping track of an 'id' for your objects
    public final static int LUCKY_NUMBER = 7;
    public static int count = 0;   // keeps a count of the number of objects created
    public static int id = 0;

    public void Thing(){
        id = count;
        count++;
    }

    // Note: static methods only have access to static variables. NOT instance variables
    public static void showInfo(){
        System.out.println(description + ": static method");
//        System.out.println(name); // won't work
    }

    // On the other hand, instance methods DO have access to static variables
    public void showName(){
        System.out.println(description + ": " + name);
    }
}

class Frog{

    private String name;
    private int id;

    public Frog(String name, int id){
        this.name = name;
        this.id = id;
    }

    // allows you to print out information about your object
    // equivalent to __str__ method in python
    public String toString(){

//        return name + ": " + id; // INEFFICIENT

//        // EFFICIENT
//        StringBuilder sb = new StringBuilder();
//        sb.append(name).append(": ").append(id);
//        return sb.toString();

        // EASY
        return String.format("%s: %d", name, id);
    }
}


public class Application {

    public static void main(String[] args){

        Person person = new Person();

        /*
        // can only set class instance variables this way if they are declared as public
        // if they are private you must use setter methods
        person.name = "Jim Jim";
        person.age = 58;
        */
        person.setName("Jim Jim");
        person.setAge(45);
        person.speak();
        person.eat("apples", 8);
        int years = person.calculateYearsToRetirement();
        System.out.printf("%s has %d years left until retirement.\n", person.getName(), years);


        Machine machine1 = new Machine();
        Machine machine2 = new Machine("Carl");
        Machine machine3 = new Machine("Bobby", 42);
        System.out.println();
        System.out.printf("Machine1: %s, %d\n", machine1.getName(), machine1.getCode());
        System.out.printf("Machine2: %s, %d\n", machine2.getName(), machine2.getCode());
        System.out.printf("Machine3: %s, %d\n", machine3.getName(), machine3.getCode());


        Thing.description = "I am a thing";  // 'description' is a static variable so we call it on the class
        Thing thing1 = new Thing();
        Thing thing2 = new Thing();
        thing1.name = "Greg";
        thing2.name = "Sarah";
        Thing.showInfo();  // 'showInfo' is a static method so we call it on the class
        thing1.showName();
        thing2.showName();
        System.out.println(Thing.LUCKY_NUMBER);


        Frog frog = new Frog("joey", 584);
        System.out.println(frog);  // can print out object 'frog' because of the toString() method we defined in class Frog
    }
}
