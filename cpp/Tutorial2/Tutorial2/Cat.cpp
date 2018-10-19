//
//  Cat.cpp
//  HelloWorld
//
//  Created by Ian on 10/16/18.
//  Copyright © 2018 Ian. All rights reserved.
//

#include <iostream>
#include <stdio.h>
#include "Cat.h"

using namespace std;

/*
 * same lines of code as Cat.h 24-26
 */
//// Constructor - do this when the object is created
//Cat::Cat(){
//    this->name = "Unknown";
//    this->age = -1;
//}
//
//Cat::Cat(string name){
//    this->name = name;
//    this->age = 17;
//}
//
//Cat::Cat(string name, int age){
//    this->name = name;
//    this->age = age;
//}

// Deconstructor - do this when the object is destroyed
Cat::~Cat(){
    cout << "Cat: " + name + " destroyed" << endl;
}

// const method: can't change values of variables
void Cat::speak() const {
    cout << "MEEEEOOOOWWW!!!" << endl;
}

string Cat::toString(){
    return "Cat name: " + name + ", Age: " + to_string(age);
}

void Cat::setName(string name){
    this->name = name;
}

void Cat::setAge(int age){
    this->age = age;
}

string Cat::getName(){
    return this->name;
}

int Cat::getAge(){
    return this->age;
}
