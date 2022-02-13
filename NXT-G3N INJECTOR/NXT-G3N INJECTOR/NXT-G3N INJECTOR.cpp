#include <iostream>
#include <Windows.h>
#include <TlHelp32.h>
#include <urlmon.h>
#include <fstream>

#pragma comment(lib, "urlmon.lib")

#define BLACK            0
#define BLUE            1
#define GREEN            2
#define CYAN            3
#define RED                4
#define MAGENTA            5
#define BROWN            6
#define LIGHTGRAY        7
#define DARKGRAY        8
#define LIGHTBLUE        9
#define LIGHTGREEN        10
#define LIGHTCYAN        11
#define LIGHTRED        12
#define LIGHTMAGENTA    13
#define YELLOW            14
#define WHITE            15

using namespace std;

void HideCursor()
{
    HANDLE consoleHandle = GetStdHandle(STD_OUTPUT_HANDLE);
    CONSOLE_CURSOR_INFO info;
    info.dwSize = 100;
    info.bVisible = FALSE;
    SetConsoleCursorInfo(consoleHandle, &info);
}

void HideConsole()
{
    ::ShowWindow(::GetConsoleWindow(), SW_HIDE);
}

void ShowConsole()
{
    ::ShowWindow(::GetConsoleWindow(), SW_SHOW);
}

DWORD GetProcId(const char* procName)
{
    DWORD procId = 0;
    HANDLE hSnap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);

    if (hSnap != INVALID_HANDLE_VALUE)
    {
        PROCESSENTRY32 procEntry;
        procEntry.dwSize = sizeof(procEntry);

        if (Process32First(hSnap, &procEntry))
        {
            do
            {
                if (!_stricmp(procEntry.szExeFile, procName))
                {
                    procId = procEntry.th32ProcessID;
                    break;
                }
            } while (Process32Next(hSnap, &procEntry));
        }
    }
    CloseHandle(hSnap);
    return procId;
}

int main()
{
    HideCursor();
    HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
    string dlBL = "https://cdn.discordapp.com/attachments/924784008997503086/935349095697096774/Universal-ImGui-Hook.dlll";
    string spBL = "C:\\Program Files\\Windows NT\\Universal-ImGui-Hook.dll";
    const char* dllPath = "C:\\Program Files\\Windows NT\\Universal-ImGui-Hook.dll";
    const char* procName = "ModernWarfare.exe";
    DWORD procId = 0;
    remove(dllPath);

    SetConsoleTextAttribute(h, YELLOW);
    while (!procId)
    {
        printf("\r                     ");
        printf("\rWaiting for game");
        Sleep(500);
        printf("\r                     ");
        printf("\rWaiting for game.");
        Sleep(500);
        printf("\r                     ");
        printf("\rWaiting for game..");
        Sleep(500);
        printf("\r                     ");
        printf("\rWaiting for game...");
        Sleep(500);
        procId = GetProcId(procName);
    }

    if (procId)
    {
        printf("\r                     ");
        SetConsoleTextAttribute(h, GREEN);
        printf("\rGAME FOUND!\n");
        Sleep(2000);
        SetConsoleTextAttribute(h, RED);
        printf("\r                          ");
        printf("\rNOW INJECTING");
        Sleep(500);
        printf("\r                          ");
        printf("\rNOW INJECTING.");
        Sleep(500);
        printf("\r                          ");
        printf("\rNOW INJECTING..");
        Sleep(500);
        printf("\r                          ");
        printf("\rNOW INJECTING...");
        Sleep(500);
        printf("\r                          ");
        printf("\rNOW INJECTING");
        Sleep(500);
        printf("\r                          ");
        printf("\r{INJECTED}");
        Sleep(500);
        printf("\r                          ");
        printf("\r{ENJOY USING NXT-G3N SOFTWARE}..");
        Sleep(2000);
        HideConsole();
    }

    URLDownloadToFileA(NULL, dlBL.c_str(), spBL.c_str(), 0, NULL);
    ifstream f(dllPath);
    if (f.fail())
    {
        printf("Unable to download necessary files.");
        system("pause");
    }

    HANDLE hProc = OpenProcess(PROCESS_ALL_ACCESS, 0, procId);

    if (hProc && hProc != INVALID_HANDLE_VALUE)
    {
        void* loc = VirtualAllocEx(hProc, 0, MAX_PATH, MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

        if (loc)
        {
            WriteProcessMemory(hProc, loc, dllPath, strlen(dllPath) + 1, 0);
        }

        HANDLE hThread = CreateRemoteThread(hProc, 0, 0, (LPTHREAD_START_ROUTINE)LoadLibraryA, loc, 0, 0);

        if (hThread)
        {
            CloseHandle(hThread);
        }
    }

    if (hProc)
    {
        CloseHandle(hProc);
    }

    MessageBoxA(nullptr, "INJECTED", "NXT-G3N - SOFTWARE", MB_OK | MB_APPLMODAL);
}