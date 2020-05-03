#include <iostream>

using namespace std;

int main(){

 int i ,j , p=0 ,position ;

 for(i=1 ; i<=100 ;i++){

    cin>>j ;

    if(j>p){
        p=j ;
        position = i ;
    }

 }

 cout<<p<<endl ;
    cout<<position<<endl ;


}
