#pragma once
#include <Windows.h>
#include <stdint.h>
#include <iostream>
#include <vector>
#include <string>
#include <filesystem>

#include "no_portable_executable.hpp"
#include "no_utils.hpp"
#include "no_nt.hpp"
#include "no_intel_driver.hpp"

namespace kdmapper
{
	uint64_t MapDriver(HANDLE iqvw64e_device_handle, ULONG64 param1, ULONG64 param2, bool free, bool destroyHeader);
	void RelocateImageByDelta(portable_executable::vec_relocs relocs, const uint64_t delta);
	bool ResolveImports(HANDLE iqvw64e_device_handle, portable_executable::vec_imports imports);
	bool InitializeDriver();
}