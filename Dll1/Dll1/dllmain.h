typedef struct _Employer1Struct
{
    wchar_t name[100];
    wchar_t post[100];
    wchar_t company[100];
    int exp;
    int capital;
    int salary;
} Employer1Struct;
typedef struct _Employer2Struct
{
    wchar_t name[100];
    wchar_t post[100];
    wchar_t company[100];
    int socialraiting;
    int salary;
} Employer2Struct;
typedef struct _Employer3Struct
{
    wchar_t name[100];
    wchar_t post[100];
    wchar_t company[100];
    int exp;
    int salary;
    int age;
} Employer3Struct;

#pragma once	
extern "C" __declspec(dllexport) bool InputEmployer1(Employer1Struct * ptr);
extern "C" __declspec(dllexport) bool OutputEmployer1(Employer1Struct * ptr);
extern "C" __declspec(dllexport) bool InputEmployer2(Employer2Struct * ptr);
extern "C" __declspec(dllexport) bool OutputEmployer2(Employer2Struct * ptr);
extern "C" __declspec(dllexport) bool InputEmployer3(Employer3Struct * ptr);
extern "C" __declspec(dllexport) bool OutputEmployer3(Employer3Struct * ptr);
extern "C" __declspec(dllexport) bool InputStr(wchar_t*, int length);
extern "C" __declspec(dllexport) int InputInt();
extern "C" __declspec(dllexport) bool OutputStr(wchar_t*, int length);
extern "C" __declspec(dllexport) bool OutputInt(int num);