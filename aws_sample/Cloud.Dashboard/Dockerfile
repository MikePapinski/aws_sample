FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Cloud.Dashboard/Cloud.Dashboard.csproj", "Cloud.Dashboard/"]
RUN dotnet restore "Cloud.Dashboard/Cloud.Dashboard.csproj"
COPY . .
WORKDIR "/src/Cloud.Dashboard"
RUN dotnet build "Cloud.Dashboard.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cloud.Dashboard.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cloud.Dashboard.dll"]
