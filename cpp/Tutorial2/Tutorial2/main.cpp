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


/* -------------------------- NOTES ---------------------------------
    // const method: can't change values of variables
    // const int* p1Val: pointer to an int that's constant (can't change the value of the int)
    // int* const p2Val = &value: constant pointer to an int (can't change the thing its pointing to)
    // const int* const p3Val: constant pointer to a constant int (can't change the value of the int AND can't change the thing its pointing to)
*/



int main(int argc, const char * argv[]) {
    
    /*
        typeApples();
        multiplicationTable();
     */
    
    
    
    
    // -------------------------- CLASSES ---------------------------------
    
    /*
        cout << "Program starting..." << endl;
        // Cat object destroyed right before return 0
        Cat myCat;
        myCat.speak();

        // Cat object destroyed after leaving the scope
        {
            Cat myCat;
            myCat.speak();
        }
        cout << "Program ending..." << endl;
     */

    // ------------------------------
    
    /*
        Cat cat1;
        Cat cat2("George");
        Cat cat3("Carl", 5);
     
        cout << cat1.toString() << endl;
        cout << cat2.toString() << endl;
        cout << cat3.toString() << endl;
     */
    
    
    
    
    
    // ------------------------ POINTERS -----------------------------------
    
    /*
        double myInt = 72.456;
        cout << "myInt before manipulate: " << myInt << endl;
        manipulate(&myInt);
        cout << "myInt after manipulate: " << myInt << endl;
     */
    
    // ------------------------------
    
    /*
        string texts[] = {"one", "two", "three"};
        string* pTexts = texts; // points to the address of the first element in the array;
                                // same as: string* pTexts = &texts[0]
     
        for(int i = 0; i < sizeof(texts)/sizeof(texts[0]); i++){
            // cout << pTexts[i] << endl; // does the same thing as the code below

            cout << *pTexts << endl; // de-refference the memory address that we are pointing to
            pTexts++; // point to the address of the next element in the list
        }
     
        // alternative way to doing the above for loop
        string* pFirst = &texts[0];
        string* pLast = &texts[sizeof(texts)/sizeof(texts[0])];
     
        do{
            cout << *pFirst << endl;;
            pFirst++;
     
        }while(pFirst != pLast);
     */
    
    // ------------------------------
    
    /*
        char word[] = "pineapple";
        reverseWord(word);
        cout << word << endl;
     */
    
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


/*
     Changes the value at a particular memory location
     pVal - a pointer (in this case it's the address of myInt on line 49)
 */
void manipulate(double* pVal){
    // de-refferencing the pointer and setting the value to 11.11
    // (i.e. we are replacing the contents at memory address pVal)
    *pVal = 11.11;
}


// reverse a word in place
void reverseWord(char word[]){
    char* pFirstChar = &word[0];
    char* pLastChar = &word[strlen(word) - 1];
    while (pFirstChar < pLastChar){
        char tmp = *pFirstChar;
        *pFirstChar = *pLastChar;
        *pLastChar = tmp;
        
        pFirstChar++;
        pLastChar--;
    }
}
