#define J2KNATIVESOURCE_API __declspec(dllexport)

#include <stdint.h>

extern "C"
{
	//Pass two integer values and get integer
	J2KNATIVESOURCE_API int32_t SumTwoIntegers(int32_t number1, int32_t number2);

	//Pass a number by reference (pointer)
	J2KNATIVESOURCE_API void MultiplyByTwo(int32_t* originalNumber);
};
