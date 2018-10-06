
// Car is a child of Machine; Machine is the parent of Car
// Car inherits all the methods of machine
public class Car extends Machine {

    public Car(){
//        this.id = 4;  // doesn't work b/c 'id' is of type private
        this.genre = "automobile";  // works b/c genre is of type protected, and Car is a child of Machine
    }

    // overriding Machine start() method
    @Override
    public void start(){
        System.out.println("Car started.");
    }

    public void wipeWindShield(){
        System.out.println("Wiping wind shield.");

    }
}
