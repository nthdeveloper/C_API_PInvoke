// SimpleDLL.cpp : Defines the exported functions for the DLL application.
//
#include <string.h>
#include "stdafx.h"
#include "SimpleDLL.h"

SIMPLEDLL_API int32_t SumTwoIntegers(int32_t number1, int32_t number2)
{
	return number1 + number2;
}

SIMPLEDLL_API void MultiplyByTwo(int32_t* originalNumber)
{
	(*originalNumber) = (*originalNumber) * 2;
}

SIMPLEDLL_API int32_t GetNameLength(const wchar_t* name)
{
	return (int32_t)wcslen(name);
}

SIMPLEDLL_API wchar_t* GetFullName(const wchar_t* firstName, const wchar_t* lastName)
{
	size_t firstNameLength = wcslen(firstName);
	size_t lastNameLength = wcslen(lastName);

	int fullNameSize = firstNameLength + lastNameLength + 2;

	wchar_t* fullName = (wchar_t*)GlobalAlloc(GPTR, sizeof(wchar_t) * fullNameSize);

	wcsncat(fullName, firstName, firstNameLength);
	wcsncat(fullName, L" ", 1);
	wcsncat(fullName, lastName, lastNameLength);

	return fullName;
}

SIMPLEDLL_API void ModifyStruct(SampleStruct* pStruct)
{
	pStruct->ANumber = 5;
	pStruct->AnEnum = SampleEnum::SampleOption2;
	pStruct->AnArray[0] = 15;
}

SIMPLEDLL_API void CallPassedFunction(ProgressCallback func)
{
	func(1);
	func(5);
	//...
	func(100);
}


