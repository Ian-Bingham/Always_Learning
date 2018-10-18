public class Application {

    public static void main(String[] args){
        Plant plant1 = new Plant();
        Tree tree = new Tree();

        Plant plant2 = tree;
        plant2.grow();  // prints out "Tree growing"
        tree.shedLeaves();
    }
}
