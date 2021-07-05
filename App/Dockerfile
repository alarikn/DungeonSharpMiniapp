#Version 5.0 of dotnet
FROM mcr.microsoft.com/dotnet/aspnet:5.0

#Copy the app to work folder
COPY bin/release/net5.0/publish/ /App
WORKDIR /App

#Microsoft recommends disabling diagnostics for added security
ENV DOTNET_EnableDiagnostics=0

#Entry point to the dll
ENTRYPOINT ["dotnet", "Netcore.Docker.dll"]

