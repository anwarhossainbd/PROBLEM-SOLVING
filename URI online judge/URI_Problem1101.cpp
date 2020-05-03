#include<iostream>

using namespace std ;

int main(){


int m,n,z;


while(true){

    cin>>m ;
    cin>>n ;


     if(m<=0||n<=0){
        break ;
    }


    else if(m>n){

            int sum=0 ;

       for( int i=n ;i<=m;i++) {

        sum=sum+i ;
        cout<<i<<" " ;

       }
       cout<<"Sum="<<sum<<endl ;
    }


    else if(n>m){

         int sum=0 ;

        for(int i=m ;i<=n;i++) {

        sum=sum+i ;
        cout<<i<<" " ;

       }
cout<<"Sum="<<sum<<endl ;
    }

}

}
