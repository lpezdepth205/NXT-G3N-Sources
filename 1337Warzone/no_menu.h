#pragma once
#include "no_dmu.h"
/*
androidgui::color ColorChange(float variable)
{
	float Color[3];
	float color_red = 1, color_green = 0, color_blue = 0;
	ImGui::ColorConvertRGBtoHSV(color_red, color_green, color_blue, Color[0], Color[1], Color[2]);
	Color[0] = 0.001f * variable; if (Color[0] < 0.0f) Color[0] += 1.0f;
	ImGui::ColorConvertHSVtoRGB(Color[0], Color[1], Color[2], color_red, color_green, color_blue);
	return androidgui::color{ (int)(color_red * 255), (int)(color_green * 255), (int)(color_blue * 255), 255 };
}



namespace UI_Colors {
	namespace ESP {
		void ESPBoxColor(bool boolean) {
			static int ESPBoxColor;
			androidgui::same_line();
			androidgui::separator(-13, true);
			androidgui::slider_colored_int(xorstr("ESP Box Color"), SettingsColor::ESPBox, 1, 1000, ESPBoxColor, boolean);
			SettingsColor::ESPBox = ColorChange(ESPBoxColor);
			androidgui::separator(-6, true);
			androidgui::backup_line();
		}
		
		void ESPLinesColor(bool boolean) {
			static int ESPLinesColor;
			androidgui::same_line();
			androidgui::separator(-13, true);
			androidgui::slider_colored_int(xorstr("ESP Lines Color"), SettingsColor::ESPLines, 1, 1000, ESPLinesColor, boolean);
			SettingsColor::ESPLines = ColorChange(ESPLinesColor);
			androidgui::separator(-6, true);
			androidgui::backup_line();
		}

		void ESPNameColor(bool boolean) {
			static int ESPNameColor;
			androidgui::same_line();
			androidgui::separator(-13, true);
			androidgui::slider_colored_int(xorstr("ESP Names Color"), SettingsColor::ESPNames, 1, 1000, ESPNameColor, boolean);
			SettingsColor::ESPNames = ColorChange(ESPNameColor);
			androidgui::separator(-6, true);
			androidgui::backup_line();
		}

		void ESPDistanceColor(bool boolean) {
			static int ESPDistanceColor;
			androidgui::same_line();
			androidgui::separator(-13, true);
			androidgui::slider_colored_int(xorstr("ESP Distance Color"), SettingsColor::ESPDistance, 1, 1000, ESPDistanceColor, boolean);
			SettingsColor::ESPDistance = ColorChange(ESPDistanceColor);
			androidgui::separator(-6, true);
			androidgui::backup_line();
		}
	}
}
*/
static const char* ESP_Box_TypeItems[] {
	"Box",
	"Cornered",
	"3D Box"
};

bool Unlocker_Injected = false;
//bool bGiveLevel1000 = false;
//bool bMaxAllWeapons = false;
//bool bDoAllChallenges = false;
bool ShowTheMenu = true;




void ColorAndStyle() {
	ImGuiStyle* style = &ImGui::GetStyle();

	style->WindowPadding = ImVec2(15, 15);
	style->WindowRounding = 5.0f;
	style->FramePadding = ImVec2(4.5f, 2.5f);
	style->FrameRounding = 0.0f;
	style->ItemSpacing = ImVec2(12, 8);

	style->WindowTitleAlign = ImVec2(0.5f, 0.5f);
	style->IndentSpacing = 25.0f;


	//Tabs
	style->ItemInnerSpacing = ImVec2(18, 6);
	style->TabRounding = 0.0f;

	style->ScrollbarSize = 0.0f;
	style->ScrollbarRounding = 0.0f;

	//Sliders
	style->GrabMinSize = 6.0f;
	style->GrabRounding = 0.0f;


	style->Colors[ImGuiCol_Text] = ImVec4(0.80f, 0.80f, 0.83f, 1.00f);
	style->Colors[ImGuiCol_TextDisabled] = ImVec4(0.24f, 0.23f, 0.29f, 1.00f);
	style->Colors[ImGuiCol_WindowBg] = ImColor(27, 26, 35, 255);
	style->Colors[ImGuiCol_PopupBg] = ImVec4(0.07f, 0.07f, 0.09f, 1.00f);
	style->Colors[ImGuiCol_Border] = ImVec4(0, 0, 0, 0);
	style->Colors[ImGuiCol_BorderShadow] = ImVec4(0, 0, 0, 0);
	style->Colors[ImGuiCol_FrameBg] = ImColor(37, 38, 51, 255);
	style->Colors[ImGuiCol_FrameBgHovered] = ImColor(42, 43, 56, 255);
	style->Colors[ImGuiCol_FrameBgActive] = ImColor(37, 38, 51, 255);


	style->Colors[ImGuiCol_Tab] = ImColor(27, 26, 35, 255);
	style->Colors[ImGuiCol_TabActive] = ImColor(79, 79, 81, 255);
	style->Colors[ImGuiCol_TabHovered] = ImColor(62, 62, 66, 255);

	style->Colors[ImGuiCol_TitleBg] = ImColor(27, 26, 35, 255);
	style->Colors[ImGuiCol_TitleBgCollapsed] = ImColor(37, 38, 51, 40);
	style->Colors[ImGuiCol_TitleBgActive] = ImColor(37, 38, 51, 255);

	style->Colors[ImGuiCol_MenuBarBg] = ImVec4(0.10f, 0.09f, 0.12f, 1.00f);
	style->Colors[ImGuiCol_ScrollbarBg] = ImVec4(0.10f, 0.09f, 0.12f, 1.00f);
	style->Colors[ImGuiCol_ScrollbarGrab] = ImVec4(0.80f, 0.80f, 0.83f, 0.31f);
	style->Colors[ImGuiCol_ScrollbarGrabHovered] = ImVec4(0.56f, 0.56f, 0.58f, 1.00f);
	style->Colors[ImGuiCol_ScrollbarGrabActive] = ImVec4(0.06f, 0.05f, 0.07f, 1.00f);
	style->Colors[ImGuiCol_CheckMark] = ImColor(255, 255, 255, 255);
	style->Colors[ImGuiCol_SliderGrab] = ImColor(79, 79, 81, 255);
	style->Colors[ImGuiCol_SliderGrabActive] = ImColor(79, 79, 81, 255);
	style->Colors[ImGuiCol_Button] = ImColor(79, 79, 81, 255);
	style->Colors[ImGuiCol_ButtonHovered] = ImColor(79, 79, 81, 255);
	style->Colors[ImGuiCol_ButtonActive] = ImColor(84, 84, 86, 255);
	style->Colors[ImGuiCol_Header] = ImVec4(0.10f, 0.09f, 0.12f, 1.00f);
	style->Colors[ImGuiCol_HeaderHovered] = ImVec4(0.56f, 0.56f, 0.58f, 1.00f);
	style->Colors[ImGuiCol_HeaderActive] = ImVec4(0.06f, 0.05f, 0.07f, 1.00f);
	style->Colors[ImGuiCol_ResizeGrip] = ImVec4(0.00f, 0.00f, 0.00f, 0.00f);
	style->Colors[ImGuiCol_ResizeGripHovered] = ImVec4(0.56f, 0.56f, 0.58f, 1.00f);
	style->Colors[ImGuiCol_ResizeGripActive] = ImVec4(0.06f, 0.05f, 0.07f, 1.00f);
	style->Colors[ImGuiCol_PlotLines] = ImVec4(0.40f, 0.39f, 0.38f, 0.63f);
	style->Colors[ImGuiCol_PlotLinesHovered] = ImVec4(0.25f, 1.00f, 0.00f, 1.00f);
	style->Colors[ImGuiCol_PlotHistogram] = ImVec4(0.40f, 0.39f, 0.38f, 0.63f);
	style->Colors[ImGuiCol_PlotHistogramHovered] = ImVec4(0.25f, 1.00f, 0.00f, 1.00f);
	style->Colors[ImGuiCol_TextSelectedBg] = ImVec4(0.25f, 1.00f, 0.00f, 0.43f);
}



bool Menu_Init() {

	if (GetAsyncKeyState(VK_INSERT) & 1) {
		ShowTheMenu = !ShowTheMenu;
	}


	if (ShowTheMenu) {


		ImGuiStyle* style = &ImGui::GetStyle();
		//ImGui::SetNextWindowSize({ 709, 470 });
		ImGui::SetNextWindowSize({ 709, 370 });

		
		ColorAndStyle();

		
		ImGui::Begin(xorstr("NXT-GEN Warzone ESP, Aimbot, Unlock All, Bot Lobbies | NXTG3N#9345 & android#1337"), &ShowTheMenu, ImGuiWindowFlags_NoResize);                          // Create a window called "Hello, world!" and append into it.



		 if (ImGui::BeginTabBar(xorstr("blah")))
		 {




			 if (ImGui::BeginTabItem(xorstr("Aimbot"))) {
				 //if (!Settings::RainbowMode) {
				//	 ImGui::Columns(2);
				 //}
				 ImGui::Text(xorstr("Aimbot"));
				 ImGui::Checkbox(xorstr("Enable Aimbot"), &Settings::Aimbot);
				 if (Settings::Aimbot) {
					 ImGui::PushItemWidth(200);
					 style->GrabMinSize = 2.0f;
					 ImGui::SliderInt(xorstr("Aimbot Smooth"), &Settings::smooth, 1, 20);
					 style->GrabMinSize = 6.0f;
					 ImGui::SameLine();
					 ImGui::TextColored(ImColor(255, 231, 94, 255), xorstr("[?]"));
					 if (ImGui::IsItemHovered()) {
						 ImGui::BeginTooltip();
						 ImGui::Text(xorstr("Aimbot Smooth: It depends on your sensivity."));
						 ImGui::EndTooltip();
					 }

					 ImGui::SliderInt(xorstr("Fov Circle Value"), &Settings::FovCircleValue, 30, 800);

				 }

				 if (!Settings::RainbowMode) {
					 //ImGui::NextColumn();
					 ImGui::Text(xorstr("Colors"));
					 ImGui::ColorEdit4(xorstr("Fov Circle"), SettingsColor::FovColor_float, ImGuiColorEditFlags_NoInputs);
					 //ImGui::NextColumn();
				 }

				 ImGui::EndTabItem();
			 }

			 if (ImGui::BeginTabItem(xorstr("ESP"))) {
				 //if (!Settings::RainbowMode) {
				//	 ImGui::Columns(2);
				 //}
				 ImGui::Text(xorstr("ESP"));
				 ImGui::Checkbox(xorstr("Enable ESP"), &Settings::ESP);
				 if (Settings::ESP) {
					 ImGui::Checkbox(xorstr("ESP Box"), &Settings::ESP_Box);
					 if (Settings::ESP_Box) {
						 ImGui::Combo(xorstr("ESP Box Type"), &Settings::ESP_Box_Type, ESP_Box_TypeItems, sizeof(ESP_Box_TypeItems) / sizeof(*ESP_Box_TypeItems));
					 }
					 ImGui::Checkbox(xorstr("ESP Lines"), &Settings::ESP_Lines);
					 ImGui::Checkbox(xorstr("ESP Names"), &Settings::ESP_Names);
					 ImGui::Checkbox(xorstr("ESP Distance"), &Settings::ESP_Distance);
					 ImGui::SliderInt(xorstr("ESP Max Distance"), &Settings::ESP_MaxDistance, 10, 500);



				 }
				 if (!Settings::RainbowMode) {
					 //ImGui::NextColumn();
					 ImGui::Text("Colors");
					 ImGui::ColorEdit4("ESP Box", SettingsColor::ESPBox_float, ImGuiColorEditFlags_NoInputs);
					 ImGui::ColorEdit4("ESP Lines", SettingsColor::ESPLines_float, ImGuiColorEditFlags_NoInputs);
					 ImGui::ColorEdit4("ESP Names", SettingsColor::ESPNames_float, ImGuiColorEditFlags_NoInputs);
					 ImGui::ColorEdit4("ESP Distance", SettingsColor::ESPDistance_float, ImGuiColorEditFlags_NoInputs);
					 //ImGui::NextColumn();
				 }


				 ImGui::EndTabItem();
			 }

			 if (ImGui::BeginTabItem(xorstr("Misc"))) {
				 ImGui::Text(xorstr("Misc"));
				 ImGui::Checkbox(xorstr("Show Fov Circle"), &Settings::ShowFovCircle);
				 ImGui::Checkbox(xorstr("Rainbow Mode"), &Settings::RainbowMode);
				 ImGui::Separator();

				 if (ImGui::Button(xorstr("Unload"))) {
					 system(xorstr("taskkill /f /im mspaint.exe"));
					 exit(0);
				 }
				 ImGui::EndTabItem();
			 }

			 if (ImGui::BeginTabItem(xorstr("Unlock All"))) {


				 if (Unlocker_Injected == false) {
					 ImGui::Text("Unlock All");
					 ImGui::Text("Info: When this menu freeze wait 5 seconds and press F2");

					 if (ImGui::Button(xorstr("Give Level 1000"))) {
						 if (no_dmu::DmuInit(true, false, false) == false) {
							 MessageBoxA(NULL, "Error", "Error", MB_OK);
						 }
					 }
					 if (ImGui::Button(xorstr("Max All Weapons"))) {
						 if (no_dmu::DmuInit(false, true, false) == false) {
							 MessageBoxA(NULL, "Error", "Error", MB_OK);
						 }
					 }
					 if (ImGui::Button(xorstr("Do All Challenges"))) {
						 if (no_dmu::DmuInit(false, false, true) == false) {
							 MessageBoxA(NULL, "Error", "Error", MB_OK);
						 }
					 }
				 }
				 if (Unlocker_Injected == true) {
					 ImGui::Text(xorstr("Unlocker Already Injected"));
				 }

				 ImGui::EndTabItem();
			 }

			 if (ImGui::BeginTabItem(xorstr("Bot Lobbies"))) {

				 ImGui::Text("Coming soon...");

				 ImGui::EndTabItem();
			 }


			 if (ImGui::BeginTabItem(xorstr("Info"))) {

				 if (ImGui::Button(xorstr("Youtube"))) {
					 system("start https://www.youtube.com/channel/UCQJjN_MpPd0jM2l2D_HLN6A");
				 }

				 if (ImGui::Button(xorstr("Discord"))) {
					 system("start https://discord.gg/bTckPfzRVv");
				 }

				 ImGui::EndTabItem();
			 }



			 ImGui::EndTabBar();
		 }


		 ImGui::End();


	}


	SettingsColor::FovColor = { SettingsColor::FovColor_float[0], SettingsColor::FovColor_float[1], SettingsColor::FovColor_float[2], SettingsColor::FovColor_float[3] };
	SettingsColor::ESPBox = { SettingsColor::ESPBox_float[0], SettingsColor::ESPBox_float[1], SettingsColor::ESPBox_float[2], SettingsColor::ESPBox_float[3] };
	SettingsColor::ESPLines = { SettingsColor::ESPLines_float[0], SettingsColor::ESPLines_float[1], SettingsColor::ESPLines_float[2], SettingsColor::ESPLines_float[3] };
	SettingsColor::ESPNames = { SettingsColor::ESPNames_float[0], SettingsColor::ESPNames_float[1], SettingsColor::ESPNames_float[2], SettingsColor::ESPNames_float[3] };
	SettingsColor::ESPDistance = { SettingsColor::ESPDistance_float[0], SettingsColor::ESPDistance_float[1], SettingsColor::ESPDistance_float[2], SettingsColor::ESPDistance_float[3] };


	return true;
}