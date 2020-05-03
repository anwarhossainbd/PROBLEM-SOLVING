#include<iostream>
#include<bits/stdc++.h>

using namespace std ;

int main(){

double N1,N2,N3,N4 ;
cin >> N1>>N2>> N3>>N4 ;

double N ;
cin>>N ;

N1= N1*2 ;
N2 = N2*3 ;
N3= N3*4 ;
N4= N4*1 ;

double ave=(N1+N2+N3+N4)/(2+3+4+1) ;



if(ave >=7){
cout<<fixed ;
cout<<setprecision(1)<<"Media: "<<ave<<endl;

   cout<<"Aluno aprovado."<<endl;
}
else if (ave<5){
        cout<<fixed ;
cout<<setprecision(1)<<"Media: "<<ave<<endl;
    cout<<"Aluno reprovado."<<endl;

}
else {
        
       cout<<fixed ;
cout<<setprecision(1)<<"Media: "<<ave<<endl; 
     cout<<"Aluno em exame."<<endl;
     
cout<<fixed ;
cout<<"Nota do exame: "<<N <<endl ;

double sum = ave+N ;

double res = sum/2 ;

if(res>=5){
    cout<<"Aluno aprovado." <<endl ;
}
else if ( res<5){
      cout<<"Aluno reprovado." <<endl ;
}

cout<<fixed ;
cout<<setprecision(1) <<"Media final: "<<res<<endl  ;

}




}

