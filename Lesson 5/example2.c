#include <stdio.h>
#include <stdlib.h>
int main(int argc, char* argv[]){

    int arraySize = 5;
    int * p = (int*) malloc(5*sizeof(int));
    

    for(int i = 0;i<arraySize; i++){
        p[i] = i+arraySize;
    }

    for(int i = 0;i<arraySize; i++){
        printf("%d\n",p[i]);
    }
    free(p);
    p=NULL;

}
