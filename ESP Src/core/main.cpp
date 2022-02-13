#include <iostream>
#include "driver/driver.h"
#include "game/offsets.h"
#include "overlay/hijack/hijack.h"
#include "overlay/renderer/renderer.h"
#include <thread>
#include <string>
using namespace std;

#define ERROR(msg) std::cout << "[-] " << msg << std::endl; std::cin.get(); exit(EXIT_FAILURE); 
#define ASSERT(cond, msg) if (!cond) { ERROR(msg) }
bool b1 = true;
void initAdd()
{
	while (true) {
		sdk::client_info = decryption::get_client_info();
		sdk::client_info_base = decryption::get_client_info_base();
		auto ref_def_ptr = decryption::get_ref_def();
		static string BrandColors = "\033[38;5;203m";
		static string LogColors = "\033[38;5;190m";
		system("CLS");

		cout << "" << endl;
		cout << BrandColors << "    _   __   _  __    ______            ______   _____    _   __ " << endl;
		cout << BrandColors << "   / | / /  | |/ /   /_  __/           / ____/  |__  /   / | / / " << endl;
		cout << BrandColors << "  /  |/ /   |   /     / /    ______   / / __     /_ <   /  |/ /  " << endl;
		cout << BrandColors << " / /|  /   /   |     / /    /_____/  / /_/ /   ___/ /  / /|  /  " << endl;
		cout << BrandColors << "/_/ |_/   /_/|_|    /_/             /_____/   /____/  /_/ |_/   " << endl;
		cout << BrandColors << "" << endl;
		cout << "------------------------------------------------------------------" << endl;
		cout << "" << endl;
		cout << BrandColors << "                     SOFTAIM = Smooth 4 & 50 fov" << endl;
		cout << BrandColors << "                     RAGE = Smooth 1 & 32 fov" << endl;
		//std::cout << BrandColors << "[-] log: " << std::endl;
		//std::cout << BrandColors << "	[~] process ID:  " << std::hex << sdk::process_id << std::endl;
		//std::cout << BrandColors << "	[~] base: " << std::hex << sdk::module_base << std::endl;
		//std::cout << BrandColors << "	[~] peb:  " << std::hex << sdk::peb << std::endl;
		//std::cout << BrandColors << "	[~] hwnd: " << std::hex << sdk::hwnd << std::endl;
		//std::cout << BrandColors << "	[~] client_info:      " << std::hex << sdk::client_info << std::endl;
		//std::cout << BrandColors << "	[~] client_info_base: " << std::hex << sdk::client_info_base << std::endl;

		sdk::ref_def = driver::read<sdk::ref_def_t>(ref_def_ptr);
		b1 = true;
		Sleep(7000);
	}
};


int fov = 0; 
int main() {
	static string LogColors = "\033[38;5;190m";
	static string OptionColors = "\033[38;5;14m";

	sdk::process_id = driver::get_process_id("ModernWarfare.exe");
	ASSERT(sdk::process_id, "failed to find Modern Warfare");

	sdk::module_base = driver::get_module_base_address("ModernWarfare.exe");
	ASSERT(sdk::module_base, "failed to module base");

	sdk::peb = driver::get_peb();
	ASSERT(sdk::peb, "failed to find peb");

	sdk::set_game_hwnd();
	ASSERT(sdk::hwnd, "failed to find window handle");

	ASSERT(hijack::init(), "open overlay before launching exe");
	ASSERT(renderer::init(), "failed to initlize renderer");	
	
	std::thread thread_obj(initAdd); int smooth = 1;


	while (!GetAsyncKeyState(VK_DELETE)) 
	{
		if (GetAsyncKeyState(VK_F6)) { fov = 0;  }
		if (GetAsyncKeyState(VK_F6))
			cout << "" << endl;
		if (GetAsyncKeyState(VK_F6))
			cout << "\033[38;5;9m" << " [-] Aimbot Disabled " << endl;

		if (GetAsyncKeyState(VK_F7)) { fov = 50; }
		if (GetAsyncKeyState(VK_F7))
			cout << "" << endl;
		if (GetAsyncKeyState(VK_F7))
			cout << "\033[38;5;34m" << " [+] Aimbot Enabled. fov = 50 " << endl;

		if (GetAsyncKeyState(VK_F10)) {smooth++;
		
		}

		if (smooth >= 10){smooth = 10; }

		if (GetAsyncKeyState(VK_F9)) {
			smooth--;
			
		}
		if (smooth <= 0) { smooth = 0; }




		if (GetAsyncKeyState(VK_F8)) { fov = 32; }
		if (GetAsyncKeyState(VK_F8))
			cout << "" << endl;
		if (GetAsyncKeyState(VK_F8))
			cout << "\033[38;5;34m" << " [+] Aimbot Enabled. fov = 32 " << endl;

		renderer::scene::start();
		sdk::player_t local(sdk::client_info_base + (sdk::local_index() * offsets::player::size));
		auto local_pos = local.get_pos();
		auto local_team = local.team_id();


		const auto bone_base = decryption::decrypt_bone_base(sdk::module_base, sdk::peb);
			
		const auto bone_base_pos = decryption::get_bone_base_pos(sdk::client_info);
		if (b1 == true) 
		{
			b1 = false;
			//std::cout << LogColors << "	[~] bone base: " << std::hex << bone_base << std::endl;
		
			//std::cout << LogColors << "	[~] bone base pos: " << bone_base_pos.x << ", " << bone_base_pos.y << ", " << bone_base_pos.z << std::endl;
			std::cout << "" << endl;
			std::cout << OptionColors << "                            Options: " << endl;
			std::cout << OptionColors << "                     6 = Disable Aimbot" << endl;
			std::cout << OptionColors << "                     f7 = Enable Aimbot, 50 fov" << endl;
			std::cout << OptionColors << "                     f8 = Enable Aimbot, 32 fov" << endl;
			std::cout << OptionColors << "                     smoot = " << smooth << endl;
			std::cout << OptionColors << "                     F9 = -  Smoothing"  << endl;
			std::cout << OptionColors << "                     F10 = + 1 Smoothing" << endl;
			std::cout << OptionColors << " " << endl;
			cout << "------------------------------------------------------------------" << endl;
			cout << LogColors << "                          " << endl;
			cout << LogColors << "                         Version: Pro" << endl;

		}

		vec2_t middle(1920/2-8, 1080/2-14);
		renderer::scene::text(middle, L"+", renderer::colors::red_color, renderer::fonts::watermark_font);

		for (int i = 0; i < 150; i++) 
		{
			sdk::player_t player(sdk::client_info_base + (i * offsets::player::size));
			if (!player.is_valid() || player.dead()) 
			{
				continue;
			}

			if (player.team_id() == local_team) 
			{
				continue;
			}

			vec2_t screen, player_head;
			vec3_t pos = player.get_pos();
			if (sdk::w2s(pos, screen)) 
			{
				auto dist = sdk::units_to_m(local_pos.distance_to(pos));
				wchar_t buf[50];
				swprintf(buf, sizeof(buf), L"%s %.1fm", player.GetNameEntry().name, dist);
				if (dist > 1 && dist < 301)
				{
					if (dist < 51)
					{
						renderer::scene::text(vec2_t(screen.x - 20, screen.y), buf, renderer::colors::red_color, renderer::fonts::tahoma_font);
						renderer::scene::line(950, 1078, screen.x, screen.y + 25, renderer::colors::red_color);
					}

					if (dist > 50 && dist < 100)
					{
						renderer::scene::text(vec2_t(screen.x - 20, screen.y), buf, renderer::colors::red_color, renderer::fonts::tahoma_font);
						renderer::scene::line(950, 1078, screen.x, screen.y + 25, renderer::colors::red_color);
					}

					renderer::scene::text(vec2_t(screen.x - 20, screen.y), buf, renderer::colors::red_color, renderer::fonts::tahoma_font);

					if (screen.x > (middle.x + 150))
						continue;
					if (screen.x < (middle.x - 150))
						continue;
					if (screen.y > (middle.y + 500))
						continue;
					if (screen.y < (middle.y - 500))
						continue;
					renderer::scene::text(vec2_t(screen.x - 20, screen.y), buf, renderer::colors::red_color, renderer::fonts::tahoma_font);
					renderer::scene::line(950, 1080, screen.x, screen.y + 25, renderer::colors::green_color);
					const auto bone_index = decryption::get_bone_index(i, sdk::module_base); // player_index ranges from 0 to 150

					const auto bone_ptr = player.get_bone_ptr(bone_base, bone_index);


					if (!bone_ptr) {
						continue;
					}

					const auto bone_head = decryption::get_bone_position(bone_ptr, bone_base_pos, 7);
					const auto bone_2 = decryption::get_bone_position(bone_ptr, bone_base_pos, 2);

					const auto bone_6 = decryption::get_bone_position(bone_ptr, bone_base_pos, 6);

					const auto bone_6_10 = decryption::get_bone_position(bone_ptr, bone_base_pos, 10);
					const auto bone_10_11 = decryption::get_bone_position(bone_ptr, bone_base_pos, 11); //left hand
					const auto bone_11_12 = decryption::get_bone_position(bone_ptr, bone_base_pos, 12);

					const auto bone_6_14 = decryption::get_bone_position(bone_ptr, bone_base_pos, 14);
					const auto bone_14_15 = decryption::get_bone_position(bone_ptr, bone_base_pos, 15); //right hand
					const auto bone_15_16 = decryption::get_bone_position(bone_ptr, bone_base_pos, 16);

					const auto bone_2_18 = decryption::get_bone_position(bone_ptr, bone_base_pos, 18);
					const auto bone_18_19 = decryption::get_bone_position(bone_ptr, bone_base_pos, 19); //left foot


					const auto bone_2_22 = decryption::get_bone_position(bone_ptr, bone_base_pos, 22);
					const auto bone_22_23 = decryption::get_bone_position(bone_ptr, bone_base_pos, 23); //right foot

					DrawBone(bone_6, bone_head, pos);
					DrawBone(bone_2, bone_6, pos);
					DrawBone(bone_2, bone_2_18, pos);
					DrawBone(bone_2_18, bone_18_19, pos);
					DrawBone(bone_2, bone_2_22, pos);
					DrawBone(bone_2_22, bone_22_23, pos);
					DrawBone(bone_6, bone_6_10, pos);
					DrawBone(bone_6_10, bone_10_11, pos);
					DrawBone(bone_10_11, bone_11_12, pos);
					DrawBone(bone_6, bone_6_14, pos);
					DrawBone(bone_6_14, bone_14_15, pos);
					DrawBone(bone_14_15, bone_15_16, pos);
					vec2_t draw_head;
					if (sdk::w2s(bone_head, draw_head)) {

						if (draw_head.x > (middle.x + fov))
							continue;
						if (draw_head.x < (middle.x - fov))
							continue;
						if (draw_head.y > (middle.y + fov))
							continue;
						if (draw_head.y < (middle.y - fov))
							continue;
						renderer::scene::text(vec2_t(draw_head.x - 2, draw_head.y - 8), L"o", renderer::colors::white_color, renderer::fonts::tahoma_font);
						if (GetAsyncKeyState(VK_RBUTTON) && draw_head.x > 0 && draw_head.y > 0) {
							sdk::mousemove(draw_head.x, draw_head.y - (dist / 50), 1920, 1080, smooth);
						}
					}

				}

			}
		}
		renderer::scene::end();

		sdk::ref_def = driver::read<sdk::ref_def_t>(decryption::get_ref_def());
	}
	renderer::shutdown();
	thread_obj.detach();
	return 0;
}