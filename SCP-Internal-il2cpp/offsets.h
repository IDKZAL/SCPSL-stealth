#pragma once
#include "pointer.h"

namespace offset {

	// il2cpp
	constexpr pointer create_text = 0x1215D50;			//internal static GUIContent Temp(string t) { }
	constexpr pointer draw_text = 0x122A6A0;			//public static void Label(Rect position, GUIContent content, GUIStyle style) { }
	constexpr pointer none_style = 0x1223F10;			//public static GUIStyle get_none() { }

	// camera
	constexpr pointer camera = 0x10;
	constexpr pointer matrix = 0xDC;
	constexpr pointer camera_position = 0x42C;

	// unit3d
	constexpr pointer unity_list_len = 0x18;
	constexpr pointer unity_list_start = 0x20;
	constexpr pointer unity_list_offset = 0x8;

	// PlayerStats
	constexpr pointer PlayerStats_Update = 0x393290;	//public class PlayerStats : NetworkBehaviour //private void Update() { }
	constexpr pointer PlayerStats_ccm = 0x70;
	constexpr pointer ccm_team = 0x158;

	// render
	constexpr pointer GUI = 0x667F80;					//public class PostProcessingBehaviour : MonoBehaviour //private void OnGUI() { }

	//game
	constexpr pointer recoilAnim = 0x60;
	constexpr pointer spread = 0xC4;
	constexpr pointer recoilyOverride = 0x3C;
	constexpr pointer noclip = 0x122;
}