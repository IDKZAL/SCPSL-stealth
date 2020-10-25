@echo off

cls

echo Dumping Offsets
echo This only works if SCP:SL is installed on C:/default steam library location.
timeout 3

SET _StartPath=%cd%
SET _Il2CppDumper=%cd%\Il2CppDumper-v6.4.12\
SET _SteamGamePath=D:\Games\Steam\steamapps\common\SCP Secret Laboratory
SET _GameAssembly=%_SteamGamePath%
SET _GlobalmMetadata=%_SteamGamePath%\SCPSL_Data\il2cpp_data\Metadata
SET _OffsetDumpOutput=%_StartPath%\OffsetDumpOutput\

cls

cd %_Il2CppDumper%
Il2CppDumper.exe "%_GameAssembly%\GameAssembly.dll" "%_GlobalmMetadata%\global-metadata.dat" "%_OffsetDumpOutput%\"

cls

echo #######################
echo     Done Dumping...
echo #######################
timeout 3

exit