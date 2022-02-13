#pragma once

/* ==== STRUCTS ===================*/

struct Box3DContainer {
	Vector2 bottom1;
	Vector2 bottom2;
	Vector2 bottom3;
	Vector2 bottom4;

	Vector2 top1;
	Vector2 top2;
	Vector2 top3;
	Vector2 top4;
};


struct RefdefView {
	Vector2 tanHalfFov;		// 0x00
	uint8_t unk1[0xC];		// 0x08
	Vector3 axis[3];      // 0x14
};

struct refdef_t {
	int x;           // 0x00
	int y;           // 0x04
	int width;       // 0x08
	int height;      // 0x0C
	RefdefView view; // 0x10

	bool operator==(const refdef_t& v)
	{
		if (x == v.x && y == v.y && width == v.width && height == v.height && view.axis->x == v.view.axis->x && view.axis->y == v.view.axis->y && view.axis->z == v.view.axis->z && view.tanHalfFov.x == v.view.tanHalfFov.x && view.tanHalfFov.y == v.view.tanHalfFov.y && view.unk1 == v.view.unk1) {
			return true;
		}
		else {
			return false;
		}
	}
};

struct refdefKeyStruct
{
	DWORD ref0; // 0x00
	DWORD ref1; // 0x04
	DWORD ref2; // 0x08
};

struct NameEntry {
	uint32_t idx;
	char name[0x24];
	uint8_t unk1[0x64];
	uint32_t health;
};
/* =================================*/

bool is_bad_ptr(void* adr) { return adr == nullptr; }
bool IsValidPointer(void* addr) { return !is_bad_ptr(addr); }

namespace utils {
	
	void log(const char* str) {
		std::cout << str << std::endl;
	}
}


namespace offsets {

	constexpr auto Camera_Base = 0x143A97E0; // ok

	constexpr auto Camera_Pos = 0x1D8; // ok

	constexpr auto Local_Index = 0x1C180; // ok

	constexpr auto CLIENT_INFO = 0x1725C718; // ok

	constexpr auto CLIENT_BASE = 0x9DC08; // ok

	constexpr auto Ref_Def = 0x1725F0C8; // ok

	constexpr auto Dead_1 = 0x389C; // ok

	constexpr auto Dead_2 = 0x2A28; // ok

	constexpr auto Player_Pos_Info = 0x38C8; // ok

	constexpr auto Player_Size = 0x3AD0; // ok

	constexpr auto Player_Team = 0x3688; // ok

	constexpr auto Player_Valid = 0x368C; // ok

	constexpr auto Name_Array = 0x1726A6B8; // ok

	constexpr auto Name_Array_Padding = 0x4C70; // ok

	constexpr auto Name_Size = 0xD0; // ok
}


namespace decryption
{


	auto DecryptClientInfo(uint64_t enc_client) -> uint64_t
	{

		ULONG64 rax = 0, rbx = 0, rcx = 0, rdx = 0, rdi = 0, rsi = 0, r8 = 0, r9 = 0, r10 = 0, r11 = 0, r12 = 0, r13 = 0, r14 = 0, r15 = 0, rbp = 0;

		rdx = No_Define::PEB;
		rbx = enc_client;

		if (rbx == 0) {
			return 0;
		}

		r8 = No_Define::BaseAddress;
		rcx = (No_Define::BaseAddress + 0x74);
		rax -= rcx;
		rax = 0; // bruh
		rax = _rotl64(rax, 0x10);
		rax ^= driver::read<ULONG64>(No_Define::BaseAddress + 0x63F00E7);
		rax = _byteswap_uint64(rax);
		rcx = driver::read<ULONG64>(rax + 0x15);
		rax = 0xD0A5CFDC3774A915;
		rcx *= rbx;
		rcx -= r8;
		rcx ^= rdx;
		rcx *= rax;
		rax = rcx;
		rax >>= 0x1E;
		rcx ^= rax;
		rax = 0x5DF7F5B38F85AA2;
		rbx = rcx;
		rbx >>= 0x3C;
		rbx ^= rcx;
		rbx ^= rax;
		return rbx;
	}




	auto DecryptClientBase(uint64_t encrypted_clientbase) -> uint64_t
	{
		ULONG64 rax = No_Define::BaseAddress, rcx = No_Define::BaseAddress, rdx = No_Define::BaseAddress, r8 = No_Define::BaseAddress, r9 = No_Define::BaseAddress, r10 = No_Define::BaseAddress, r11 = No_Define::BaseAddress, r12 = No_Define::BaseAddress, r13 = No_Define::BaseAddress, r14 = No_Define::BaseAddress, r15 = No_Define::BaseAddress, rsi = No_Define::BaseAddress, rdi = No_Define::BaseAddress; // hardcoded lol
		ULONG64 rbx = No_Define::PEB;
		rbx = ~rbx;
		rax = encrypted_clientbase;
		rcx = rbx;
		rcx = _rotl64(rcx, 0x2f);
		rcx &= 0xf;

		switch (rcx)
		{
		case 0:
		{ r11 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		r15 = (No_Define::BaseAddress + 0xBD1A);
		rdx = No_Define::BaseAddress;
		r8 = 0; // bruh
		rdx += 0x6D3D;
		rcx = rax;
		r8 = _rotl64(r8, 0x10);
		rcx >>= 0x24;
		rdx += rbx;
		rdx ^= rcx;
		r8 ^= r11;
		rdx ^= rax;
		rcx = 0x19C47EFAC587AEE9;
		r8 = (~r8);
		rax = driver::read<ULONG64>(r8 + 0x15);
		rax *= rdx;
		rax -= rcx;
		rcx = rbx;
		rcx ^= r15;
		rax -= rcx;
		rcx = 0x4EA279D89E7A76A2;
		rax ^= rcx;
		rdx = (No_Define::BaseAddress + 0x423B9DEB);
		rdx = (~rdx);
		rcx = 0x43FD711B3D38D0F3;
		rax *= rcx;
		rax += rbx;
		rax += rdx;
		return rax;
		}

		case 1:
		{ r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		r15 = (No_Define::BaseAddress + 0x87C1);
		r14 = No_Define::BaseAddress;
		rcx = r15;
		rcx = (~rcx);
		rcx ^= rbx;
		rcx -= r14;
		rax += rcx;
		rcx = rax;
		rcx >>= 0x13;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x26;
		rax ^= rcx;
		rcx = 0x27C4A1F3C8190AD7;
		rax += rcx;
		rcx = 0x41CE9E6C03DCB817;
		rcx += rax;
		rdx = 0; // bruh
		rdx = _rotl64(rdx, 0x10);
		rdx ^= r10;
		rdx = (~rdx);
		rax = driver::read<ULONG64>(rdx + 0x15);
		rax *= rcx;
		rcx = 0xF859067C423FBB5B;
		rax *= rcx;
		rcx = No_Define::BaseAddress;
		rax -= rcx;
		return rax;
		}

		case 2:
		{ rdx = (No_Define::BaseAddress + 0x5290CD22);
		r15 = (No_Define::BaseAddress + 0x71A0);
		r8 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		r9 = (No_Define::BaseAddress + 0xB39E);
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r8;
		rcx = (~rcx);
		rax *= driver::read<ULONG64>(rcx + 0x15);
		rcx = rbx;
		rcx ^= rdx;
		rax -= rcx;
		rcx = rbx;
		rcx ^= r9;
		rax += rcx;
		rcx = 0xAA6DA70B0F6DAE23;
		rax *= rcx;
		rcx = (No_Define::BaseAddress + 0x69487DB0);
		rcx = (~rcx);
		rax -= rbx;
		rax += rcx;
		rcx = No_Define::BaseAddress;
		rax += rcx;
		rcx = r15;
		rcx = (~rcx);
		rax ^= rcx;
		rax ^= rbx;
		rcx = rax;
		rcx >>= 0x22;
		rax ^= rcx;
		return rax;
		}

		case 3:
		{ r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		r15 = (No_Define::BaseAddress + 0x444A635C);
		r14 = (No_Define::BaseAddress + 0x2F52);
		rcx = rbx;
		rcx ^= r14;
		rax += rcx;
		rdx = rbx + 0x1;
		rcx = rax;
		rax = 0x6CB99C3AB3E4AA31;
		rax *= rcx;
		rdx *= r15;
		rax += rdx;
		rdx = rbx;
		rcx = (No_Define::BaseAddress + 0xE7D9);
		rdx *= rcx;
		rcx = rax;
		rax = 0xB6328DDA68ED17F9;
		rax *= rcx;
		rax += rdx;
		rcx = rax;
		rcx >>= 0x20;
		rax ^= rcx;
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r10;
		rcx = (~rcx);
		rax *= driver::read<ULONG64>(rcx + 0x15);
		rcx = 0x6D09E41DF76C1F04;
		rax += rcx;
		return rax;
		}

		case 4:
		{ r14 = (No_Define::BaseAddress + 0x99BF);
		r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rax -= rbx;
		rcx = No_Define::BaseAddress;
		rax += rcx;
		rcx = 0x7718F57492FD9F2B;
		rax *= rcx;
		rcx = 0xF10ED626E9BFC42;
		rax -= rcx;
		rcx = rax;
		rcx >>= 0xA;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x14;
		rax ^= rcx;
		rdx = 0; // bruh
		rcx = rax;
		rdx = _rotl64(rdx, 0x10);
		rcx >>= 0x28;
		rdx ^= r10;
		rcx ^= rax;
		rdx = (~rdx);
		rax = driver::read<ULONG64>(rdx + 0x15);
		rax *= rcx;
		rcx = rbx;
		rcx = (~rcx);
		rax ^= rcx;
		rax ^= r14;
		rax ^= rbx;
		rcx = No_Define::BaseAddress;
		rax += rcx;
		return rax;
		}

		case 5:
		{ r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rcx = rax;
		rcx >>= 0x4;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x8;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x10;
		rax ^= rcx;
		rdx = 0; // bruh
		rdx = _rotl64(rdx, 0x10);
		rcx = rax;
		rdx ^= r10;
		rcx >>= 0x20;
		rdx = (~rdx);
		rcx ^= rax;
		rax = driver::read<ULONG64>(rdx + 0x15);
		rax *= rcx;
		rcx = No_Define::BaseAddress;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0xB;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x16;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x2C;
		rax ^= rcx;
		rax -= rbx;
		rcx = No_Define::BaseAddress;
		rax -= rcx;
		rcx = 0x57BA5D42F39CB48F;
		rax *= rcx;
		rcx = 0x3C255B6F308D39F3;
		rax -= rcx;
		rcx = 0x4EB350EBB80329DE;
		rax += rcx;
		return rax;
		}

		case 6:
		{ r14 = (No_Define::BaseAddress + 0xFCD4);
		r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rcx = rbx;
		rcx = (~rcx);
		rcx += 0xFFFFFFFFFFFF8A16;
		rax += rcx;
		rcx = rax;
		rcx >>= 0x24;
		rax ^= rcx;
		rcx = r14;
		rcx = (~rcx);
		rcx ^= rbx;
		rax += rcx;
		rdx = 0; // bruh
		rdx = _rotl64(rdx, 0x10);
		rdx ^= r10;
		rcx = 0x23B6B27E58873612;
		rcx += rax;
		rdx = (~rdx);
		rax = driver::read<ULONG64>(rdx + 0x15);
		rdx = (No_Define::BaseAddress + 0x249DC2E2);
		rax *= rcx;
		rcx = rbx;
		rcx *= rdx;
		rax += rcx;
		rcx = rbx;
		rcx *= 0x7FF76423F848;
		rax += rcx;
		rcx = 0x367DDA4A5AD2A0F9;
		rax *= rcx;
		return rax;
		}

		case 7:
		{ r9 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		r11 = (No_Define::BaseAddress + 0x5BBF4369);
		rcx = rbx;
		rcx *= r11;
		rax ^= rcx;
		rcx = 0x6943CD5078E59F4C;
		rax -= rcx;
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r9;
		rcx = (~rcx);
		rax *= driver::read<ULONG64>(rcx + 0x15);
		rax -= rbx;
		rcx = 0x4BE1F63D04536275;
		rax *= rcx;
		rcx = 0x533C0A831F997907;
		rax -= rcx;
		rcx = rax;
		rcx >>= 0x24;
		rax ^= rcx;
		rcx = No_Define::BaseAddress;
		rax += rcx;
		return rax;
		}

		case 8:
		{ r14 = (No_Define::BaseAddress + 0x4294B831);
		r9 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rcx = No_Define::BaseAddress;
		rax -= rcx;
		rcx = 0xDFBB47091E2379D1;
		rax *= rcx;
		rcx = No_Define::BaseAddress;
		rax -= rbx;
		rax -= rcx;
		rax -= 0x57C1;
		rcx = rbx;
		rcx = (~rcx);
		rcx ^= r14;
		rax -= rcx;
		rcx = 0xEA38C395BDED4C2B;
		rax *= rcx;
		rcx = rax;
		rcx >>= 0x7;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0xE;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x1C;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x38;
		rax ^= rcx;
		rax += rbx;
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r9;
		rcx = (~rcx);
		rax *= driver::read<ULONG64>(rcx + 0x15);
		return rax;
		}

		case 9:
		{ r9 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		r11 = (No_Define::BaseAddress + 0x3963F2D5);
		rcx = rax;
		rcx >>= 0xA;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x14;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x28;
		rcx ^= rbx;
		rax ^= rcx;
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r9;
		rcx = (~rcx);
		rax *= driver::read<ULONG64>(rcx + 0x15);
		r14 = 0x4304ABC2E9DAF7B5;
		rcx = rbx;
		rcx *= r11;
		rcx += r14;
		rax += rcx;
		rcx = 0xA2D1C45CD47B5815;
		rax ^= rcx;
		rcx = 0x3991B86092B435F7;
		rax *= rcx;
		rax += rbx;
		return rax;
		}

		case 10:
		{ r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rcx = rax;
		rcx >>= 0x17;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x2E;
		rax ^= rcx;
		rcx = 0xE10CA2A3F094DAD5;
		rax *= rcx;
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r10;
		rcx = (~rcx);
		rcx = driver::read<ULONG64>(rcx + 0x15);
		rax *= rcx;
		rax ^= rbx;
		rcx = 0x5B22F063E483098D;
		rax -= rcx;
		rcx = 0xCB31748E690CA23B;
		rax *= rcx;
		rcx = No_Define::BaseAddress;
		rax += rcx;
		rax ^= rbx;
		return rax;
		}

		case 11:
		{ r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		r15 = (No_Define::BaseAddress + 0x17A2290B);
		rcx = rbx;
		rcx = (~rcx);
		rcx ^= r15;
		rax += rcx;
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r10;
		rcx = (~rcx);
		rax *= driver::read<ULONG64>(rcx + 0x15);
		rax += rbx;
		rcx = rax;
		rcx >>= 0x9;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x12;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x24;
		rax ^= rcx;
		rcx = No_Define::BaseAddress;
		rax -= rbx;
		rax -= rcx;
		rcx = 0x2984367D8449DAAF;
		rax += rcx;
		rcx = 0x4A9F47BAF796D4F9;
		rax *= rcx;
		rcx = 0x3822ED53B9CB22DB;
		rax *= rcx;
		return rax;
		}

		case 12:
		{ r14 = (No_Define::BaseAddress + 0x5236BA8C);
		r9 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rax += rbx;
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r9;
		rcx = (~rcx);
		rax *= driver::read<ULONG64>(rcx + 0x15);
		rcx = rbx;
		rcx ^= r14;
		rax += rcx;
		rcx = rax;
		rcx >>= 0xF;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x1E;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x3C;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x6;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0xC;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x18;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x30;
		rax ^= rcx;
		rcx = 0xCB49589254AD2C1F;
		rax ^= rcx;
		rcx = 0x571A9E0627BB6D05;
		rax *= rcx;
		return rax;
		}

		case 13:
		{ r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rcx = (No_Define::BaseAddress + 0x97DF);
		rcx = (~rcx);
		rcx *= rbx;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0xA;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x14;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x28;
		rax ^= rcx;
		rcx = 0x71B69F5249706F47;
		rax ^= rcx;
		rcx = 0xBFF1D3562C584085;
		rax ^= rcx;
		rcx = 0x5F4A7D0706034A1D;
		rax *= rcx;
		rcx = rax;
		rcx >>= 0x16;
		rax ^= rcx;
		rdx = 0; // bruh
		rdx = _rotl64(rdx, 0x10);
		rcx = rax;
		rdx ^= r10;
		rcx >>= 0x2C;
		rdx = (~rdx);
		rcx ^= rax;
		rax = No_Define::BaseAddress;
		rcx -= rax;
		rax = driver::read<ULONG64>(rdx + 0x15);
		rax *= rcx;
		return rax;
		}

		case 14:
		{ r9 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rcx = rax;
		rcx >>= 0x17;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x2E;
		rax ^= rcx;
		rcx = No_Define::BaseAddress;
		rax ^= rcx;
		rcx = rbx;
		rcx -= 0x212E5BD5;
		rax ^= rcx;
		rcx = No_Define::BaseAddress;
		rax -= rcx;
		rcx = 0x1A29FA97C77E3EF4;
		rax += rcx;
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r9;
		rcx = (~rcx);
		rcx = driver::read<ULONG64>(rcx + 0x15);
		rcx *= 0xDE56BDEADD1E6E27;
		rax *= rcx;
		rcx = 0xC87391EE14AB9EA1;
		rax *= rcx;
		return rax;
		}

		case 15:
		{ r10 = driver::read<ULONG64>(No_Define::BaseAddress + 0x63F011E);
		rcx = 0; // bruh
		rcx = _rotl64(rcx, 0x10);
		rcx ^= r10;
		rcx = (~rcx);
		rax *= driver::read<ULONG64>(rcx + 0x15);
		rcx = No_Define::BaseAddress;
		rax -= rcx;
		rax -= rbx;
		rcx = rax;
		rcx >>= 0x26;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x17;
		rax ^= rcx;
		rcx = rax;
		rcx >>= 0x2E;
		rax ^= rcx;
		rcx = 0xC4963F1B7D0D44A3;
		rax *= rcx;
		rax -= rbx;
		rcx = 0xCE4DFFA509C55D61;
		rax *= rcx;
		return rax;
		}
		default:
			return 0;
		}
	}


	auto DecryptRef_Def(refdefKeyStruct crypt) -> uint64_t
	{
		uint64_t baseAddr = No_Define::BaseAddress;

		DWORD lower = crypt.ref0 ^ (crypt.ref2 ^ (uint64_t)(baseAddr + offsets::Ref_Def)) * ((crypt.ref2 ^ (uint64_t)(baseAddr + offsets::Ref_Def)) + 2);
		DWORD upper = crypt.ref1 ^ (crypt.ref2 ^ (uint64_t)(baseAddr + offsets::Ref_Def + 0x4)) * ((crypt.ref2 ^ (uint64_t)(baseAddr + offsets::Ref_Def + 0x4)) + 2);

		return (uint64_t)upper << 32 | lower; // Merge Both DWORD into QWORD
	}
}

uint64_t GetRefDef()
{
	auto encRef_Def = driver::read<refdefKeyStruct>(No_Define::BaseAddress + offsets::Ref_Def);
	return decryption::DecryptRef_Def(encRef_Def);
}
uint64_t GetClientInfo() {
	auto encinfo = driver::read<uint64_t>(No_Define::BaseAddress + offsets::CLIENT_INFO);
	return decryption::DecryptClientInfo(encinfo);
}
uint64_t GetClientBase(uint64_t client_info) {
	auto encbase = driver::read<uint64_t>(client_info + offsets::CLIENT_BASE);
	return decryption::DecryptClientBase(encbase);
}
uint64_t GetNameList() {
	auto ptr = driver::read<uint64_t>(No_Define::BaseAddress + offsets::Name_Array);
	return ptr + offsets::Name_Array_Padding;
}
