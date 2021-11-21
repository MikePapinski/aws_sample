FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Cloud.AgentActivity/Cloud.AgentActivity.csproj", "Cloud.AgentActivity/"]
RUN dotnet restore "Cloud.AgentActivity/Cloud.AgentActivity.csproj"
COPY . .
WORKDIR "/src/Cloud.AgentActivity"
RUN dotnet build "Cloud.AgentActivity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cloud.AgentActivity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cloud.AgentActivity.dll"]
