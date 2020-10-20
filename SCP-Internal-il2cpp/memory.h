#pragma once
#include <vector>
#include "pointer.h"

struct Entity {
	pointer address;
	vec3 position;
	char name[50];
	pointer ccm;
	int team;
};

// setup some global to work in different threads
vec3 cameraPosition;
Matrix matrix;
pointer camera;
std::vector<Entity> entityList;
std::vector<Entity> locationList;
std::vector<Entity> itemList;
char TeamName[18][50] = { "SCP-173", "Class-D Personnel", "Spectator", "SCP-106", "Nine-Tailed Fox Scientist", "SCP-049", "Scientist", "SCP-079", "Chaos Insurgency", "SCP-096", "SCP-049-2", "Nine-Tailed Fox Lieutenant", "Nine-Tailed Fox Commander", "Nine-Tailed Fox Cadet", "TUTORIAL", "Facility Guard", "SCP-939-53", "SCP-939-89", };
char TeamColor[18][50] = { "red", "orange", "white", "red", "blue", "red", "yellow", "red", "green", "red", "red", "blue", "blue", "blue", "lime", "#757575", "red", "red", };
char Items[40][50] = { "", "Janitor Keycard", "Scientist Keycard", "M. Scientist Keycard", "Zone Manager Keycard", "Guard Keycard", "Cadet Keycard", "Containment Engineer Keycard", "Lieutenant Keycard", "Commander Keycard", "Facility Manager Keycard", "CHI Hacking Device", "O5 Keycard", "", "COM-15", "Medkit", "", "Micro H.I.D.", "SCP-500", "SCP-207", "", "E11SR", "P90", "", "MP7", "Logicer", "Grenade", "Flashbang", "", "", "", "USP", "SCP-018", "SCP-268","Adrenaline","Painkillers","" };
