#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM repo.marcopacs.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM repo.marcopacs.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "Medix.UI/Medix.UI.csproj"

WORKDIR "/src/Medix.UI"
RUN dotnet build "Medix.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Medix.UI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Medix.UI.dll"]