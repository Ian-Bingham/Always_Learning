//
//  Cat.h
//  HelloWorld
//
//  Created by Ian on 10/16/18.
//  Copyright © 2018 Ian. All rights reserved.
//

#ifndef Cat_h
#define Cat_h

#include <iostream>

using namespace std;

class Cat {
    
private:
    string name;
    int age;
    
public:
    // same lines of code as Cat.cpp 19-32
    Cat(): name("Unknown"), age(-1) {};
    Cat(string name): name(name), age(17) {};
    Cat(string name, int age): name(name), age(age) {};
    ~Cat();
    
    void speak() const; // const method: can't change values of variables
    string toString();
    void setName(string name);
    void setAge(int age);
    string getName();
    int getAge();
};


#endif /* Cat_h */
