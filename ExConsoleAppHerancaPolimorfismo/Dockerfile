FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CursoUdemyCsharp/CursoUdemyCsharp.csproj", "CursoUdemyCsharp/"]
RUN dotnet restore "CursoUdemyCsharp/CursoUdemyCsharp.csproj"
COPY . .
WORKDIR "/src/CursoUdemyCsharp"
RUN dotnet build "CursoUdemyCsharp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CursoUdemyCsharp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CursoUdemyCsharp.dll"]
