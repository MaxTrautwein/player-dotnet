FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["client-dotnet/client-dotnet.csproj", "client-dotnet/"]
RUN dotnet restore "client-dotnet/client-dotnet.csproj"
COPY . .
WORKDIR "/src/client-dotnet"
RUN dotnet build "client-dotnet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "client-dotnet.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "client-dotnet.dll"]
