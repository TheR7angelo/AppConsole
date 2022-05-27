FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AppConsole/AppConsole.csproj", "AppConsole/"]
RUN dotnet restore "AppConsole/AppConsole.csproj"
COPY . .
WORKDIR "/src/AppConsole"
RUN dotnet build "AppConsole.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppConsole.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppConsole.dll"]
