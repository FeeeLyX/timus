#include <iostream>

using namespace std;

int main()
{
 int number;
 cin>>number;
 if(number<5)
  cout<<"few";
 else if(number<10)
  cout<<"several";
 else if(number<20)
  cout<<"pack";
 else if(number<50)
  cout<<"lots";
 else if(number<100)
  cout<<"horde";
 else if(number<250)
  cout<<"throng";
 else if(number<500)
  cout<<"swarm";
 else if(number<1000)
  cout<<"zounds";
 else
  cout<<"legion";
 return 0;
}
