FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Cloud.ConfigStore/Cloud.ConfigStore.csproj", "Cloud.ConfigStore/"]
RUN dotnet restore "Cloud.ConfigStore/Cloud.ConfigStore.csproj"
COPY . .
WORKDIR "/src/Cloud.ConfigStore"
RUN dotnet build "Cloud.ConfigStore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cloud.ConfigStore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cloud.ConfigStore.dll"]
