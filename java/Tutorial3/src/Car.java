
// Car is a child of Machine; Machine is the parent of Car
// Car inherits all the methods of machine
public class Car extends Machine {

    // overriding Machine start() method
    @Override
    public void start(){
        System.out.println("Car started.");
    }

    public void wipeWindShield(){
        System.out.println("Wiping wind shield.");

    }
}
