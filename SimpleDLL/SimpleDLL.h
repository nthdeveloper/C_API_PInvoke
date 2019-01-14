
#ifdef SIMPLEDLL_EXPORTS
#define SIMPLEDLL_API __declspec(dllexport)
#else
#define SIMPLEDLL_API __declspec(dllimport)
#endif

#include <stdint.h>

extern "C"
{
	enum SampleEnum
	{
		SampleOption1,
		SampleOption2
	};

	struct SampleStruct
	{
		int32_t ANumber;
		SampleEnum AnEnum;
		int AnArray[2];
	};

	//Get two integer values and return integer
	SIMPLEDLL_API int32_t SumTwoIntegers(int32_t number1, int32_t number2);

	//Get a number by reference (pointer)
	SIMPLEDLL_API void MultiplyByTwo(int32_t* originalNumber);

	//Get a unicode string, return its length
	SIMPLEDLL_API int32_t GetNameLength(const wchar_t* name);

	//Get two unicode strings, return string
	SIMPLEDLL_API wchar_t* GetFullName(const wchar_t* firstName, const wchar_t* lastName);

	//Get a struct and modify it
	SIMPLEDLL_API void ModifyStruct(SampleStruct* pStruct);
};
