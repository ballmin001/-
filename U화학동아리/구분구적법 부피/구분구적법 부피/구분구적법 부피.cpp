/**************************************************************************************
	
	구분구적법 -부피
	함수: y=sqrt(x);
	구간: [1,0]

***************************************************************************************/



#include <stdio.h>
#include <math.h>
#include <conio.h>
#include <Windows.h>
#include <ctype.h>

#define pi 3.141592

void start();
void ku(int n); //구분구적 함수
double fx(double x); //적분할 함수 (y=√x)

int main()
{
	start();
/*
	if (kbhit())
	{
		if (getch() == 'q')
		{
			return 0;
		}
		else start();
	}
	else start();
*/
/*	printf("\n종료하려면 아무키나 누르세요 . . .");
#pragma warning(suppress : 4996)
*/

	system("pause");
}

void start()
{
	int n = 0;

	printf("\n 구간: [0,1]  \n 함수: y=√x\n ");

	printf("등분할 횟수 입력 (0~99999) >>");
	scanf_s("%d", &n);
	//printf("%d", n);
	/*
	if (isalpha('n') || isspace('n') || ispunct('n') || iscntrl('n') )
	{
		printf("숫자를 입력해 주세요");
	}
	*/
	ku(n);
}

void ku(int n)
{

	double Sum = 0; //합
	double x[100000] = {}; //x값들이 들어가는 배열
	double dx = 1.0 / n; //델타 x

	//printf("dx=%g \n", dx); //+++++++++++++++++++++++++++++++++++++++++++++++++++ 델타x 보기

	for (int i = 1; i<=n; i++) 
	{
		double temp = 0;
		x[i] = dx * i; //구간 나눠서 x배열에 저장하고
	//	printf("X%d=%g ", i,x[i]); //++++++++++++++++++++++++++++++++++++++++++++ x값 보기

		Sum+= pi * pow(fx(x[i]), 2.0) * dx; //함수에 넣어서 합 구하기++ Sum=πf(x_ie)^2


	//	printf("Sum=%g \n", Sum); //+++++++++++++++++++++++++++++++++++++++++++++ Sum 보기
	}
	
	printf("\n\n∴부피=%g\n\n", Sum);
	printf("실제 값과 비교하세요 정적분을 이용해 구한 부피 =1.57079\n");
}

double fx(double x)
{
	double y=0;
	y = sqrt(x); // y=√x
	return y;
}