FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FXbox.Cloud.Services.Configuration/FXbox.Cloud.Services.Configuration.csproj", "FXbox.Cloud.Services.Configuration/"]
RUN dotnet restore "FXbox.Cloud.Services.Configuration/FXbox.Cloud.Services.Configuration.csproj"
COPY . .
WORKDIR "/src/FXbox.Cloud.Services.Configuration"
RUN dotnet build "FXbox.Cloud.Services.Configuration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FXbox.Cloud.Services.Configuration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FXbox.Cloud.Services.Configuration.dll"]
