#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["tweet22/Server/tweet22.Server.csproj", "tweet22/Server/"]
COPY ["tweet22/Client/tweet22.Client.csproj", "tweet22/Client/"]
COPY ["tweet22/Shared/tweet22.Shared.csproj", "tweet22/Shared/"]
RUN dotnet restore "tweet22/Server/tweet22.Server.csproj"
COPY . .
WORKDIR "/src/tweet22/Server"
RUN dotnet build "tweet22.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "tweet22.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "tweet22.Server.dll"]
