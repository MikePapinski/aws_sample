FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FXbox.Cloud.Gateway.Dashboard/FXbox.Cloud.Gateway.Dashboard.csproj", "FXbox.Cloud.Gateway.Dashboard/"]
RUN dotnet restore "FXbox.Cloud.Gateway.Dashboard/FXbox.Cloud.Gateway.Dashboard.csproj"
COPY . .
WORKDIR "/src/FXbox.Cloud.Gateway.Dashboard"
RUN dotnet build "FXbox.Cloud.Gateway.Dashboard.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FXbox.Cloud.Gateway.Dashboard.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FXbox.Cloud.Gateway.Dashboard.dll"]
