FROM microsoft/aspnetcore:1.1
WORKDIR /app
COPY publish .
ENTRYPOINT ["dotnet", "SteamCLICore.dll"]