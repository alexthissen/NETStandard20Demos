@echo off
cd SteamCLICore
dotnet publish -o ..\publish
cd ..
docker build -t alexthissen/steamcli .
