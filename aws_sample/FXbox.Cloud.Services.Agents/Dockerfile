FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FXbox.Cloud.Services.Agents/FXbox.Cloud.Services.Agents.csproj", "FXbox.Cloud.Services.Agents/"]
RUN dotnet restore "FXbox.Cloud.Services.Agents/FXbox.Cloud.Services.Agents.csproj"
COPY . .
WORKDIR "/src/FXbox.Cloud.Services.Agents"
RUN dotnet build "FXbox.Cloud.Services.Agents.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FXbox.Cloud.Services.Agents.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FXbox.Cloud.Services.Agents.dll"]
