#include <stdio.h>
int main(int argc, char* argv[]){

    int p = 42;
    int *p_pointer;
    p_pointer = &p;
    printf("%d\n",*p_pointer);


}