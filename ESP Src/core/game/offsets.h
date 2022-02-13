#pragma once

/* UPDATED - 2021-08-09 */

namespace offsets
{
	constexpr auto refdef = 0x1EF35220;
	constexpr auto name_array = 0x1EF40FB0;
	constexpr auto name_array_pos = 0x4C70;// also known as array list 
	constexpr auto camera_base = 0x1B8A0910;
	constexpr auto camera_pos = 0x1D8;
	constexpr auto local_index = 0x47F20;
	constexpr auto local_index_pos = 0x1FC;
	constexpr auto recoil = 0x1BE24;
	constexpr auto game_mode = 0x1EAB00F8;
	constexpr auto weapon_definitions = 0xFFFF8009E2254927;
	constexpr auto distribute = 0x2160A2F8;
	constexpr auto visible = 0x666BBE0;
	constexpr auto visible_offset = 0xA83;
	constexpr auto name_size = 0xD0;

	namespace player {
		constexpr auto size = 0x5EB8;
		constexpr auto valid = 0x0FC;
		constexpr auto pos = 0x4B0;
		constexpr auto team = 0x5084;
		constexpr auto stance = 0x5684;
		constexpr auto weapon_index = 0x0;
		constexpr auto dead_1 = 0x54B8;
		constexpr auto dead_2 = 0x498;
	}

	namespace bone {
		constexpr auto base_pos = 0x99E54;// signature not found: 48 05 ? ? ? ? 48 89 44 24 ? 4C 8D 84 24 ? ? ? ?
		constexpr auto index_struct_size = 0x150;
	}

	namespace directx {
		constexpr auto command_queue = 0x19AF8D28;
		constexpr auto swap_chain = 0x19AFE0A0;
	}

}