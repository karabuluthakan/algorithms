FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/FindCenterOfStarGraph/FindCenterOfStarGraph.csproj", "src/FindCenterOfStarGraph/"]
RUN dotnet restore "src/FindCenterOfStarGraph/FindCenterOfStarGraph.csproj"
COPY . .
WORKDIR "/src/src/FindCenterOfStarGraph"
RUN dotnet build "FindCenterOfStarGraph.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FindCenterOfStarGraph.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FindCenterOfStarGraph.dll"]
