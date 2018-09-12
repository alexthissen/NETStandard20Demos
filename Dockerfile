FROM microsoft/aspnetcore:1.1
WORKDIR /app
COPY dotnetcore .
ENTRYPOINT ["dotnet", "SteamCLICore.dll"]