#include <stdio.h>
/* Bevis at denne maskine er en lille- engien */
/* Fordi miste betydende kommer først og mest kommer til sidst */
void main (void){
   short i = 0x1000;
   char* c = (char*)&i;

   printf(" %d hej \n",c[0]);
   printf(" %d hej \n",c[1]);
}
