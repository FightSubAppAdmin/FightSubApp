FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DojoConnect.Api/DojoConnect.Api.csproj", "DojoConnect.Api/"]
RUN dotnet restore "DojoConnect.Api/DojoConnect.Api.csproj"
COPY . .
WORKDIR "/src/DojoConnect.Api"
RUN dotnet build "DojoConnect.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DojoConnect.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DojoConnect.Api.dll"]
