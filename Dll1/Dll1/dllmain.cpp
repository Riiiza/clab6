// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "pch.h"
#include <iostream>
#include "dllmain.h"

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

__declspec(dllexport)
bool InputEmployer1(Employer1Struct* ptr)
{
    printf("Enter name, post, company, exp, capital, salary: \n");
    wscanf_s(L"%s %s %s %d %d %d", ptr->name, 100, ptr->post, 100, ptr->company, 100, &ptr->exp, &ptr->capital, &ptr->salary);
    return TRUE;
}

__declspec(dllexport)
bool OutputEmployer1(Employer1Struct* ptr)
{
    wprintf_s(L"%s %s %s %d %d %d", ptr->name, ptr->post, ptr->company, &ptr->exp, &ptr->capital, &ptr->salary);
    return TRUE;
}

__declspec(dllexport)
bool InputEmployer2(Employer2Struct* ptr)
{
    printf("Enter name, post, company, socialraiting, salary: \n");
    wscanf_s(L"%s %s %s %d %d", ptr->name, 100, ptr->post, 100, ptr->company, 100, &ptr->socialraiting, &ptr->salary);
    return TRUE;
}

__declspec(dllexport)
bool OutputEmployer2(Employer2Struct* ptr)
{
    wprintf_s(L"%s %s %s %d %d", ptr->name, ptr->post, ptr->company, &ptr->socialraiting, &ptr->salary);
    return TRUE;
}

__declspec(dllexport)
bool InputEmployer3(Employer3Struct* ptr)
{
    printf("Enter name, post, company, exp, salary, age: \n");
    wscanf_s(L"%s %s %s %d %d %d", ptr->name, 100, ptr->post, 100, ptr->company, 100, &ptr->exp, &ptr->salary, &ptr->age);
    return TRUE;
}
__declspec(dllexport)
bool OutputEmployer3(Employer3Struct* ptr)
{
    wprintf_s(L"%s %s %s %d %d %d", ptr->name, ptr->post, ptr->company, &ptr->exp, &ptr->salary, &ptr->age);
    return TRUE;
}
__declspec(dllexport)
bool InputStr(wchar_t* src, int length)
{
    wscanf_s(L"%s", src, length);
    return TRUE;
}

__declspec(dllexport)
int InputInt()
{
    int num;
    scanf_s("%d", &num);
    return num;
}

__declspec(dllexport)
bool OutputStr(wchar_t* src, int length)
{
    wprintf_s(L"%s ", src, length);
    return TRUE;
}

__declspec(dllexport)
bool OutputInt(int num)
{
    wprintf_s(L"%d ", num);
    return TRUE;
}
