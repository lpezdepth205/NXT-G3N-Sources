#pragma once

bool FirstTime = true;




void Aimbot_Function(Vector2 Head_W2S)
{

	if (Head_W2S.y != 0 || Head_W2S.y != 0)
	{
		float ScreenCenterX = (No_Renderer_Define::Width / 2);
		float ScreenCenterY = (No_Renderer_Define::Height / 2);

		float TargetX = 0;
		float TargetY = 0;

		if (Head_W2S.x != 0)
		{
			if (Head_W2S.x > ScreenCenterX)
			{
				TargetX = -(ScreenCenterX - Head_W2S.x);
				TargetX /= Settings::smooth;
				if (TargetX + ScreenCenterX > ScreenCenterX * 2) TargetX = 0;
			}

			if (Head_W2S.x < ScreenCenterX)
			{
				TargetX = Head_W2S.x - ScreenCenterX;
				TargetX /= Settings::smooth;
				if (TargetX + ScreenCenterX < 0) TargetX = 0;
			}
		}

		if (Head_W2S.y != 0)
		{
			if (Head_W2S.y > ScreenCenterY)
			{
				TargetY = -(ScreenCenterY - Head_W2S.y);
				TargetY /= Settings::smooth;
				if (TargetY + ScreenCenterY > ScreenCenterY * 2) TargetY = 0;
			}

			if (Head_W2S.y < ScreenCenterY)
			{
				TargetY = Head_W2S.y - ScreenCenterY;
				TargetY /= Settings::smooth;
				if (TargetY + ScreenCenterY < 0) TargetY = 0;
			}
		}

		mouse_event(MOUSEEVENTF_MOVE, static_cast<DWORD>(TargetX), static_cast<DWORD>(TargetY), NULL, NULL);

		return;
	}
}


void DrawBox(float X, float Y, float W, float H, const ImU32& color)
{
	ImGui::GetOverlayDrawList()->AddRect(ImVec2(X + 1, Y + 1), ImVec2(((X + W) - 1), ((Y + H) - 1)), ImGui::GetColorU32(color));
	ImGui::GetOverlayDrawList()->AddRect(ImVec2(X, Y), ImVec2(X + W, Y + H), ImGui::GetColorU32(color));
}


void ReadAddresses() {
	while (true) {
		Addresses::INFO = GetClientInfo();
		Addresses::BASE = GetClientBase(Addresses::INFO);
		Addresses::REFDEF = GetRefDef();
		Addresses::NAMES = GetNameList();

		Sleep(15000);
	}
}


typedef struct _PlayerInfos
{
	Vector2 HeadPos_W2S;
	Vector2 BottomPos_W2S;
	Vector2 PelvisPos_W2S;
	int distance;
	NameEntry name_entry;
	Box3DContainer Box3dcontainer;
}PlayerInfos;

std::vector<PlayerInfos> PlayerList;



void DrawCorneredBox(int X, int Y, int W, int H, const ImU32& color, int thickness) {
	float lineW = (W / 3);
	float lineH = (H / 5);


	ImGui::GetOverlayDrawList()->AddLine(ImVec2(X, Y), ImVec2(X, Y + lineH), ImGui::GetColorU32(color), thickness);
	ImGui::GetOverlayDrawList()->AddLine(ImVec2(X, Y), ImVec2(X + lineW, Y), ImGui::GetColorU32(color), thickness);
	ImGui::GetOverlayDrawList()->AddLine(ImVec2(X + W - lineW, Y), ImVec2(X + W, Y), ImGui::GetColorU32(color), thickness);
	ImGui::GetOverlayDrawList()->AddLine(ImVec2(X + W, Y), ImVec2(X + W, Y + lineH), ImGui::GetColorU32(color), thickness);
	ImGui::GetOverlayDrawList()->AddLine(ImVec2(X, Y + H - lineH), ImVec2(X, Y + H), ImGui::GetColorU32(color), thickness);
	ImGui::GetOverlayDrawList()->AddLine(ImVec2(X, Y + H), ImVec2(X + lineW, Y + H), ImGui::GetColorU32(color), thickness);
	ImGui::GetOverlayDrawList()->AddLine(ImVec2(X + W - lineW, Y + H), ImVec2(X + W, Y + H), ImGui::GetColorU32(color), thickness);
	ImGui::GetOverlayDrawList()->AddLine(ImVec2(X + W, Y + H - lineH), ImVec2(X + W, Y + H), ImGui::GetColorU32(color), thickness);
}



float colcol_red = 1.;
float colcol_green = 0;
float colcol_blue = 0;
float colcol_speed = -4.0;

void ColorChange()
{
	static float Color[3];
	static DWORD Tickcount = 0;
	static DWORD Tickcheck = 0;
	ImGui::ColorConvertRGBtoHSV(colcol_red, colcol_green, colcol_blue, Color[0], Color[1], Color[2]);
	if (GetTickCount() - Tickcount >= 1)
	{
		if (Tickcheck != Tickcount)
		{
			Color[0] += 0.001f * colcol_speed;
			Tickcheck = Tickcount;
		}
		Tickcount = GetTickCount();
	}
	if (Color[0] < 0.0f) Color[0] += 1.0f;
	ImGui::ColorConvertHSVtoRGB(Color[0], Color[1], Color[2], colcol_red, colcol_green, colcol_blue);
	SettingsColor::RainbowColorCool = ImColor((int)(colcol_red * 255), (int)(colcol_green * 255), (int)(colcol_blue * 255), 255);
}



bool DrawShitESP(ImDrawList* MSPaintHook) {
	if (Settings::RainbowMode) {
		ColorChange();
	}
	
	auto PlayerListCopy = PlayerList;
	for (unsigned long i = 0; i < PlayerListCopy.size(); ++i)
	{
		PlayerInfos CurrentPawn = PlayerListCopy[i];

		if (Framework->IsInScreen(CurrentPawn.HeadPos_W2S, CurrentPawn.BottomPos_W2S, No_Renderer_Define::Width, No_Renderer_Define::Height)) {
			
			float PawnHeight = abs(CurrentPawn.HeadPos_W2S.y - CurrentPawn.BottomPos_W2S.y);
			float PawnWidth = PawnHeight * 0.55;

			//////////////////////////////////////////////////// E S P ////////////////////////////////////////////////////
			//Box
			if (Settings::ESP_Box) {

				if (Settings::ESP_Box_Type == 0) {
					DrawBox(CurrentPawn.HeadPos_W2S.x - (PawnWidth / 2), CurrentPawn.HeadPos_W2S.y, PawnWidth, PawnHeight, ImColor(255, 255, 255));
				}
				else if (Settings::ESP_Box_Type == 1) {
					DrawCorneredBox(CurrentPawn.HeadPos_W2S.x - (PawnWidth / 2), CurrentPawn.HeadPos_W2S.y, PawnWidth, PawnHeight, Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox, 2.0f);
				}
				else if (Settings::ESP_Box_Type == 2) {
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.bottom1.x, CurrentPawn.Box3dcontainer.bottom1.y), ImVec2(CurrentPawn.Box3dcontainer.top1.x, CurrentPawn.Box3dcontainer.top1.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.bottom2.x, CurrentPawn.Box3dcontainer.bottom2.y), ImVec2(CurrentPawn.Box3dcontainer.top2.x, CurrentPawn.Box3dcontainer.top2.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.bottom3.x, CurrentPawn.Box3dcontainer.bottom3.y), ImVec2(CurrentPawn.Box3dcontainer.top3.x, CurrentPawn.Box3dcontainer.top3.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.bottom4.x, CurrentPawn.Box3dcontainer.bottom4.y), ImVec2(CurrentPawn.Box3dcontainer.top4.x, CurrentPawn.Box3dcontainer.top4.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);

					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.bottom1.x, CurrentPawn.Box3dcontainer.bottom1.y), ImVec2(CurrentPawn.Box3dcontainer.bottom2.x, CurrentPawn.Box3dcontainer.bottom2.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.bottom2.x, CurrentPawn.Box3dcontainer.bottom2.y), ImVec2(CurrentPawn.Box3dcontainer.bottom3.x, CurrentPawn.Box3dcontainer.bottom3.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.bottom3.x, CurrentPawn.Box3dcontainer.bottom3.y), ImVec2(CurrentPawn.Box3dcontainer.bottom4.x, CurrentPawn.Box3dcontainer.bottom4.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.bottom4.x, CurrentPawn.Box3dcontainer.bottom4.y), ImVec2(CurrentPawn.Box3dcontainer.bottom1.x, CurrentPawn.Box3dcontainer.bottom1.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);

					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.top1.x, CurrentPawn.Box3dcontainer.top1.y), ImVec2(CurrentPawn.Box3dcontainer.top2.x, CurrentPawn.Box3dcontainer.top2.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.top2.x, CurrentPawn.Box3dcontainer.top2.y), ImVec2(CurrentPawn.Box3dcontainer.top3.x, CurrentPawn.Box3dcontainer.top3.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.top3.x, CurrentPawn.Box3dcontainer.top3.y), ImVec2(CurrentPawn.Box3dcontainer.top4.x, CurrentPawn.Box3dcontainer.top4.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);
					ImGui::GetOverlayDrawList()->AddLine(ImVec2(CurrentPawn.Box3dcontainer.top4.x, CurrentPawn.Box3dcontainer.top4.y), ImVec2(CurrentPawn.Box3dcontainer.top1.x, CurrentPawn.Box3dcontainer.top1.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPBox);


				}

			}

			//Names
			if ((Settings::ESP_Names or Settings::ESP_Distance) or (Settings::ESP_Names and Settings::ESP_Distance)) {
				std::string null = "";
				std::string Distance_String = null + "[" + std::to_string(CurrentPawn.distance) + "]";
				std::string Names_String = CurrentPawn.name_entry.name;
				int Distance_Width = ImGui::CalcTextSize(Distance_String.c_str()).x, Distance_Height = ImGui::CalcTextSize(Distance_String.c_str()).y;
				int Names_Width = ImGui::CalcTextSize(Names_String.c_str()).x, Names_Height = ImGui::CalcTextSize(Names_String.c_str()).y;
				

				if (!Settings::ESP_Names and Settings::ESP_Distance) {
					MSPaintHook->AddText(ImVec2(CurrentPawn.HeadPos_W2S.x - (Distance_Width / 2), CurrentPawn.BottomPos_W2S.y + Distance_Height / 2), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPDistance, Distance_String.c_str());
				}

				if (Settings::ESP_Names and !Settings::ESP_Distance) {
					MSPaintHook->AddText(ImVec2(CurrentPawn.HeadPos_W2S.x - (Names_Width / 2), CurrentPawn.BottomPos_W2S.y + Names_Height / 2), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPNames, Names_String.c_str());
				}

				if (Settings::ESP_Names and Settings::ESP_Distance) {
					MSPaintHook->AddText(ImVec2(CurrentPawn.HeadPos_W2S.x - (Distance_Width / 2), CurrentPawn.BottomPos_W2S.y + Distance_Height / 2), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPDistance, Distance_String.c_str());
					MSPaintHook->AddText(ImVec2(CurrentPawn.HeadPos_W2S.x - (Names_Width / 2), CurrentPawn.BottomPos_W2S.y + Distance_Height + Names_Height / 2), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPNames, Names_String.c_str());
				}

			}		
			



		}

		//Lines
		if (Settings::ESP_Lines) {
			MSPaintHook->AddLine(ImVec2(No_Renderer_Define::Width / 2, No_Renderer_Define::Height), ImVec2(CurrentPawn.PelvisPos_W2S.x, CurrentPawn.PelvisPos_W2S.y), Settings::RainbowMode ? SettingsColor::RainbowColorCool : SettingsColor::ESPLines);
		}



	}
	return true;
}


refdef_t OldRefDef;


bool ActorLoop() {
	while (true) {

		std::vector<PlayerInfos> tmpPlayerList;

		if (FirstTime) {
			std::cout << "A TEST" << No_Utils::GetProcessId("ModernWarfare.exe");
			No_Define::ProcessID = driver::get_process_id("ModernWarfare.exe");
			No_Define::BaseAddress = driver::get_module_base_address("ModernWarfare.exe");
			No_Define::PEB = driver::get_peb();
			std::cout << xorstr("ProcessID: ") << No_Define::ProcessID << "\n";
			std::cout << xorstr("Base Address: ") << No_Define::BaseAddress << "\n";
			std::cout << xorstr("PEB: ") << No_Define::PEB << "\n";

			Addresses::INFO = GetClientInfo();
			Addresses::BASE = GetClientBase(Addresses::INFO);
			Addresses::REFDEF = GetRefDef();
			Addresses::NAMES = GetNameList();

			std::cout << xorstr("[*] Dec Info Ptr: ") << std::hex << Addresses::INFO << "\n";
			std::cout << xorstr("[*] Dec Base Ptr: ") << std::hex << Addresses::BASE << "\n";
			std::cout << xorstr("[*] Dec Refdef Ptr: ") << std::hex << Addresses::REFDEF << "\n";
			std::cout << xorstr("[*] Name List Ptr: ") << std::hex << Addresses::NAMES << "\n";

			std::thread ReadAddressesThread(ReadAddresses);	ReadAddressesThread.detach();

			FirstTime = false;
		}


		
		if (!Addresses::BASE || !Addresses::NAMES) return false;

		Vector3 LocalPlayerPosition = Framework->GetLocalPlayerPosition();
		
		refdef_t RefDef = driver::read<refdef_t>(Addresses::REFDEF);
		if (RefDef == OldRefDef) continue;

		Vector2 Bottom_W2S, Head_W2S, Pelvis_W2S;
		Player* LocalActor = Player::GetLocalActor();
		float closestDistance = FLT_MAX;
		Player* closestActor = NULL;
		for (int i = 0; i < 155; i++) {
			
			Player* CurrentActor = Player::GetCurrentActor(i);

			if (CurrentActor == LocalActor) continue;

			

			if (IsValidPointer(CurrentActor) and !CurrentActor->isDead()) {
				NameEntry Name_Entry = CurrentActor->GetNameEntry();


				if (std::string(Name_Entry.name).length() > 0) {
					Vector3 Bottom_No_W2S = CurrentActor->GetBottomPos();
					Vector3 Head_No_W2S = Bottom_No_W2S + Vector3(0.0, 0.0, 58.0);
					int Distance = LocalPlayerPosition.Distance(Bottom_No_W2S) / 40;


					if (Distance < Settings::ESP_MaxDistance) {

						Head_W2S = Framework->WorldToScreen(Head_No_W2S, LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
						Bottom_W2S = Framework->WorldToScreen(Bottom_No_W2S, LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
						Pelvis_W2S = Vector2(Head_W2S.x, Head_W2S.y + abs(Head_W2S.y - Bottom_W2S.y) / 2);


						Box3DContainer containerbox3d;

						if (Settings::ESP_Box and Settings::ESP_Box_Type == 2) {
							containerbox3d.bottom1 = Framework->WorldToScreen(Vector3(Bottom_No_W2S.x + 30, Bottom_No_W2S.y - 30, Bottom_No_W2S.z), LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
							containerbox3d.bottom2 = Framework->WorldToScreen(Vector3(Bottom_No_W2S.x - 30, Bottom_No_W2S.y - 30, Bottom_No_W2S.z), LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
							containerbox3d.bottom3 = Framework->WorldToScreen(Vector3(Bottom_No_W2S.x - 30, Bottom_No_W2S.y + 30, Bottom_No_W2S.z), LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
							containerbox3d.bottom4 = Framework->WorldToScreen(Vector3(Bottom_No_W2S.x + 30, Bottom_No_W2S.y + 30, Bottom_No_W2S.z), LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);

							containerbox3d.top1 = Framework->WorldToScreen(Vector3(Head_No_W2S.x + 30, Head_No_W2S.y - 30, Head_No_W2S.z), LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
							containerbox3d.top2 = Framework->WorldToScreen(Vector3(Head_No_W2S.x - 30, Head_No_W2S.y - 30, Head_No_W2S.z), LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
							containerbox3d.top3 = Framework->WorldToScreen(Vector3(Head_No_W2S.x - 30, Head_No_W2S.y + 30, Head_No_W2S.z), LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
							containerbox3d.top4 = Framework->WorldToScreen(Vector3(Head_No_W2S.x + 30, Head_No_W2S.y + 30, Head_No_W2S.z), LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
						}

						float PawnHeight = abs(Head_W2S.y - Bottom_W2S.y);

						//////////////////////////////////////////////////// A I M B O T ////////////////////////////////////////////////////

						Vector2 AimHead = Vector2(Head_W2S.x, Head_W2S.y + PawnHeight / 8);

						Vector2 sdist = Vector2(AimHead.x - (No_Renderer_Define::Width / 2), AimHead.y - (No_Renderer_Define::Height / 2));
						auto screendist = sqrtf(sdist.x * sdist.x + sdist.y * sdist.y);

						if (screendist < Settings::FovCircleValue and screendist < closestDistance) {
							closestDistance = screendist;
							closestActor = CurrentActor;
						}

						PlayerInfos plInfos{};
						plInfos.HeadPos_W2S = Head_W2S;
						plInfos.BottomPos_W2S = Bottom_W2S;
						plInfos.PelvisPos_W2S = Pelvis_W2S;
						plInfos.name_entry = Name_Entry;
						plInfos.distance = Distance;
						plInfos.Box3dcontainer = containerbox3d;
						tmpPlayerList.push_back(plInfos);

						


					}
				}
			}
		}
		if (Settings::Aimbot and GetAsyncKeyState(VK_RBUTTON) and closestActor) {
			Vector3 closestBottom_No_W2S = closestActor->GetBottomPos();
			Vector3 closestHead_No_W2S = closestBottom_No_W2S + Vector3(0.0, 0.0, 58.0);
			Vector2 closestBottom_W2S = Framework->WorldToScreen(closestBottom_No_W2S, LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
			Vector2 closestHead_W2S = Framework->WorldToScreen(closestHead_No_W2S, LocalPlayerPosition, RefDef.width, RefDef.height, RefDef.view.tanHalfFov, RefDef.view.axis);
			float closestPawnHeight = abs(closestHead_W2S.y - closestBottom_W2S.y);
			Vector2 closestHead_W2S_Calculated = Vector2(closestHead_W2S.x, closestHead_W2S.y + closestPawnHeight / 8);
			Aimbot_Function(closestHead_W2S_Calculated);
		}
		PlayerList = tmpPlayerList;
		OldRefDef = RefDef;
		Sleep(1);
	}

	return true;
}