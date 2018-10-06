
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
    }
}
