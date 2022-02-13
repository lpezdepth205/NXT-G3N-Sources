#include "sdk.h"
#include "..\driver\driver.h"
#include "offsets.h"
#include "../overlay/renderer/renderer.h"

namespace sdk {
	HANDLE	  process_id = NULL;
	uintptr_t module_base = NULL;
	uintptr_t peb = NULL;
	HWND      hwnd = NULL;

	uintptr_t client_info = NULL;
	uintptr_t client_info_base = NULL;

	BOOL CALLBACK enum_windows(HWND hwnd, LPARAM param) {
		DWORD process_id;
		GetWindowThreadProcessId(hwnd, &process_id);
		if (process_id == param)
		{
			sdk::hwnd = hwnd;
			return false;
		}
		return true;
	}

    void mousemove(float tarx, float tary, float X, float Y, int smooth)
    {
        float ScreenCenterX = (X / 2);
        float ScreenCenterY = (Y / 2);
        float TargetX = 0;
        float TargetY = 0;

        if (tarx != 0)
        {
            if (tarx > ScreenCenterX)
            {
                TargetX = -(ScreenCenterX - tarx);
                TargetX /= smooth;
                if (TargetX + ScreenCenterX > ScreenCenterX * 2) TargetX = 0;
            }

            if (tarx < ScreenCenterX)
            {
                TargetX = tarx - ScreenCenterX;
                TargetX /= smooth;
                if (TargetX + ScreenCenterX < 0) TargetX = 0;
            }
        }

        if (tary != 0)
        {
            if (tary > ScreenCenterY)
            {
                TargetY = -(ScreenCenterY - tary);
                TargetY /= smooth;
                if (TargetY + ScreenCenterY > ScreenCenterY * 2) TargetY = 0;
            }

            if (tary < ScreenCenterY)
            {
                TargetY = tary - ScreenCenterY;
                TargetY /= smooth;
                if (TargetY + ScreenCenterY < 0) TargetY = 0;
            }
        }
        mouse_event(MOUSEEVENTF_MOVE, static_cast<DWORD>(TargetX), static_cast<DWORD>(TargetY), NULL, NULL);
    }

	void set_game_hwnd() {
		EnumWindows(enum_windows, (LPARAM)sdk::process_id);
	}

	bool in_game() {
		return driver::read<int>(sdk::module_base + offsets::game_mode) > 1;
	}

	int player_count() {
		return driver::read<uintptr_t>(sdk::module_base + offsets::game_mode);
	}

	int local_index() {
		auto local_index = driver::read<uintptr_t>(sdk::client_info + offsets::local_index);
		return driver::read<int>(local_index + 0x1FC);
	}

    uint32_t player_t::getIndex()
    {
        return (address - sdk::module_base) / offsets::player::size;
    }
    NameEntry player_t::GetNameEntry() {
        auto i = getIndex();
        return driver::read<NameEntry>(sdk::GetNameList() + (i * offsets::name_size));
    }
		
	bool player_t::is_valid() {
		return driver::read<bool>(address + offsets::player::valid);
	}

		
	bool player_t::dead() {
		auto dead1 = driver::read<bool>(address + offsets::player::dead_1);
		auto dead2 = driver::read<bool>(address + offsets::player::dead_2);
		return dead1 || dead2;
	}

	int player_t::team_id() {
		return driver::read<int>(address + offsets::player::team);
	}

	vec3_t player_t::get_pos() {
		auto local_pos = driver::read<uintptr_t>(address + offsets::player::pos);
		return driver::read<vec3_t>(local_pos + 0x40);
	}

	uintptr_t player_t::get_bone_ptr(uint64_t bone_base, uint64_t bone_index)
	{
		return driver::read<uintptr_t>(bone_base + (bone_index * offsets::bone::index_struct_size) + 0xC0);//0xC0
	}

	vec3_t get_camera_position() {
		auto camera = driver::read<uintptr_t>(sdk::module_base + offsets::camera_base);
		if (!camera)
			return {};

		return driver::read<vec3_t>(camera + offsets::camera_pos);
	}
    uint64_t GetNameList() {
        auto ptr = driver::read<uint64_t>(sdk::module_base + offsets::name_array);
        return ptr + offsets::name_array_pos;
    }
	bool world_to_screen(vec3_t world_location, vec2_t& out, vec3_t camera_pos, int screen_width, int screen_height, vec2_t fov, vec3_t matricies[3]) {
		auto local = world_location - camera_pos;
		auto trans = vec3_t{
			local.dot(matricies[1]),
			local.dot(matricies[2]),
			local.dot(matricies[0])
		};

		if (trans.z < 0.01f) {
			return false;
		}

		out.x = ((float)screen_width / 2.0) * (1.0 - (trans.x / fov.x / trans.z));
		out.y = ((float)screen_height  / 2.0) * (1.0 - (trans.y / fov.y / trans.z));

		if (out.x < 1 || out.y < 1 || (out.x > sdk::ref_def.width) || (out.y > sdk::ref_def.height)) {
			return false;
		}

		return true;
	}

	bool w2s(vec3_t world_position, vec2_t& screen_position) {
		return world_to_screen(world_position, screen_position, get_camera_position(), ref_def.width, ref_def.height, ref_def.view.tan_half_fov, ref_def.view.axis);
	}

	float units_to_m(float units) {
		return units * 0.0254;
	}

	ref_def_t ref_def;
}

float Distance3D(vec3_t point1, vec3_t point2)
{
    float distance = sqrt((point1.x - point2.x) * (point1.x - point2.x) +
        (point1.y - point2.y) * (point1.y - point2.y) +
        (point1.z - point2.z) * (point1.z - point2.z));
    return distance;
}

void DrawBone(vec3_t from, vec3_t to, vec3_t m_location)
{
    if (Distance3D(m_location, from) > 118)
        return;

    if (Distance3D(m_location, to) > 118)
        return;

    if (Distance3D(from, to) > 39)
        return;

    vec2_t W2S_from;
    if (!sdk::w2s(from, W2S_from))
        return;

    vec2_t W2S_to;
    if (!sdk::w2s(to, W2S_to))
        return;

    renderer::scene::line(W2S_from.x, W2S_from.y, W2S_to.x, W2S_to.y, renderer::colors::red_color);
}


namespace decryption {;
	uintptr_t get_client_info()
    {
		return decrypt_client_info(sdk::module_base, sdk::peb);
	}

	uintptr_t get_client_info_base() {
		return decrypt_client_base(sdk::client_info, sdk::module_base, sdk::peb);
	}

	struct ref_def_key {
		int ref0;
		int ref1;
		int ref2;
	};

	uintptr_t get_ref_def() {
		ref_def_key crypt = driver::read<ref_def_key>(sdk::module_base + offsets::refdef);
		uint64_t baseAddr = sdk::module_base;

		DWORD lower = crypt.ref0 ^ (crypt.ref2 ^ (uint64_t)(baseAddr + offsets::refdef)) * ((crypt.ref2 ^ (uint64_t)(baseAddr + offsets::refdef)) + 2);
		DWORD upper = crypt.ref1 ^ (crypt.ref2 ^ (uint64_t)(baseAddr + offsets::refdef + 0x4)) * ((crypt.ref2 ^ (uint64_t)(baseAddr + offsets::refdef + 0x4)) + 2);

		return (uint64_t)upper << 32 | lower; 
	}

    vec3_t get_bone_position(const uintptr_t bone_ptr, const vec3_t& base_pos, const int bone)
	{
		vec3_t pos = driver::read<vec3_t>(bone_ptr + ((uint64_t)bone * 0x20) + 0x10);
        pos.x += base_pos.x;
        pos.y += base_pos.y;
        pos.z += base_pos.z;
		return pos;
	}

	vec3_t get_bone_base_pos(const uintptr_t client_info)
	{
		return driver::read<vec3_t>(client_info + offsets::bone::base_pos);
	}
    extern "C" auto decrypt_client_info(uint64_t imageBase, uint64_t peb) -> uint64_t
    {
        uint64_t rax = imageBase, rbx = imageBase, rcx = imageBase, rdx = imageBase, rdi = imageBase, rsi = imageBase, r8 = imageBase, r9 = imageBase, r10 = imageBase, r11 = imageBase, r12 = imageBase, r13 = imageBase, r14 = imageBase, r15 = imageBase;
        rbx = driver::read<uintptr_t>(imageBase + 0x1EF32838);
        if (!rbx)
            return rbx;
        rdx = peb;              //mov rdx, gs:[rax]
        r9 = imageBase + 0xEF81;           //lea r9, [0xFFFFFFFFFD94EE8D]
        rax = rbx;              //mov rax, rbx
        rax >>= 0x15;           //shr rax, 0x15
        rbx ^= rax;             //xor rbx, rax
        rcx = rbx;              //mov rcx, rbx
        r8 = 0;                 //and r8, 0xFFFFFFFFC0000000
        rcx >>= 0x2A;           //shr rcx, 0x2A
        rcx ^= rbx;             //xor rcx, rbx
        r8 = _rotl64(r8, 0x10);                 //rol r8, 0x10
        r8 ^= driver::read<uintptr_t>(imageBase + 0x76730C2);              //xor r8, [0x0000000004FB2F9E]
        rax = 0x3C38AA1670A95F19;               //mov rax, 0x3C38AA1670A95F19
        rbx = rdx;              //mov rbx, rdx
        rbx = ~rbx;             //not rbx
        rbx *= r9;              //imul rbx, r9
        r8 = _byteswap_uint64(r8);              //bswap r8
        rbx += rcx;             //add rbx, rcx
        rbx -= rdx;             //sub rbx, rdx
        rbx *= rax;             //imul rbx, rax
        rax = 0x4AA02D69120472A5;               //mov rax, 0x4AA02D69120472A5
        rbx -= rax;             //sub rbx, rax
        rbx *= driver::read<uintptr_t>(r8 + 0x11);              //imul rbx, [r8+0x11]
        return rbx;
    }
}

extern "C" auto decrypt_client_base(uint64_t clientInfo, uint64_t imageBase, uint64_t peb) -> uint64_t
{

    uint64_t rax = imageBase, rbx = imageBase, rcx = imageBase, rdx = imageBase, rdi = imageBase, rsi = imageBase, r8 = imageBase, r9 = imageBase, r10 = imageBase, r11 = imageBase, r12 = imageBase, r13 = imageBase, r14 = imageBase, r15 = imageBase;
    rax = driver::read < uintptr_t>(clientInfo + 0xa2be8);
    if (!rax)
        return rax;

    rbx = peb;              //mov rbx, gs:[rcx]
    rcx = rbx;              //mov rcx, rbx
    rcx = _rotl64(rcx, 0x23);               //rol rcx, 0x23
    rcx &= 0xF;
    //Globals::clientSwitch = rcx;
    switch (rcx) {
    case 0:
    {
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93FE35]
        r10 = driver::read < uintptr_t>(imageBase + 0x7673102);              //mov r10, [0x0000000004FB2EB8]
        rcx = 0x22144FF131B94E4E;               //mov rcx, 0x22144FF131B94E4E
        rdx = rdi;              //mov rdx, rdi
        rax += rcx;             //add rax, rcx
        rdx -= rbx;             //sub rdx, rbx
        rax += rdx;             //add rax, rdx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x20;           //shr rcx, 0x20
        rax ^= rcx;             //xor rax, rcx
        rax += rdi;             //add rax, rdi
        rcx = 0x2C3046BF022A7DFB;               //mov rcx, 0x2C3046BF022A7DFB
        rax *= rcx;             //imul rax, rcx
        rcx = imageBase + 0x63FA;          //lea rcx, [0xFFFFFFFFFD945FE6]
        rax += rbx;             //add rax, rbx
        rax += rcx;             //add rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rcx = driver::read < uintptr_t>(rcx + 0xb);               //mov rcx, [rcx+0x0B]
        uintptr_t RSP_0x68;
        RSP_0x68 = 0x6C61A041EBA25EFF;          //mov rcx, 0x6C61A041EBA25EFF : RSP+0x68
        rcx *= RSP_0x68;                //imul rcx, [rsp+0x68]
        rax *= rcx;             //imul rax, rcx
        return rax;
    }
    case 1:
    {
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93FA48]
        r15 = imageBase + 0x3BD20F42;              //lea r15, [0x0000000039660972]
        r10 = driver::read < uintptr_t>(imageBase + 0x7673102);              //mov r10, [0x0000000004FB2ADD]
        rdx = rbx;              //mov rdx, rbx
        rdx = ~rdx;             //not rdx
        rcx = imageBase + 0x4BEC;          //lea rcx, [0xFFFFFFFFFD9441FF]
        rcx = ~rcx;             //not rcx
        rdx += rcx;             //add rdx, rcx
        rax ^= rdx;             //xor rax, rdx
        rax -= rbx;             //sub rax, rbx
        rax -= rdi;             //sub rax, rdi
        rcx = 0xC15A2187DF1F3D53;               //mov rcx, 0xC15A2187DF1F3D53
        rax *= rcx;             //imul rax, rcx
        rcx = 0x374224EA456C6C64;               //mov rcx, 0x374224EA456C6C64
        rax -= rcx;             //sub rax, rcx
        rdx = rbx;              //mov rdx, rbx
        rdx = ~rdx;             //not rdx
        rcx = r15;              //mov rcx, r15
        rcx = ~rcx;             //not rcx
        rdx += rcx;             //add rdx, rcx
        rax ^= rdx;             //xor rax, rdx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0xD;            //shr rcx, 0x0D
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x1A;           //shr rcx, 0x1A
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x34;           //shr rcx, 0x34
        rax ^= rcx;             //xor rax, rcx
        rcx = 0x591E4B1CBA3ED913;               //mov rcx, 0x591E4B1CBA3ED913
        rax += rcx;             //add rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= *(uintptr_t*)(rcx + 0xb);              //imul rax, [rcx+0x0B]
        return rax;
    }
    case 2:
    {
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93F4EC]
        r11 = imageBase + 0x997E;          //lea r11, [0xFFFFFFFFFD948E4D]
        r10 = driver::read < uintptr_t>(imageBase + 0x7673102);              //mov r10, [0x0000000004FB2597]
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x24;           //shr rcx, 0x24
        rcx ^= rax;             //xor rcx, rax
        rax = rbx + 0xffffffffffffeea4;                 //lea rax, [rbx-0x115C]
        rcx -= rdi;             //sub rcx, rdi
        rax += rcx;             //add rax, rcx
        rcx = r11;              //mov rcx, r11
        rcx = ~rcx;             //not rcx
        rcx += rbx;             //add rcx, rbx
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x22;           //shr rcx, 0x22
        rax ^= rcx;             //xor rax, rcx
        rcx = 0x767DA889418D484C;               //mov rcx, 0x767DA889418D484C
        rax -= rcx;             //sub rax, rcx
        rcx = 0x3EC545B06BF37B91;               //mov rcx, 0x3EC545B06BF37B91
        rax += rcx;             //add rax, rcx
        rcx = 0xC33188630317B0EB;               //mov rcx, 0xC33188630317B0EB
        rax *= rcx;             //imul rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        return rax;
    }
    case 3:
    {
        r9 = driver::read < uintptr_t>(imageBase + 0x7673102);               //mov r9, [0x0000000004FB21B6]
        rcx = 0x662E26DA682B7287;               //mov rcx, 0x662E26DA682B7287
        rax *= rcx;             //imul rax, rcx
        rcx = 0x35C03CD64CD3A2D9;               //mov rcx, 0x35C03CD64CD3A2D9
        rax -= rcx;             //sub rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r9;              //xor rcx, r9
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x20;           //shr rcx, 0x20
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x5;            //shr rcx, 0x05
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0xA;            //shr rcx, 0x0A
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x14;           //shr rcx, 0x14
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x28;           //shr rcx, 0x28
        rax ^= rcx;             //xor rax, rcx
        rcx = 0x5B377D8D4260357;                //mov rcx, 0x5B377D8D4260357
        rax -= rcx;             //sub rax, rcx
        return rax;
    }
    case 4:
    {
        r10 = driver::read < uintptr_t>(imageBase + 0x7673102);              //mov r10, [0x0000000004FB1D58]
        r15 = imageBase + 0x1C57;          //lea r15, [0xFFFFFFFFFD94089A]
        rdx = imageBase + 0x888F;          //lea rdx, [0xFFFFFFFFFD94745B]
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = r15;              //mov rcx, r15
        rcx = ~rcx;             //not rcx
        rcx += rbx;             //add rcx, rbx
        rax ^= rcx;             //xor rax, rcx
        rcx = rbx + 0x1;                //lea rcx, [rbx+0x01]
        rcx *= rdx;             //imul rcx, rdx
        rax += rcx;             //add rax, rcx
        rcx = 0x326349AC17022BCC;               //mov rcx, 0x326349AC17022BCC
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x6;            //shr rcx, 0x06
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0xC;            //shr rcx, 0x0C
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x18;           //shr rcx, 0x18
        rax ^= rcx;             //xor rax, rcx
        rdx = rax;              //mov rdx, rax
        rdx >>= 0x30;           //shr rdx, 0x30
        rdx ^= rax;             //xor rdx, rax
        rax = imageBase + 0x44D2A759;              //lea rax, [0x0000000042668EE1]
        rax ^= rbx;             //xor rax, rbx
        rax += rdx;             //add rax, rdx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x7;            //shr rcx, 0x07
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0xE;            //shr rcx, 0x0E
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x1C;           //shr rcx, 0x1C
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x38;           //shr rcx, 0x38
        rax ^= rcx;             //xor rax, rcx
        rcx = 0x215089DBA21CF1F1;               //mov rcx, 0x215089DBA21CF1F1
        rax *= rcx;             //imul rax, rcx
        return rax;
    }
    case 5:
    {
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93E60E]
        r9 = driver::read < uintptr_t>(imageBase + 0x7673102);               //mov r9, [0x0000000004FB166F]
        rax += rdi;             //add rax, rdi
        uintptr_t RBP_0xFFFFFFFFFFFFFF98;
        RBP_0xFFFFFFFFFFFFFF98 = 0x2498E4BDFDB1E6D4;            //mov rcx, 0x2498E4BDFDB1E6D4 : RBP+0xFFFFFFFFFFFFFF98
        rax ^= RBP_0xFFFFFFFFFFFFFF98;          //xor rax, [rbp-0x68]
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r9;              //xor rcx, r9
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rax ^= rdi;             //xor rax, rdi
        rax += rdi;             //add rax, rdi
        rcx = 0x1E39C7FFB2BA1F67;               //mov rcx, 0x1E39C7FFB2BA1F67
        rax += rcx;             //add rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x15;           //shr rcx, 0x15
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x2A;           //shr rcx, 0x2A
        rax ^= rcx;             //xor rax, rcx
        rcx = 0xF9F74ADF71169A59;               //mov rcx, 0xF9F74ADF71169A59
        rax *= rcx;             //imul rax, rcx
        return rax;
    }
    case 6:
    {
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93E14C]
        r9 = driver::read < uintptr_t>(imageBase + 0x7673102);               //mov r9, [0x0000000004FB11D7]
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r9;              //xor rcx, r9
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x12;           //shr rcx, 0x12
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x24;           //shr rcx, 0x24
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x6;            //shr rcx, 0x06
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0xC;            //shr rcx, 0x0C
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x18;           //shr rcx, 0x18
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x30;           //shr rcx, 0x30
        rax ^= rcx;             //xor rax, rcx
        rcx = 0xFFFFFFFF8B1CFF7D;               //mov rcx, 0xFFFFFFFF8B1CFF7D
        rcx -= rbx;             //sub rcx, rbx
        rcx -= rdi;             //sub rcx, rdi
        rax += rcx;             //add rax, rcx
        rcx = 0x3EF206B933EFC92F;               //mov rcx, 0x3EF206B933EFC92F
        rax *= rcx;             //imul rax, rcx
        rcx = 0x9000DC451EDA65C6;               //mov rcx, 0x9000DC451EDA65C6
        rax ^= rcx;             //xor rax, rcx
        rcx = 0x67A8244587705A95;               //mov rcx, 0x67A8244587705A95
        rax += rcx;             //add rax, rcx
        rax -= rbx;             //sub rax, rbx
        return rax;
    }
    case 7:
    {
        r10 = driver::read < uintptr_t>(imageBase + 0x7673102);              //mov r10, [0x0000000004FB0C7A]
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93DB71]
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x1B;           //shr rcx, 0x1B
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x36;           //shr rcx, 0x36
        rax ^= rcx;             //xor rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = 0x4C110591691C132B;               //mov rcx, 0x4C110591691C132B
        rax *= rcx;             //imul rax, rcx
        rax ^= rdi;             //xor rax, rdi
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x25;           //shr rcx, 0x25
        rax ^= rcx;             //xor rax, rcx
        rcx = 0x2DE21BDCC012F365;               //mov rcx, 0x2DE21BDCC012F365
        rax ^= rcx;             //xor rax, rcx
        rax ^= rdi;             //xor rax, rdi
        rcx = 0x31E6FDBD5F7C798;                //mov rcx, 0x31E6FDBD5F7C798
        rax += rcx;             //add rax, rcx
        return rax;
    }
    case 8:
    {
        r9 = driver::read < uintptr_t>(imageBase + 0x7673102);               //mov r9, [0x0000000004FB0846]
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93D73D]
        r15 = imageBase + 0x1CE2D36A;              //lea r15, [0x000000001A76AA8B]
        rax -= rdi;             //sub rax, rdi
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r9;              //xor rcx, r9
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= *(uintptr_t*)(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = 0x3B1BD37E00567223;               //mov rcx, 0x3B1BD37E00567223
        rax *= rcx;             //imul rax, rcx
        rcx = 0xD024CEF263824855;               //mov rcx, 0xD024CEF263824855
        rax ^= rcx;             //xor rax, rcx
        uintptr_t RBP_0xFFFFFFFFFFFFFF88;
        RBP_0xFFFFFFFFFFFFFF88 = 0x3768F141513759F5;            //mov rcx, 0x3768F141513759F5 : RBP+0xFFFFFFFFFFFFFF88
        rax *= RBP_0xFFFFFFFFFFFFFF88;          //imul rax, [rbp-0x78]
        rcx = rbx;              //mov rcx, rbx
        rcx *= r15;             //imul rcx, r15
        rax -= rcx;             //sub rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x1A;           //shr rcx, 0x1A
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x34;           //shr rcx, 0x34
        rax ^= rcx;             //xor rax, rcx
        rax -= rbx;             //sub rax, rbx
        return rax;
    }
    case 9:
    {
        r10 = driver::read < uintptr_t>(imageBase + 0x7673102);              //mov r10, [0x0000000004FB040F]
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93D306]
        r15 = imageBase + 0x803D;          //lea r15, [0xFFFFFFFFFD94532C]
        rdx = imageBase + 0x479C890A;              //lea rdx, [0x0000000045305BBB]
        rcx = 0x3D5CC1D388504547;               //mov rcx, 0x3D5CC1D388504547
        rax *= rcx;             //imul rax, rcx
        rcx = rbx;              //mov rcx, rbx
        rcx = ~rcx;             //not rcx
        rcx ^= rax;             //xor rcx, rax
        rax = 0x9FDF0511C03F4F4D;               //mov rax, 0x9FDF0511C03F4F4D
        rcx ^= rdx;             //xor rcx, rdx
        rax += rcx;             //add rax, rcx
        rax += rdi;             //add rax, rdi
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x16;           //shr rcx, 0x16
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x2C;           //shr rcx, 0x2C
        rax ^= rcx;             //xor rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = rbx;              //mov rcx, rbx
        rcx ^= r15;             //xor rcx, r15
        rax += rcx;             //add rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x27;           //shr rcx, 0x27
        rax ^= rcx;             //xor rax, rcx
        return rax;
    }
    case 10:
    {
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93CEA2]
        r15 = imageBase + 0x69BCBE92;              //lea r15, [0x0000000067508D1D]
        r9 = driver::read < uintptr_t>(imageBase + 0x7673102);               //mov r9, [0x0000000004FAFF0B]
        rcx = 0x3C4311C13C35D87;                //mov rcx, 0x3C4311C13C35D87
        rax *= rcx;             //imul rax, rcx
        rcx = imageBase + 0xED46;          //lea rcx, [0xFFFFFFFFFD94B98D]
        rcx = ~rcx;             //not rcx
        rcx -= rbx;             //sub rcx, rbx
        rax += rcx;             //add rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x1E;           //shr rcx, 0x1E
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x3C;           //shr rcx, 0x3C
        rax ^= rcx;             //xor rax, rcx
        rax ^= rdi;             //xor rax, rdi
        rcx = r15;              //mov rcx, r15
        rcx = ~rcx;             //not rcx
        rcx *= rbx;             //imul rcx, rbx
        rax += rcx;             //add rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r9;              //xor rcx, r9
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = 0xCC2F3FD698943D61;               //mov rcx, 0xCC2F3FD698943D61
        rax ^= rcx;             //xor rax, rcx
        rcx = rdi + 0x7180;             //lea rcx, [rdi+0x7180]
        rcx += rbx;             //add rcx, rbx
        rax += rcx;             //add rax, rcx
        return rax;
    }
    case 11:
    {
        r9 = driver::read < uintptr_t>(imageBase + 0x7673102);               //mov r9, [0x0000000004FAF9D6]
        rdi = imageBase + 0x9122;          //lea rdi, [0xFFFFFFFFFD9459E3]
        rax += rbx;             //add rax, rbx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x16;           //shr rcx, 0x16
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x2C;           //shr rcx, 0x2C
        rax ^= rcx;             //xor rax, rcx
        rcx = 0x291F7674AA1EA25F;               //mov rcx, 0x291F7674AA1EA25F
        rax -= rcx;             //sub rax, rcx
        rcx = 0x6E959F448160D51F;               //mov rcx, 0x6E959F448160D51F
        rax -= rcx;             //sub rax, rcx
        rcx = 0x8038051CB83D2815;               //mov rcx, 0x8038051CB83D2815
        rax *= rcx;             //imul rax, rcx
        rcx = rbx;              //mov rcx, rbx
        rcx ^= rdi;             //xor rcx, rdi
        rax -= rcx;             //sub rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r9;              //xor rcx, r9
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rax += rbx;             //add rax, rbx
        return rax;
    }
    case 12:
    {
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93C444]
        r9 = driver::read < uintptr_t>(imageBase + 0x7673102);               //mov r9, [0x0000000004FAF4D1]
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x1B;           //shr rcx, 0x1B
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x36;           //shr rcx, 0x36
        rax ^= rcx;             //xor rax, rcx
        rax += rdi;             //add rax, rdi
        rcx = imageBase + 0x5273;          //lea rcx, [0xFFFFFFFFFD9413F3]
        rcx = ~rcx;             //not rcx
        rcx *= rbx;             //imul rcx, rbx
        rax += rcx;             //add rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x22;           //shr rcx, 0x22
        rax ^= rcx;             //xor rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r9;              //xor rcx, r9
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = 0x1265DD2A6B0AF14C;               //mov rcx, 0x1265DD2A6B0AF14C
        rax += rcx;             //add rax, rcx
        rcx = 0xDC8992470E5E2D91;               //mov rcx, 0xDC8992470E5E2D91
        rax *= rcx;             //imul rax, rcx
        rcx = 0x8B9C2B23E4056B7;                //mov rcx, 0x8B9C2B23E4056B7
        rax ^= rcx;             //xor rax, rcx
        return rax;
    }
    case 13:
    {
        r10 = driver::read < uintptr_t>(imageBase + 0x7673102);              //mov r10, [0x0000000004FAF055]
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93BF4C]
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= *(uintptr_t*)(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rax -= rdi;             //sub rax, rdi
        rax += 0xFFFFFFFFFFFF447F;              //add rax, 0xFFFFFFFFFFFF447F
        rax += rbx;             //add rax, rbx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x18;           //shr rcx, 0x18
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x30;           //shr rcx, 0x30
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0xA;            //shr rcx, 0x0A
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x14;           //shr rcx, 0x14
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x28;           //shr rcx, 0x28
        rax ^= rcx;             //xor rax, rcx
        rcx = 0xA62C40516C6F6413;               //mov rcx, 0xA62C40516C6F6413
        rax *= rcx;             //imul rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0xD;            //shr rcx, 0x0D
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x1A;           //shr rcx, 0x1A
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x34;           //shr rcx, 0x34
        rax ^= rcx;             //xor rax, rcx
        rcx = 0xE943D76167032BF7;               //mov rcx, 0xE943D76167032BF7
        rax ^= rcx;             //xor rax, rcx
        rcx = rdi + 0x1b17bd0e;                 //lea rcx, [rdi+0x1B17BD0E]
        rcx += rbx;             //add rcx, rbx
        rax ^= rcx;             //xor rax, rcx
        return rax;
    }
    case 14:
    {
        r11 = driver::read < uintptr_t>(imageBase + 0x7673102);              //mov r11, [0x0000000004FAEAD7]
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93B9CE]
        rdx = imageBase + 0x7F924D9B;              //lea rdx, [0x000000007D2606F8]
        r8 = rbx;               //mov r8, rbx
        r8 *= rdx;              //imul r8, rdx
        rdx = 0xB467571A0811023A;               //mov rdx, 0xB467571A0811023A
        rdx += rbx;             //add rdx, rbx
        rdx += rax;             //add rdx, rax
        rax = r8;               //mov rax, r8
        rax ^= rdx;             //xor rax, rdx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r11;             //xor rcx, r11
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rcx = driver::read < uintptr_t>(rcx + 0xb);               //mov rcx, [rcx+0x0B]
        uintptr_t RSP_0x48;
        RSP_0x48 = 0xA7238C57EC0AD99;           //mov rcx, 0xA7238C57EC0AD99 : RSP+0x48
        rcx *= RSP_0x48;                //imul rcx, [rsp+0x48]
        rax *= rcx;             //imul rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x16;           //shr rcx, 0x16
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x2C;           //shr rcx, 0x2C
        rax ^= rcx;             //xor rax, rcx
        rcx = rbx;              //mov rcx, rbx
        rcx -= rdi;             //sub rcx, rdi
        rcx += 0xFFFFFFFFFFFF4075;              //add rcx, 0xFFFFFFFFFFFF4075
        rax += rcx;             //add rax, rcx
        rcx = imageBase + 0x70731B1B;              //lea rcx, [0x000000006E06D2BD]
        rcx = ~rcx;             //not rcx
        rcx *= rbx;             //imul rcx, rbx
        rax ^= rcx;             //xor rax, rcx
        return rax;
    }
    case 15:
    {
        rdi = imageBase;           //lea rdi, [0xFFFFFFFFFD93B582]
        r10 = imageBase + 0x34E2;          //lea r10, [0xFFFFFFFFFD93EA4C]
        r14 = 0x773B51CDE563DAC5;               //mov r14, 0x773B51CDE563DAC5
        r9 = driver::read < uintptr_t>(imageBase + 0x7673102);               //mov r9, [0x0000000004FAE614]
        rcx = 0xA012F47873537170;               //mov rcx, 0xA012F47873537170
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x6;            //shr rcx, 0x06
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0xC;            //shr rcx, 0x0C
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x18;           //shr rcx, 0x18
        rax ^= rcx;             //xor rax, rcx
        rcx = rax;              //mov rcx, rax
        rcx >>= 0x30;           //shr rcx, 0x30
        rax ^= rcx;             //xor rax, rcx
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r9;              //xor rcx, r9
        rcx = _byteswap_uint64(rcx);            //bswap rcx
        rax *= driver::read < uintptr_t>(rcx + 0xb);              //imul rax, [rcx+0x0B]
        rcx = rbx;              //mov rcx, rbx
        rcx *= r10;             //imul rcx, r10
        rax ^= rcx;             //xor rax, rcx
        rax ^= rdi;             //xor rax, rdi
        rax += rdi;             //add rax, rdi
        rcx = 0x9A479D9F212CEB38;               //mov rcx, 0x9A479D9F212CEB38
        rax ^= rcx;             //xor rax, rcx
        rax *= r14;             //imul rax, r14
        return rax;
    }
    }
}

extern "C" auto decrypt_bone_base(uint64_t imageBase, uint64_t peb) -> uint64_t
{
    uint64_t rax = imageBase, rbx = imageBase, rcx = imageBase, rdx = imageBase, rdi = imageBase, rsi = imageBase, r8 = imageBase, r9 = imageBase, r10 = imageBase, r11 = imageBase, r12 = imageBase, r13 = imageBase, r14 = imageBase, r15 = imageBase;
    rdx = driver::read<uintptr_t>(imageBase + 0x1C0C1B48);
    if (!rdx)
        return rdx;
    rbx = peb;              //mov rbx, gs:[rax]
    rax = rbx;              //mov rax, rbx
    rax >>= 0x10;           //shr rax, 0x10
    rax &= 0xF;
   // Globals::clientSwitch = rax;
    switch (rax) {
    case 0:
    {
        r15 = imageBase + 0x950E;          //lea r15, [0xFFFFFFFFFD5B3A7C]
        r14 = imageBase + 0x33FF3090;              //lea r14, [0x000000003159D5F2]
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1D6EB]
        rdx ^= rbx;             //xor rdx, rbx
        rax = rbx;              //mov rax, rbx
        rax = ~rax;             //not rax
        rax ^= r14;             //xor rax, r14
        rdx += rax;             //add rdx, rax
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rcx = rbx;              //mov rcx, rbx
        rax = rdx;              //mov rax, rdx
        rcx *= r15;             //imul rcx, r15
        rdx = 0xBCAADAD1758A36A5;               //mov rdx, 0xBCAADAD1758A36A5
        rdx *= rax;             //imul rdx, rax
        rdx += rcx;             //add rdx, rcx
        rax = 0xEA964C4856C8F982;               //mov rax, 0xEA964C4856C8F982
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x1A;           //shr rax, 0x1A
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x34;           //shr rax, 0x34
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x9;            //shr rax, 0x09
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x12;           //shr rax, 0x12
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x24;           //shr rax, 0x24
        rdx ^= rax;             //xor rdx, rax
        return rdx;
    }
    case 1:
    {
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1D1D1]
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A9FD5]
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rax = 0x4A53CB2870B70743;               //mov rax, 0x4A53CB2870B70743
        rcx = rbx;              //mov rcx, rbx
        rdx ^= rax;             //xor rdx, rax
        rcx = ~rcx;             //not rcx
        rax = rdx;              //mov rax, rdx
        rax >>= 0x18;           //shr rax, 0x18
        rdx ^= rax;             //xor rdx, rax
        rax = imageBase + 0x404C;          //lea rax, [0xFFFFFFFFFD5ADF5A]
        rcx += rax;             //add rcx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x30;           //shr rax, 0x30
        rcx ^= rax;             //xor rcx, rax
        rax = 0xA1BEB6CD6E9A08AA;               //mov rax, 0xA1BEB6CD6E9A08AA
        rdx ^= rcx;             //xor rdx, rcx
        rdx ^= rax;             //xor rdx, rax
        rax = 0x9467CF87DDBCE779;               //mov rax, 0x9467CF87DDBCE779
        rdx *= rax;             //imul rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x8;            //shr rax, 0x08
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x10;           //shr rax, 0x10
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x20;           //shr rax, 0x20
        rdx ^= rax;             //xor rdx, rax
        rdx ^= r11;             //xor rdx, r11
        return rdx;
    }
    case 2:
    {
        //failed to translate: pop rdx
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1CCF9]
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A9AFD]
        rax = rdx;              //mov rax, rdx
        rax >>= 0x18;           //shr rax, 0x18
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x30;           //shr rax, 0x30
        rdx ^= rax;             //xor rdx, rax
        rax = 0xF7BAB43E998D535B;               //mov rax, 0xF7BAB43E998D535B
        rdx *= rax;             //imul rdx, rax
        rax = 0xD9174E9660FDF508;               //mov rax, 0xD9174E9660FDF508
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x23;           //shr rax, 0x23
        rdx ^= rax;             //xor rdx, rax
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rdx ^= r11;             //xor rdx, r11
        rax = 0xF9A6F8222572B737;               //mov rax, 0xF9A6F8222572B737
        rdx ^= rax;             //xor rdx, rax
        rdx -= rbx;             //sub rdx, rbx
        return rdx;
    }
    case 3:
    {
        //failed to translate: pop rdx
        r14 = imageBase + 0x32B5D5C2;              //lea r14, [0x0000000030106BC3]
        rcx = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov rcx, [0x0000000004C1C791]
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= rcx;             //xor rax, rcx
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rax = rdx;              //mov rax, rdx
        rax >>= 0xE;            //shr rax, 0x0E
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x1C;           //shr rax, 0x1C
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x38;           //shr rax, 0x38
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x2;            //shr rax, 0x02
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x4;            //shr rax, 0x04
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x8;            //shr rax, 0x08
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x10;           //shr rax, 0x10
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x20;           //shr rax, 0x20
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x14;           //shr rax, 0x14
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x28;           //shr rax, 0x28
        rdx ^= rax;             //xor rdx, rax
        rax = 0x78463E5EFEED0865;               //mov rax, 0x78463E5EFEED0865
        rdx *= rax;             //imul rdx, rax
        rax = r14;              //mov rax, r14
        rax = ~rax;             //not rax
        rax ^= rbx;             //xor rax, rbx
        rdx += rax;             //add rdx, rax
        rax = 0x5914BDEA5BC9DBD4;               //mov rax, 0x5914BDEA5BC9DBD4
        rdx ^= rax;             //xor rdx, rax
        rax = 0xA58D11B55CE745D9;               //mov rax, 0xA58D11B55CE745D9
        rdx *= rax;             //imul rdx, rax
        return rdx;
    }
    case 4:
    {
        //failed to translate: pop rdx
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A9058]
        r15 = imageBase + 0xF1A9;          //lea r15, [0xFFFFFFFFFD5B81F5]
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1C1DB]
        rdx -= rbx;             //sub rdx, rbx
        rax = 0x6F909EA95A502C43;               //mov rax, 0x6F909EA95A502C43
        rdx *= rax;             //imul rdx, rax
        rax = 0x15B3345685AA8A13;               //mov rax, 0x15B3345685AA8A13
        rdx -= rax;             //sub rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x27;           //shr rax, 0x27
        rdx ^= rax;             //xor rdx, rax
        rax = rbx;              //mov rax, rbx
        rax = ~rax;             //not rax
        uintptr_t RSP_0x58;
        RSP_0x58 = imageBase + 0x26DF;             //lea rax, [0xFFFFFFFFFD5AB715] : RSP+0x58
        rax += RSP_0x58;                //add rax, [rsp+0x58]
        rdx ^= rax;             //xor rdx, rax
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rax = rbx;              //mov rax, rbx
        rax *= r15;             //imul rax, r15
        rdx -= rax;             //sub rdx, rax
        rdx ^= r11;             //xor rdx, r11
        return rdx;
    }
    case 5:
    {
        //failed to translate: pop rbx
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1BD86]
        r14 = imageBase + 0x6EE575D2;              //lea r14, [0x000000006C40015C]
        rax = 0xB5B4DDAD6DEEE7F7;               //mov rax, 0xB5B4DDAD6DEEE7F7
        rdx *= rax;             //imul rdx, rax
        rax = imageBase + 0x2CF8E9A0;              //lea rax, [0x000000002A537459]
        rax = ~rax;             //not rax
        rax -= rbx;             //sub rax, rbx
        rdx += rax;             //add rdx, rax
        rax = 0xA493494CF69B66E7;               //mov rax, 0xA493494CF69B66E7
        rdx *= rax;             //imul rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x11;           //shr rax, 0x11
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x22;           //shr rax, 0x22
        rdx ^= rax;             //xor rdx, rax
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rcx = ~rcx;             //not rcx
        rdx *= driver::read<uintptr_t>(rcx + 0x15);             //imul rdx, [rcx+0x15]
        rax = rdx;              //mov rax, rdx
        rax >>= 0x1F;           //shr rax, 0x1F
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x3E;           //shr rax, 0x3E
        rax ^= rdx;             //xor rax, rdx
        rdx = 0xEC108096CC6D6A95;               //mov rdx, 0xEC108096CC6D6A95
        rdx ^= rax;             //xor rdx, rax
        rdx += rbx;             //add rdx, rbx
        rdx += r14;             //add rdx, r14
        return rdx;
    }
    case 6:
    {
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A86BC]
        r9 = driver::read<uintptr_t>(imageBase + 0x76731E9);               //mov r9, [0x0000000004C1B85C]
        rdx -= r11;             //sub rdx, r11
        rax = rdx;              //mov rax, rdx
        rax >>= 0xF;            //shr rax, 0x0F
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x1E;           //shr rax, 0x1E
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x3C;           //shr rax, 0x3C
        rdx ^= rax;             //xor rdx, rax
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r9;              //xor rax, r9
        rax = ~rax;             //not rax
        rax = driver::read<uintptr_t>(rax + 0x15);              //mov rax, [rax+0x15]
        uintptr_t RSP_0x48;
        RSP_0x48 = 0xC71B2089CE252FD1;          //mov rax, 0xC71B2089CE252FD1 : RSP+0x48
        rax *= RSP_0x48;                //imul rax, [rsp+0x48]
        rdx *= rax;             //imul rdx, rax
        rax = 0x5FDE9735EED36767;               //mov rax, 0x5FDE9735EED36767
        rdx += rax;             //add rdx, rax
        rax = 0x3EC11F231D352630;               //mov rax, 0x3EC11F231D352630
        rdx ^= rax;             //xor rdx, rax
        rdx -= rbx;             //sub rdx, rbx
        rdx ^= r11;             //xor rdx, r11
        return rdx;
    }
    case 7:
    {
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1B443]
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A8247]
        rdx += rbx;             //add rdx, rbx
        rdx ^= r11;             //xor rdx, r11
        rcx = rbx + r11 * 1;            //lea rcx, [rbx+r11*1]
        rax = 0x5D8A2246EC696B3C;               //mov rax, 0x5D8A2246EC696B3C
        rdx += rax;             //add rdx, rax
        rdx += rcx;             //add rdx, rcx
        rax = 0x8C945E987F1F1F5;                //mov rax, 0x8C945E987F1F1F5
        rdx *= rax;             //imul rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x21;           //shr rax, 0x21
        rdx ^= rax;             //xor rdx, rax
        rax = 0x196CB5113AB24AEB;               //mov rax, 0x196CB5113AB24AEB
        rdx ^= rax;             //xor rdx, rax
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        return rdx;
    }
    case 8:
    {
        //failed to translate: pop rdx
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A7D81]
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1AF03]
        rax = rdx;              //mov rax, rdx
        rax >>= 0x25;           //shr rax, 0x25
        rdx ^= rax;             //xor rdx, rax
        rdx ^= r11;             //xor rdx, r11
        rax = rdx;              //mov rax, rdx
        rax >>= 0x11;           //shr rax, 0x11
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x22;           //shr rax, 0x22
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x13;           //shr rax, 0x13
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x26;           //shr rax, 0x26
        rdx ^= rax;             //xor rdx, rax
        rax = 0xB53D569E8EFA5D77;               //mov rax, 0xB53D569E8EFA5D77
        rdx *= rax;             //imul rdx, rax
        rax = 0x107F3128814C1A69;               //mov rax, 0x107F3128814C1A69
        rdx += rax;             //add rdx, rax
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rax = 0x322692818B5C57DB;               //mov rax, 0x322692818B5C57DB
        rdx *= rax;             //imul rdx, rax
        return rdx;
    }
    case 9:
    {
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1AA52]
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A7856]
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rax = 0x7FDF1DC5F39F4AFE;               //mov rax, 0x7FDF1DC5F39F4AFE
        rdx += rax;             //add rdx, rax
        rcx = imageBase + 0x4B58CB28;              //lea rcx, [0x0000000048B340FE]
        rcx = ~rcx;             //not rcx
        rdx += r11;             //add rdx, r11
        rax = rbx;              //mov rax, rbx
        rax = ~rax;             //not rax
        rcx += rax;             //add rcx, rax
        rdx += rcx;             //add rdx, rcx
        rax = 0x46392DAC01D91715;               //mov rax, 0x46392DAC01D91715
        rdx += rax;             //add rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x14;           //shr rax, 0x14
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x28;           //shr rax, 0x28
        rdx ^= rax;             //xor rdx, rax
        rax = 0xFFFFFFFFFFFF097D;               //mov rax, 0xFFFFFFFFFFFF097D
        rax -= rbx;             //sub rax, rbx
        rax -= r11;             //sub rax, r11
        rdx += rax;             //add rdx, rax
        rax = 0x824DB652619E7A73;               //mov rax, 0x824DB652619E7A73
        rdx *= rax;             //imul rdx, rax
        return rdx;
    }
    case 10:
    {
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C1A475]
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rdx += rbx;             //add rdx, rbx
        rdx ^= rbx;             //xor rdx, rbx
        rax = rdx;              //mov rax, rdx
        rax >>= 0x1C;           //shr rax, 0x1C
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x38;           //shr rax, 0x38
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0xE;            //shr rax, 0x0E
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x1C;           //shr rax, 0x1C
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x38;           //shr rax, 0x38
        rdx ^= rax;             //xor rdx, rax
        rax = 0xDC57D1BB9FD66623;               //mov rax, 0xDC57D1BB9FD66623
        rdx *= rax;             //imul rdx, rax
        rax = 0x594CB86769CFD012;               //mov rax, 0x594CB86769CFD012
        rdx += rax;             //add rdx, rax
        rax = 0x7147A6DB682F8A7D;               //mov rax, 0x7147A6DB682F8A7D
        rdx *= rax;             //imul rdx, rax
        return rdx;
    }
    case 11:
    {
        //failed to translate: pop rdx
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A6E74]
        r12 = imageBase + 0xF59D;          //lea r12, [0xFFFFFFFFFD5B6405]
        r9 = driver::read<uintptr_t>(imageBase + 0x76731E9);               //mov r9, [0x0000000004C19FEE]
        rdx -= r11;             //sub rdx, r11
        rax = rbx;              //mov rax, rbx
        rax = ~rax;             //not rax
        rax *= r12;             //imul rax, r12
        rdx ^= rax;             //xor rdx, rax
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r9;              //xor rax, r9
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rdx -= r11;             //sub rdx, r11
        rax = 0xBF62FCF7A87514BF;               //mov rax, 0xBF62FCF7A87514BF
        rdx ^= rax;             //xor rdx, rax
        rax = 0x8A69C549C5724723;               //mov rax, 0x8A69C549C5724723
        rdx *= rax;             //imul rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x10;           //shr rax, 0x10
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x20;           //shr rax, 0x20
        rdx ^= rax;             //xor rdx, rax
        rax = 0x2C45FC6ADAFF1970;               //mov rax, 0x2C45FC6ADAFF1970
        rdx -= rax;             //sub rdx, rax
        return rdx;
    }
    case 12:
    {
        //failed to translate: pop rbx
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C19B42]
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A693F]
        rcx = imageBase + 0x2966C6A1;              //lea rcx, [0x0000000026C12E68]
        rcx = ~rcx;             //not rcx
        rax = rbx;              //mov rax, rbx
        rax = ~rax;             //not rax
        rcx *= rax;             //imul rcx, rax
        rcx -= rbx;             //sub rcx, rbx
        rdx += rcx;             //add rdx, rcx
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rax = rdx;              //mov rax, rdx
        rax >>= 0x27;           //shr rax, 0x27
        rdx ^= rax;             //xor rdx, rax
        rdx ^= rbx;             //xor rdx, rbx
        rax = 0x633CF75E24D1793B;               //mov rax, 0x633CF75E24D1793B
        rdx *= rax;             //imul rdx, rax
        rax = 0x6DE4D4E4766E6575;               //mov rax, 0x6DE4D4E4766E6575
        rdx ^= r11;             //xor rdx, r11
        rdx *= rax;             //imul rdx, rax
        return rdx;
    }
    case 13:
    {
        //failed to translate: pop rbx
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A6592]
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C19723]
        rcx = rbx;              //mov rcx, rbx
        rcx ^= rdx;             //xor rcx, rdx
        rdx = imageBase + 0x313B1A56;              //lea rdx, [0x000000002E957D28]
        rdx = ~rdx;             //not rdx
        rdx += rcx;             //add rdx, rcx
        rdx -= rbx;             //sub rdx, rbx
        rdx += r11;             //add rdx, r11
        rax = rdx;              //mov rax, rdx
        rax >>= 0x9;            //shr rax, 0x09
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x12;           //shr rax, 0x12
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x24;           //shr rax, 0x24
        rdx ^= rax;             //xor rdx, rax
        rax = 0x95C92F69A4D53BD7;               //mov rax, 0x95C92F69A4D53BD7
        rdx *= rax;             //imul rdx, rax
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= r10;             //xor rax, r10
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rax = 0x401068C5499ADEB1;               //mov rax, 0x401068C5499ADEB1
        rdx *= rax;             //imul rdx, rax
        rax = 0x11500D5FAFD1EA3E;               //mov rax, 0x11500D5FAFD1EA3E
        rdx += rax;             //add rdx, rax
        return rdx;
    }
    case 14:
    {
        //failed to translate: pop rbx
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A615B]
        r10 = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov r10, [0x0000000004C192CE]
        rdx += rbx;             //add rdx, rbx
        rdx += r11;             //add rdx, r11
        rdx -= rbx;             //sub rdx, rbx
        rax = 0x19C2516F742ABA57;               //mov rax, 0x19C2516F742ABA57
        rdx += rax;             //add rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x8;            //shr rax, 0x08
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x10;           //shr rax, 0x10
        rdx ^= rax;             //xor rdx, rax
        rcx = 0;                //and rcx, 0xFFFFFFFFC0000000
        rcx = _rotl64(rcx, 0x10);               //rol rcx, 0x10
        rcx ^= r10;             //xor rcx, r10
        rax = rdx;              //mov rax, rdx
        rcx = ~rcx;             //not rcx
        rax >>= 0x20;           //shr rax, 0x20
        rdx ^= rax;             //xor rdx, rax
        rax = 0x20E2CF726CF8A171;               //mov rax, 0x20E2CF726CF8A171
        rdx *= driver::read<uintptr_t>(rcx + 0x15);             //imul rdx, [rcx+0x15]
        rdx *= rax;             //imul rdx, rax
        return rdx;
    }
    case 15:
    {
        r11 = imageBase;           //lea r11, [0xFFFFFFFFFD5A5C04]
        r14 = imageBase + 0xF871;          //lea r14, [0xFFFFFFFFFD5B5469]
        rcx = driver::read<uintptr_t>(imageBase + 0x76731E9);              //mov rcx, [0x0000000004C18D94]
        rdx -= r11;             //sub rdx, r11
        rdx -= r11;             //sub rdx, r11
        rax = 0;                //and rax, 0xFFFFFFFFC0000000
        rax = _rotl64(rax, 0x10);               //rol rax, 0x10
        rax ^= rcx;             //xor rax, rcx
        rax = ~rax;             //not rax
        rdx *= driver::read<uintptr_t>(rax + 0x15);             //imul rdx, [rax+0x15]
        rax = rbx;              //mov rax, rbx
        rax = ~rax;             //not rax
        rax *= r14;             //imul rax, r14
        rdx ^= rax;             //xor rdx, rax
        rax = 0xF0D7C1108B9C12DA;               //mov rax, 0xF0D7C1108B9C12DA
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x1C;           //shr rax, 0x1C
        rdx ^= rax;             //xor rdx, rax
        rax = rdx;              //mov rax, rdx
        rax >>= 0x38;           //shr rax, 0x38
        rdx ^= rax;             //xor rdx, rax
        rax = 0x297750A072472125;               //mov rax, 0x297750A072472125
        rdx *= rax;             //imul rdx, rax
        rax = 0x27A21278EF078912;               //mov rax, 0x27A21278EF078912
        rdx += rax;             //add rdx, rax
        return rdx;
    }
    }
}
extern "C" auto get_bone_index(uint32_t bone_index, uint64_t imageBase) -> uint64_t
{
    uint64_t rax = imageBase, rbx = imageBase, rcx = imageBase, rdx = imageBase, rdi = imageBase, rsi = imageBase, r8 = imageBase, r9 = imageBase, r10 = imageBase, r11 = imageBase, r12 = imageBase, r13 = imageBase, r14 = imageBase, r15 = imageBase;
    rbx = bone_index;
    rcx = rbx * 0x13C8;
    rax = 0xCFC866E078EFA3E1;               //mov rax, 0xCFC866E078EFA3E1
    r11 = imageBase;           //lea r11, [0xFFFFFFFFFD952903]
    rax = _umul128(rax, rcx, (uintptr_t*)&rdx);             //mul rcx
    r10 = 0x9E946ED4CE6103ED;               //mov r10, 0x9E946ED4CE6103ED
    rdx >>= 0xD;            //shr rdx, 0x0D
    rax = rdx * 0x276D;             //imul rax, rdx, 0x276D
    rcx -= rax;             //sub rcx, rax
    rax = 0x2534988B4D1CF92F;               //mov rax, 0x2534988B4D1CF92F
    r8 = rcx * 0x276D;              //imul r8, rcx, 0x276D
    rax = _umul128(rax, r8, (uintptr_t*)&rdx);              //mul r8
    rax = r8;               //mov rax, r8
    rax -= rdx;             //sub rax, rdx
    rax >>= 0x1;            //shr rax, 0x01
    rax += rdx;             //add rax, rdx
    rax >>= 0xD;            //shr rax, 0x0D
    rax = rax * 0x37E1;             //imul rax, rax, 0x37E1
    r8 -= rax;              //sub r8, rax
    rax = 0x90D4F120190D4F13;               //mov rax, 0x90D4F120190D4F13
    rax = _umul128(rax, r8, (uintptr_t*)&rdx);              //mul r8
    rax = r8;               //mov rax, r8
    rax -= rdx;             //sub rax, rdx
    rax >>= 0x1;            //shr rax, 0x01
    rax += rdx;             //add rax, rdx
    rax >>= 0x9;            //shr rax, 0x09
    rcx = rax * 0x28E;              //imul rcx, rax, 0x28E
    rax = 0xEA0EA0EA0EA0EA0F;               //mov rax, 0xEA0EA0EA0EA0EA0F
    rax = _umul128(rax, r8, (uintptr_t*)&rdx);              //mul r8
    rdx >>= 0x5;            //shr rdx, 0x05
    rcx += rdx;             //add rcx, rdx
    rax = rcx * 0x46;               //imul rax, rcx, 0x46
    rcx = r8 + r8 * 8;              //lea rcx, [r8+r8*8]
    rcx <<= 0x3;            //shl rcx, 0x03
    rcx -= rax;             //sub rcx, rax
    rax = driver::read<uint16_t>(rcx + r11 * 1 + 0x7689AB0);                //movzx eax, word ptr [rcx+r11*1+0x7689AB0]
    r8 = rax * 0x13C8;              //imul r8, rax, 0x13C8
    rax = r10;              //mov rax, r10
    rax = _umul128(rax, r8, (uintptr_t*)&rdx);              //mul r8
    rcx = r8;               //mov rcx, r8
    rax = r10;              //mov rax, r10
    rcx -= rdx;             //sub rcx, rdx
    rcx >>= 0x1;            //shr rcx, 0x01
    rcx += rdx;             //add rcx, rdx
    rcx >>= 0xD;            //shr rcx, 0x0D
    rcx = rcx * 0x2785;             //imul rcx, rcx, 0x2785
    r8 -= rcx;              //sub r8, rcx
    r9 = r8 * 0x443C;               //imul r9, r8, 0x443C
    rax = _umul128(rax, r9, (uintptr_t*)&rdx);              //mul r9
    rax = r9;               //mov rax, r9
    rax -= rdx;             //sub rax, rdx
    rax >>= 0x1;            //shr rax, 0x01
    rax += rdx;             //add rax, rdx
    rax >>= 0xD;            //shr rax, 0x0D
    rax = rax * 0x2785;             //imul rax, rax, 0x2785
    r9 -= rax;              //sub r9, rax
    rax = 0x8888888888888889;               //mov rax, 0x8888888888888889
    rax = _umul128(rax, r9, (uintptr_t*)&rdx);              //mul r9
    rax = 0x31AFA5F1A33A0827;               //mov rax, 0x31AFA5F1A33A0827
    rdx >>= 0x3;            //shr rdx, 0x03
    rcx = rdx * 0xF;                //imul rcx, rdx, 0x0F
    rax = _umul128(rax, r9, (uintptr_t*)&rdx);              //mul r9
    rdx >>= 0x8;            //shr rdx, 0x08
    rcx += rdx;             //add rcx, rdx
    rax = rcx * 0xA4E;              //imul rax, rcx, 0xA4E
    rcx = r9 * 0xA50;               //imul rcx, r9, 0xA50
    rcx -= rax;             //sub rcx, rax
    rsi = driver::read<uint16_t>(rcx + r11 * 1 + 0x7694D90);                //movsx esi, word ptr [rcx+r11*1+0x7694D90]
    return rsi;
}