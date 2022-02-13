#include <iostream>
#include <Windows.h>
#include <future>
#include "connection.h"
#include "no_renderer.h"
#include <csignal>
#include <cstdlib>
#include <signal.h>
#include "no_loader/no_kdmapper/no_mapper.hpp"
#include "xor.h"

#pragma warning(disable : 4996)
using namespace std;


void InitLogin() {




    std::cout << "\n";
    std::cout << xorstr("  Initializing..") << "\n\n";
    //system(xorstr("start mspaint.exe"));
    //Sleep(1000);
    //Init_Renderer();

    //Init_Renderer();

    if (no_auth::initauth()) {
        std::cout << "\n";
        std::cout << xorstr("  Step 1: Loading..") << "\n\n";
        
        no_auth::checkauth();
        system(xorstr("cls"));

        

        std::cout << "\n";
        std::cout << xorstr("  Step 1: Completed.") << "\n\n";
        std::cout << xorstr("  Step 2: Loading..") << "\n\n";

        Sleep(500);
        if (kdmapper::InitializeDriver()) {

            system(xorstr("cls"));
            std::cout << "\n";
            std::cout << xorstr("  Step 1: Completed.") << "\n\n";
            std::cout << xorstr("  Step 2: Completed.") << "\n\n";
        }
        else {
            system(xorstr("cls"));
            std::cout << "\n";
            std::cout << xorstr("  Step 1: Completed.") << "\n\n";
            std::cout << xorstr("  Step 2: Failed.") << "\n\n";
            Sleep(3000);
            exit(0);
        }


        
        std::cout << xorstr("  Step 3: Loading..") << "\n\n";
        Sleep(500);
        system(xorstr("taskkill /f /im mspaint.exe"));

        system(xorstr("cls"));

        system(xorstr("start mspaint.exe"));


        system(xorstr("cls"));

        std::cout << "\n";
        std::cout << xorstr("  Step 1: Completed.") << "\n\n";
        std::cout << xorstr("  Step 2: Completed.") << "\n\n";
        std::cout << xorstr("  Step 3: Completed.") << "\n\n\n";

        Sleep(500);


        std::cout << xorstr("  Open warzone and when in lobby press F2. DON'T CLOSE PAINT!") << "\n";


        while (true) {
            if (GetAsyncKeyState(VK_F2) & 1) {
                break;
            }
        }

        ::ShowWindow(::GetConsoleWindow(), SW_HIDE);
        Init_Renderer();
    }
}



int main()
{

    InitLogin();

    auto ext = [](int i) { system("taskkill /f /im mspaint.exe"); exit(0);  };

    signal(SIGINT, ext);
    signal(SIGABRT, ext);
    signal(SIGTERM, ext);

    while (true) { Sleep(500000); }

    Unload_Renderer();

    return 0;
}