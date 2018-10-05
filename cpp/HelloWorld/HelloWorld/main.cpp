//
//  main.cpp
//  HelloWorld
//
//  Created by Ian on 10/3/18.
//  Copyright © 2018 Ian. All rights reserved.
//

#include <iostream>
#include <string>

int main(int argc, const char * argv[]) {
    // insert code here...
    std::string name;
    std::cout << "Hello, World!\n";
    std::cout << "What is your name?\n";
    getline(std::cin, name);
    std::cout << "Nice to meet you " << name << "!\n";
    std::cout << "Your name has " << name.length() << " letters.\n";
    std::cout << "Your name starts with " << name.front() << ".\n";
    std::cout << "Your name ends with " << name.back() << ".\n";
    name.append(" the Great");
    std::cout << "Your new name is now " << name << "!\n";
    std::cin.ignore();
    return 0;
}
