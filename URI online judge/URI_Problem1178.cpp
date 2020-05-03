#include<iostream>
#include<bits/stdc++.h>

using namespace std ;

int main(){


  double number ,n ;

  cin>> number ;
  n= number ;

  int i ;

  for( i=1 ;i<=100 ;i++){

cout<<fixed ;
  cout<<"N["<<(i-1)<<"] = "<<setprecision(4)<<n<<endl ;

     n=n/2 ;
  }


}
