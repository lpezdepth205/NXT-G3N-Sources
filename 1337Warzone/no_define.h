#pragma once

namespace No_Define {
	HANDLE ProcessID;
	uintptr_t BaseAddress;
	uint64_t PEB;
}

namespace No_Renderer_Define {
	int Width = GetSystemMetrics(SM_CXSCREEN);
	int Height = GetSystemMetrics(SM_CYSCREEN);
}

namespace Settings {
	bool Aimbot = false;
	int smooth = 1.0f;
	bool ESP = false;
	bool ESP_Box = false;
	int ESP_Box_Type = 1;
	bool ESP_Lines = false;
	bool ESP_Names = false;
	bool ESP_Distance = false;
	int ESP_MaxDistance = 300;
	bool ShowFovCircle = true;
	int FovCircleValue = 100;
	bool ConstantUav = false;
	bool RainbowMode = false;
}

namespace SettingsColor {
	ImColor ESPBox = {255, 255, 255, 200 };
	float ESPBox_float[4] = { 255, 255, 255, 200 };


	ImColor ESPLines = { 255, 255, 255, 200 };
	float ESPLines_float[4] = { 255, 255, 255, 200 };


	ImColor ESPNames = { 255, 0, 0, 255 };
	float ESPNames_float[4] = { 255, 0, 0, 255 };

	ImColor ESPDistance = { 255, 255, 255, 200 };
	float ESPDistance_float[4] = { 255, 255, 255, 200 };

	ImColor FovColor = { 255, 255, 255, 200 };
	float FovColor_float[4] = { 255, 255, 255, 200 };

	ImColor RainbowColorCool;

}

namespace Addresses {
	uint64_t INFO;
	uint64_t BASE;
	uint64_t REFDEF;
	uint64_t NAMES;
}

#include "no_draw.h"
#include "no_menu.h"
