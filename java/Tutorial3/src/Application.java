
import ocean.*;  // import everything from the 'ocean' package we created
import ocean.plants.Seaweed;

public class Application {

    public static void main(String[] args){

        Machine mach1 = new Machine();
        mach1.start();
        mach1.stop();

        Car car1 = new Car();
        car1.start();
        car1.stop();
        car1.wipeWindShield();


        Fish fish = new Fish();
        Seaweed seaweed = new Seaweed;
    }
}
