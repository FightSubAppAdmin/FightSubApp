FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["admin.fightsubapp.web/admin.fightsubapp.web.csproj", "admin.fightsubapp.web/"]
RUN dotnet restore "admin.fightsubapp.web/admin.fightsubapp.web.csproj"
COPY . .
WORKDIR "/src/admin.fightsubapp.web"
RUN dotnet build "admin.fightsubapp.web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "admin.fightsubapp.web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "admin.fightsubapp.web.dll"]
