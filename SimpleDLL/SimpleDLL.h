
#ifdef SIMPLEDLL_EXPORTS
#define SIMPLEDLL_API __declspec(dllexport)
#else
#define SIMPLEDLL_API __declspec(dllimport)
#endif

#include <stdint.h>

extern "C"
{
	//Pass two integer values and get integer
	SIMPLEDLL_API int32_t SumTwoIntegers(int32_t number1, int32_t number2);

	//Pass a number by reference (pointer)
	SIMPLEDLL_API void MultiplyByTwo(int32_t* originalNumber);

	//Pass a unicode strings, return its length
	SIMPLEDLL_API int32_t GetNameLength(const wchar_t* name);

	//Pass two unicode strings, return string
	SIMPLEDLL_API wchar_t* GetFullName(const wchar_t* firstName, const wchar_t* lastName);
};
