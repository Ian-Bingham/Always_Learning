public class Machine {

    public String name;  // public variables are accessible to all things
    private int id;  // private variables are only accessible within the class
    protected String genre;  // protected variables are accessible in the class, child classes,
                            // and anything within the same package
    int height;  // variables with no specifier are accessible to everything in the same package
                // Note: it is possible for the child and parent to be in different packages

    public void start(){
        System.out.println("Machine started.");
    }

    public void stop(){
        System.out.println("Machine stopped.");
    }
}
