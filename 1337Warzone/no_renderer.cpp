#include <iostream>
#include <Windows.h>
#include <future>
#include <string>
#include <vector>
#include <tlhelp32.h>
#include <d3d9.h>
#include <d3dx9.h>
#include <dwmapi.h>
#pragma comment(lib, "d3d9.lib")
#pragma comment(lib, "d3dx9.lib")
#pragma comment(lib, "dwmapi.lib")
#include "no_renderer/imgui/imgui.h"
#include "no_renderer/imgui/imgui_impl_dx9.h"
#include "no_renderer/imgui/imgui_impl_win32.h"
#include "xor.h"
#include "no_renderer.h"
#include "no_define.h"
#include "no_utils.h"
#include "no_driver.h"

#include "no_vectors.h"
#include "no_offsets.h"
#include "no_framework.h"
#include "no_loop.h"
#include "no_draw.h"
#include "no_menu.h"

#define DIRECTINPUT_VERSION 0x0800

#pragma warning(disable : 4996)
using namespace std;


void Unload_Renderer() {
	system(xorstr("taskkill /f /im mspaint.exe"));
	system(xorstr("explorer.exe"));
	exit(0);
}


int Draw_Width = GetSystemMetrics(SM_CXSCREEN);
int Draw_Height = GetSystemMetrics(SM_CYSCREEN);

IDirect3D9Ex* Draw_pObject = NULL;
IDirect3DDevice9Ex* Draw_pDevice = NULL;
D3DPRESENT_PARAMETERS Draw_pParams = { NULL };
HWND DrawOverlayHWND;

bool FirstTimeOnly = true;

static bool ShowMenuorNot;



HRESULT Renderer_Init() {
	static const MARGINS Margin = { -1 };
	static MSG Message = { NULL };
	DrawOverlayHWND = FindWindow(xorstr("GDI+ Hook Window Class"), xorstr("GDI+ Window (mspaint.exe)"));
	ShowWindow(DrawOverlayHWND, SW_SHOW);
	DwmExtendFrameIntoClientArea(DrawOverlayHWND, &Margin);
	SetWindowLong(DrawOverlayHWND, GWL_EXSTYLE, WS_EX_LAYERED | WS_EX_TOPMOST | WS_EX_TRANSPARENT | WS_EX_TOOLWINDOW);
	ShowWindow(DrawOverlayHWND, SW_SHOW);
	UpdateWindow(DrawOverlayHWND);
	SetWindowPos(DrawOverlayHWND, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE);
	if (FAILED(Direct3DCreate9Ex(D3D_SDK_VERSION, &Draw_pObject))) { Unload_Renderer(); exit(3); }
	D3DPRESENT_PARAMETERS Draw_pParams = { 0 };
	Draw_pParams.Windowed = TRUE;
	Draw_pParams.SwapEffect = D3DSWAPEFFECT_DISCARD;
	Draw_pParams.hDeviceWindow = DrawOverlayHWND;
	Draw_pParams.MultiSampleQuality = D3DMULTISAMPLE_NONE;
	Draw_pParams.BackBufferFormat = D3DFMT_A8R8G8B8;
	Draw_pParams.BackBufferWidth = Draw_Width;
	Draw_pParams.BackBufferHeight = Draw_Height;
	Draw_pParams.PresentationInterval = D3DPRESENT_INTERVAL_ONE;
	Draw_pParams.EnableAutoDepthStencil = TRUE;
	Draw_pParams.AutoDepthStencilFormat = D3DFMT_D16;
	Draw_pParams.PresentationInterval = D3DPRESENT_INTERVAL_IMMEDIATE;
	if (FAILED(Draw_pObject->CreateDeviceEx(D3DADAPTER_DEFAULT, D3DDEVTYPE_HAL, DrawOverlayHWND, D3DCREATE_HARDWARE_VERTEXPROCESSING, &Draw_pParams, 0, &Draw_pDevice))) {
		Draw_pObject->Release(); 
		Unload_Renderer();
		exit(4);
	}
	ImGui::CreateContext();
	ImGui_ImplWin32_Init(DrawOverlayHWND);
	ImGui_ImplDX9_Init(Draw_pDevice);
	Draw_pObject->Release();
	static RECT old_rc;
	ZeroMemory(&Message, sizeof(MSG));
	while (Message.message != WM_QUIT) {
		if (PeekMessage(&Message, DrawOverlayHWND, 0, 0, PM_REMOVE)) {
			TranslateMessage(&Message);
			DispatchMessage(&Message);
		}



		ImGuiIO& io = ImGui::GetIO();

		POINT p;
		GetCursorPos(&p);
		io.MousePos.x = p.x;
		io.MousePos.y = p.y;

		if (GetAsyncKeyState(VK_LBUTTON)) {
			io.MouseDown[0] = true;
			io.MouseClicked[0] = true;
			io.MouseClickedPos[0].x = io.MousePos.x;
			io.MouseClickedPos[0].y = io.MousePos.y;
		}
		else {
			io.MouseDown[0] = false;
		}
			

		if (FirstTimeOnly) {
			Draw_pParams.BackBufferWidth = No_Renderer_Define::Width;
			Draw_pParams.BackBufferHeight = No_Renderer_Define::Height;
			SetWindowPos(DrawOverlayHWND, (HWND)0, 0, 0, Draw_Width, Draw_Height, SWP_NOREDRAW);
			Draw_pDevice->Reset(&Draw_pParams);
		}

		ImGui_ImplDX9_NewFrame();
		ImGui_ImplWin32_NewFrame();
		ImGui::NewFrame();


		Menu_Init();


		auto MSPaintHook = ImGui::GetOverlayDrawList();
		Draw_Init(MSPaintHook);
		if (FirstTimeOnly) {
			std::thread acloop(ActorLoop); acloop.detach();
			FirstTimeOnly = false;
		}
		DrawShitESP(MSPaintHook);
		ImGui::EndFrame();
		Draw_pDevice->Clear(0, NULL, D3DCLEAR_TARGET, D3DCOLOR_ARGB(0, 0, 0, 0), 1.0f, 0);
		if (Draw_pDevice->BeginScene() >= 0) {
			ImGui::Render();
			ImGui_ImplDX9_RenderDrawData(ImGui::GetDrawData());
			Draw_pDevice->EndScene();
		}
		HRESULT result = Draw_pDevice->Present(NULL, NULL, NULL, NULL);
	}
	ImGui_ImplDX9_Shutdown();
	ImGui_ImplWin32_Shutdown();
	ImGui::DestroyContext();
	if (Draw_pDevice != NULL) {
		Draw_pDevice->EndScene();
		Draw_pDevice->Release();
	}
	if (Draw_pObject != NULL) {
		Draw_pObject->Release();
	}
	DestroyWindow(DrawOverlayHWND);
	Unload_Renderer();
	return Message.wParam;
	Unload_Renderer();
	return S_OK;
}

bool Init_Renderer() {
	Renderer_Init();
	return true;
}