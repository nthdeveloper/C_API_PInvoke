#define J2KNATIVESOURCE_API __declspec(dllexport)

#include <stdint.h>

extern "C"
{
	//Pass two integer values and get integer
	J2KNATIVESOURCE_API int32_t SumTwoIntegers(int32_t number1, int32_t number2);

	//Pass a number by reference (pointer)
	J2KNATIVESOURCE_API void MultiplyByTwo(int32_t* originalNumber);

	//Pass a unicode strings, return its length
	J2KNATIVESOURCE_API int32_t GetNameLength(const wchar_t* name);

	//Pass two unicode strings, return string
	J2KNATIVESOURCE_API wchar_t* GetFullName(const wchar_t* firstName, const wchar_t* lastName);
};
