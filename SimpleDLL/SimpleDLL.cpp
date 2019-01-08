// SimpleDLL.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "SimpleDLL.h"


J2KNATIVESOURCE_API int32_t SumTwoIntegers(int32_t number1, int32_t number2)
{
	return number1 + number2;
}

J2KNATIVESOURCE_API void MultiplyByTwo(int32_t* originalNumber)
{
	(*originalNumber) = (*originalNumber) * 2;
}

