#pragma once




bool Draw_Init(ImDrawList* MSPaintHook) {

	ImU32 FovColor = ImGui::GetColorU32({ 255, 0, 0, 255 });
	
    

	//FOV CIRCLE
	if(Settings::ShowFovCircle)
		MSPaintHook->AddCircle(ImVec2(No_Renderer_Define::Width / 2, No_Renderer_Define::Height / 2), Settings::FovCircleValue, Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::FovColor, 0);


	MSPaintHook->AddText(ImVec2(20, 20), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::FovColor, xorstr("NXT-GEN Warzone ESP, Aimbot, Unlock All, Bot Lobbies | NXTG3N#9345 & android#1337"));

	return true;
}