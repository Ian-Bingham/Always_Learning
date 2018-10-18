//
//  main.cpp
//  HelloWorld
//
//  Created by Ian on 10/3/18.
//  Copyright © 2018 Ian. All rights reserved.
//

#include <iostream>
#include "utils.h"
#include "Cat.h"

using namespace std;


int main(int argc, const char * argv[]) {
    
//    typeApples();
//    multiplicationTable();
    
//    cout << "Program starting..." << endl;
////    // Cat object destroyed right before return 0
////    Cat myCat;
////    myCat.speak();
//
////    // Cat object destroyed after leaving the scope
////    {
////        Cat myCat;
////        myCat.speak();
////    }
//    cout << "Program ending..." << endl;
    
    Cat cat1;
    Cat cat2("George");
    Cat cat3("Carl", 5);
    
    cout << cat1.toString() << endl;
    cout << cat2.toString() << endl;
    cout << cat3.toString() << endl;
    
    return 0;
}


void typeApples(){
    // do-while loop
    const string password = "apples";
    string input;
    
    do {
        cout << "Type in the word 'apples': " << flush;
        cin >> input;
        
        if(input == password){
            cout << "Access granted" << endl;
            break;
        }
        else {
            cout << "Access denied" << endl;
        }
        
    } while(true);

}


void multiplicationTable(){
    // Multiplication Table
    int multTable[11][11];
    for(int i = 0; i < sizeof(multTable)/sizeof(multTable[0]); i++){
        for(int j = 0; j < sizeof(multTable[0])/sizeof(int); j++){
            multTable[i][j] = i * j;
        }
    }
    
    for(int i = 0; i < sizeof(multTable)/sizeof(multTable[0]); i++){
        for(int j = 0; j < sizeof(multTable[0])/sizeof(int); j++){
            cout << multTable[i][j] << "\t" << flush;
        }
        cout << endl;
    }

}
