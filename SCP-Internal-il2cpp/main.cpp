#include "il2cpp.h"
#include "utils.h"
#include "memory.h"
#include "veh.h"

bool playerEsp = true;
bool scp914esp = true;
bool liftEsp = false;
bool bhop = false;
int selectedOption = 0; // 0 = visuals, 1 = game, 2 = misc
int OpenedOption = -1; // 0 = visuals, 1 = game, 2 = misc
int visualSelect = 0;
int gameSelect = 0;
int miscSelect = 0;
bool openedMenu = false;

void OnGUI(PEXCEPTION_POINTERS ExceptionInfo) {

	il2cpp::draw_text(Rect{ 5, 30, 100.0f, 100.0f }, "<color=lightblue>The Escape v0.2 Beta</color>");


#pragma region Input System
	if (openedMenu) {
#pragma region if subenu not opened
		if (OpenedOption == -1 && openedMenu == true) {
			switch (selectedOption) {
			case 0:
				il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=yellow>Visuals</color>");
				il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=white>Game</color>");
				il2cpp::draw_text(Rect{ 5, 150, 100.0f, 100.0f }, "<color=white>Misc</color>");
				break;
			case 1:
				il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=white>Visuals</color>");
				il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=yellow>Game</color>");
				il2cpp::draw_text(Rect{ 5, 150, 100.0f, 100.0f }, "<color=white>Misc</color>");
				break;
			case 2:
				il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=white>Visuals</color>");
				il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=white>Game</color>");
				il2cpp::draw_text(Rect{ 5, 150, 100.0f, 100.0f }, "<color=yellow>Misc</color>");
				break;
			}
		}
		else {

		}
	}
	else {
		il2cpp::draw_text(Rect{ 5, 60, 100.0f, 100.0f }, "<color=white>Press INSERT to open menu.</color>");
	}
#pragma endregion
#pragma region visuals menu opened
	if (OpenedOption == 0 && openedMenu == true) {
		switch (visualSelect) {
		case 0:
			il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=yellow>Player ESP</color>");
			il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=white>SCP-914 ESP</color>");
			il2cpp::draw_text(Rect{ 5, 150, 100.0f, 100.0f }, "<color=white>Item ESP [Not Working]</color>");
			il2cpp::draw_text(Rect{ 5, 170, 100.0f, 100.0f }, "<color=white>Lift ESP</color>");
			il2cpp::draw_text(Rect{ 5, 210, 100.0f, 100.0f }, "<color=white>Back</color>");
			break;
		case 1:
			il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=white>Player ESP</color>");
			il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=yellow>SCP-914 ESP</color>");
			il2cpp::draw_text(Rect{ 5, 150, 100.0f, 100.0f }, "<color=white>Item ESP [Not Working]</color>");
			il2cpp::draw_text(Rect{ 5, 170, 100.0f, 100.0f }, "<color=white>Lift ESP</color>");
			il2cpp::draw_text(Rect{ 5, 210, 100.0f, 100.0f }, "<color=white>Back</color>");
			break;
		case 2:
			il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=white>Player ESP</color>");
			il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=white>SCP-914 ESP</color>");
			il2cpp::draw_text(Rect{ 5, 150, 100.0f, 100.0f }, "<color=yellow>Item ESP [Not Working]</color>");
			il2cpp::draw_text(Rect{ 5, 170, 100.0f, 100.0f }, "<color=white>Lift ESP</color>");
			il2cpp::draw_text(Rect{ 5, 210, 100.0f, 100.0f }, "<color=white>Back</color>");
			break;
		case 3:
			il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=white>Player ESP</color>");
			il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=white>SCP-914 ESP</color>");
			il2cpp::draw_text(Rect{ 5, 150, 100.0f, 100.0f }, "<color=white>Item ESP [Not Working]</color>");
			il2cpp::draw_text(Rect{ 5, 170, 100.0f, 100.0f }, "<color=yellow>Lift ESP</color>");
			il2cpp::draw_text(Rect{ 5, 210, 100.0f, 100.0f }, "<color=white>Back</color>");
			break;
		case 4:
			il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=white>Player ESP</color>");
			il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=white>SCP-914 ESP</color>");
			il2cpp::draw_text(Rect{ 5, 150, 100.0f, 100.0f }, "<color=white>Item ESP [Not Working]</color>");
			il2cpp::draw_text(Rect{ 5, 170, 100.0f, 100.0f }, "<color=white>Lift ESP</color>");
			il2cpp::draw_text(Rect{ 5, 210, 100.0f, 100.0f }, "<color=yellow>Back</color>");
			break;
		}
	}
	else if (OpenedOption == 1 && openedMenu == true) {

	}
#pragma endregion
#pragma region misc menu opened
	if (OpenedOption == 2 && openedMenu == true) {
		switch (miscSelect) {
		case 0:
			il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=yellow>Bunny Hop</color>");
			il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=white>Back</color>");
			break;
		case 1:
			il2cpp::draw_text(Rect{ 5, 90, 100.0f, 100.0f }, "<color=white>Bunny Hop</color>");
			il2cpp::draw_text(Rect{ 5, 120, 100.0f, 100.0f }, "<color=yellow>Back</color>");
			break;
		}
	}
	else if (OpenedOption == 1 && openedMenu == true) {

	}
#pragma endregion
	if (GetAsyncKeyState(VK_RIGHT) & 1) {
		if (OpenedOption == -1) {
			switch (selectedOption) {
			case 0:
				OpenedOption = 0;
				break;
			case 1:
				OpenedOption = 1;
				break;
			case 2:
				OpenedOption = 2;
				break;
			}
		}
		else {
			if (OpenedOption == 0) {
				switch (visualSelect) {
				case 0:
					playerEsp = !playerEsp;
					break;
				case 1:
					scp914esp = !scp914esp;
					break;
				case 2:

					break;
				case 3:
					liftEsp = !liftEsp;
					break;
				case 4:
					OpenedOption = -1;
					break;
				}
			}
			else if (OpenedOption == 2) {
				switch (miscSelect) {
				case 0:
					bhop = !bhop;
					break;
				case 1:
					OpenedOption = -1;
					break;
				}
			}
		}
	}

	if (GetAsyncKeyState(VK_UP) & 1) {
		if (OpenedOption == -1)
		{
			selectedOption--;
		}
		else if (OpenedOption == 0) {
			visualSelect--;
		}
		else if (OpenedOption == 2) {
			miscSelect--;
		}
	}
	else if (GetAsyncKeyState(VK_DOWN) & 1) {
		if (OpenedOption == -1)
		{
			selectedOption++;
		}
		else if (OpenedOption == 0) {
			visualSelect++;
		}
		else if (OpenedOption == 2) {
			miscSelect++;
		}
	}

	if (selectedOption == 3) {
		selectedOption = 0;
	}
	if (selectedOption == -1) {
		selectedOption = 3;
	}
	if (visualSelect == 5) {
		visualSelect = 0;
	}
	if (visualSelect == -1) {
		visualSelect = 4;
	}
	if (miscSelect == -1) {
		miscSelect = 1;
	}
	if (miscSelect == 2) {
		miscSelect = 0;
	}

	if (GetAsyncKeyState(VK_INSERT) & 1) {
		openedMenu = !openedMenu;
	}
#pragma endregion

#pragma region bunnyhop
	/*if (GetKeyState(VK_SPACE)) {
		INPUT ip;
		// ...
			// Set up a generic keyboard event.
		ip.type = INPUT_KEYBOARD;
		ip.ki.wScan = 0; // hardware scan code for key
		ip.ki.time = 0;
		ip.ki.dwExtraInfo = 0;

		// Press the "A" key
		ip.ki.wVk = 0x20; // virtual-key code for the "a" key
		ip.ki.dwFlags = 0; // 0 for key press
		if (bhop)
		{
			SendInput(1, &ip, sizeof(INPUT));
			Sleep(100);
		}
	}*/

#pragma endregion

	camera = il2cpp::get_current_camera();
	if (!camera) return;
	matrix = il2cpp::get_viewmatrix(camera);
	cameraPosition = il2cpp::get_camera_position(camera);

	if (!camera) {
		entityList.clear();
		return;
	}



	auto screenCenterX = il2cpp::get_screen_width() * 0.5;

	auto screenCenterY = il2cpp::get_screen_height() * 0.5;


	char buf[100];
	char buf2[100];
	il2cpp::draw_text(Rect{ 5, 45, 100.0f, 100.0f }, "<color=white><size=10>Made by Dupec</size></color>");


	// draw players
	for (int i = 0; i < entityList.size(); i++) {
		vec2 out;

		if (WorldToScreen(matrix, entityList[i].position, out, screenCenterX, screenCenterY)) {

			float dist = GetDistance(cameraPosition, entityList[i].position);
			//auto color = "white";

			//if (dist < 1) {
			//	return;
			//}
			/*if (dist > 500) {
				return;
			}*/

			sprintf(buf, "<color=%s>%s - %.2f</color>", TeamColor[entityList[i].team], TeamName[entityList[i].team], dist);
			if (playerEsp)
			{
				il2cpp::draw_text(Rect{ out.X, out.Y, 10000.0f, 10000.0f }, buf);
			}

		}
	}
	entityList.clear();

	// find scp-914
	std::vector<Entity> tmp;
	auto location = il2cpp::find_entities("914_use");
	int objects_num = Read<int>((pointer)location + offset::unity_list_len);
	if (objects_num) {
		auto object = Read<pointer>((pointer)location + offset::unity_list_start);

		vec3 position;
		il2cpp::get_transform(object, &position);
		tmp.push_back({
			object,
			position,
			"[ SCP-914 ]"
			});
	}
	locationList = tmp;

	// draw locations
	for (int i = 0; i < locationList.size(); i++) {
		vec2 out;
		auto screenCenterYs = il2cpp::get_screen_height();
		auto screenCenterXs = il2cpp::get_screen_width();
		if (WorldToScreen(matrix, locationList[i].position, out, screenCenterX, screenCenterY)) {


			float dist = GetDistance(cameraPosition, locationList[i].position);
			auto color = "yellow";
			auto color2 = "yellow";

			sprintf(buf, "<color=%s>%s - %.2f</color>", color, locationList[0].name, dist);
			if (scp914esp)
			{
				il2cpp::draw_text(Rect{ out.X, out.Y, 100.0f, 100.0f }, buf);
			}
			if (liftEsp)
			{
				il2cpp::draw_text(Rect{ out.X, out.Y, 100.0f, 100.0f }, buf);
			}

		}
	}
}

void PlayerStats_Update(PEXCEPTION_POINTERS ExceptionInfo) {

	// components are at Rcx
	auto PlayerStats_Component = ExceptionInfo->ContextRecord->Rcx;
	pointer ccm = Read<pointer>(PlayerStats_Component + offset::PlayerStats_ccm);
	auto team = Read<int>(ccm + offset::ccm_team);
	auto test = Read<bool>(offset::noclip);


	// this is how to combine player gameobject with component data
	// it's ok to call il2cpp api here as we're inside game thread inside any VEH hook
	auto player = il2cpp::get_gameobject(PlayerStats_Component);

	// why don't we collect other data here
	vec3 position;
	il2cpp::get_transform(player, &position);

	// different thread forces us to recreate a list
	// it looks as a bad design but it works so I don't care actually if it's bad
	std::vector<Entity> tmp;
	bool found = false;

	for (int i = 0; i < entityList.size(); i++) {
		if (entityList[i].address == player) {
			found = true;
			// override position for cached entity
			entityList[i].position = position;
			entityList[i].ccm = ccm;
			entityList[i].team = team;
		}
		tmp.push_back(entityList[i]);
	}
	entityList = tmp;
	tmp.clear();

	if (!found) {
		entityList.push_back(Entity{
			player,
			position,
			"UNNAMED", // add nickname here after
			ccm,
			team
			});
	}

}

BOOL WINAPI DllMain(HINSTANCE hinstDll, DWORD fdwReason, LPVOID lpvReserved) {
	if (fdwReason == DLL_PROCESS_ATTACH) {

		auto base = il2cpp::GetModuleBase();
		il2cpp::Init();

		// hooking with VEH example
		AddVectoredExceptionHandler(1, CorruptionHandler);
		VEH.Append(base + offset::PlayerStats_Update, &PlayerStats_Update);
		VEH.Append(base + offset::GUI, &OnGUI);

	}
	return true;
}
