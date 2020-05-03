#include<iostream>
#include<bits/stdc++.h>

using namespace std ;

int main(){

    double number ,n =0 ,add=0 ;

while(true){


    cin>>number ;

    if(number<0 || number>10 ){

        cout<<"nota invalida"<<endl ;
    }

   else{
     add=add+number ;
     n++ ;

   }

   if(n==2)break ;
}

double d= add/2 ;

cout<<fixed ;
cout<<setprecision(2) <<"media = "<<d<<endl  ;



}