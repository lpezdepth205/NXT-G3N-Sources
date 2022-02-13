#pragma once

class Player
{
public:
	static Player* GetCurrentActor(int i) {
		if (!Addresses::BASE) return nullptr;
		return (Player*)Addresses::BASE + (i * offsets::Player_Size);
	}
	static Player* GetLocalActor() {
		if (!Addresses::BASE) return nullptr;
		auto local_index = driver::read<uintptr_t>(Addresses::INFO + offsets::Local_Index);
		return (Player*)Addresses::BASE + (driver::read<int>(local_index + 0x1FC) * offsets::Player_Size);
	}
	Vector3 GetBottomPos() {
		uint64_t posptr = driver::read<uint64_t>((uintptr_t)this + offsets::Player_Pos_Info);
		return driver::read<Vector3>(posptr + 0x40);
	}
	uint32_t getIndex() {
		return ((uintptr_t)this - Addresses::BASE) / offsets::Player_Size;
	}
	NameEntry GetNameEntry() {
		auto i = getIndex();
		return driver::read<NameEntry>(Addresses::NAMES + (i * offsets::Name_Size));
	}
	bool isDead() {
		uint32_t d1 = driver::read<uint32_t>((uintptr_t)this + offsets::Dead_1);
		uint32_t d2 = driver::read<uint32_t>((uintptr_t)this + offsets::Dead_2);
		uint32_t v = driver::read<uint32_t>((uintptr_t)this + offsets::Player_Valid);

		return !(!d1 && !d2 && v == 1);
	}
};

class FW
{
public:
	Vector3 GetLocalPlayerPosition()
	{
		uint64_t CameraPtr = driver::read<uint64_t>(No_Define::BaseAddress + offsets::Camera_Base);
		return driver::read<Vector3>(CameraPtr + offsets::Camera_Pos);
	}

	Vector2 WorldToScreen(Vector3 worldLocation, Vector3 cameraPosition, int screenWidth, int screenHeight, Vector2 fieldOfView, Vector3* matrices)
	{
		Vector2 PosW2S;
		Vector3 local = worldLocation - cameraPosition;

		Vector3 trans = Vector3(local.Dot(matrices[1]), local.Dot(matrices[2]), local.Dot(matrices[0]));

		if (trans.z < 0.01f)
			return Vector2(0, 100000);

		PosW2S.x = (((float)screenWidth / 2) * (1 - (trans.x / fieldOfView.x / trans.z)));
		PosW2S.y = (((float)screenHeight / 2) * (1 - (trans.y / fieldOfView.y / trans.z)));

		//if (PosW2S.x > screenWidth || PosW2S.x < 0) {
		//	return Vector2(0, screenHeight);
		//}

		return PosW2S;
	}

	bool IsInScreen(Vector2 Head_W2S, Vector2 Bottom_W2S, int Width, int Height) {
		float PawnHeight = abs(Head_W2S.y - Bottom_W2S.y);
		float PawnWidth = PawnHeight * 0.25;
		if (Head_W2S.x - PawnWidth / 2 > Width || Head_W2S.x + PawnWidth / 2 < 0 || Head_W2S.y > Height || Head_W2S.y + PawnHeight < 0) {
			return false;
		}
		else {
			return true;
		}
	}
};
FW* Framework;

