FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FXbox.Cloud.Services.Identity/FXbox.Cloud.Services.Identity.csproj", "FXbox.Cloud.Services.Identity/"]
RUN dotnet restore "FXbox.Cloud.Services.Identity/FXbox.Cloud.Services.Identity.csproj"
COPY . .
WORKDIR "/src/FXbox.Cloud.Services.Identity"
RUN dotnet build "FXbox.Cloud.Services.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FXbox.Cloud.Services.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FXbox.Cloud.Services.Identity.dll"]
