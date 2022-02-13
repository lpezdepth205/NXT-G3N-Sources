#pragma once
#include <cstdint>
#include <windows.h>
#include "..\utils\vectors.h"

namespace sdk {
	extern HANDLE	 process_id;
	extern uintptr_t module_base;
	extern uintptr_t peb;
	extern HWND      hwnd;

	extern uintptr_t client_info;
	extern uintptr_t client_info_base;

	struct ref_def_view {
		vec2_t tan_half_fov;
		char pad[0xC];
		vec3_t axis[3];
	};

	struct ref_def_t {
		int x;
		int y;
		int width;
		int height;
		ref_def_view view;
	};
	struct NameEntry {
		uint32_t idx;
		char name[0x24];
		uint8_t unk1[0x64];
		uint32_t health;
	};

	extern struct ref_def_t ref_def;
	void mousemove(float tarx, float tary, float X, float Y, int smooth);// absoulte doesnt work at all for warzone
	
	void set_game_hwnd();

	bool in_game();

	int player_count();

	int local_index();

	

	class player_t {
	public:
		player_t(uintptr_t address) {
			this->address = address;
		}

		uintptr_t address{};

		bool is_valid();

		bool dead();

		int team_id();

		vec3_t get_pos();
		uint32_t getIndex();
		NameEntry GetNameEntry();
		uintptr_t get_bone_ptr(uint64_t bone_base, uint64_t bone_index);
	};

	bool w2s(vec3_t world_position, vec2_t& screen_position);

	float units_to_m(float units);
	uint64_t GetNameList();
}
float Distance3D(vec3_t point1, vec3_t point2);
void DrawBone(vec3_t from, vec3_t to, vec3_t m_location);
namespace decryption {
	uintptr_t get_client_info();

	uintptr_t get_client_info_base();

	uintptr_t get_ref_def();

	extern "C" auto decrypt_client_info(uint64_t imageBase, uint64_t peb)->uint64_t;

	extern "C" auto decrypt_client_base(uint64_t clientInfo, uint64_t imageBase, uint64_t peb)->uint64_t;

	extern "C" auto decrypt_bone_base(uint64_t imageBase, uint64_t peb)->uint64_t;

	extern "C" auto get_bone_index(uint32_t index, uint64_t imageBase)->uint64_t;

	vec3_t get_bone_position(const uintptr_t bone_ptr, const vec3_t& base_pos, const int bone);

	vec3_t get_bone_base_pos(const uintptr_t client_info);
	
}
