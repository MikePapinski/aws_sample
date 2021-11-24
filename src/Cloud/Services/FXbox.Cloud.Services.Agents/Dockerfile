FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base

WORKDIR /app
LABEL VERSION="1.0"
LABEL NAME="API Gateway"
LABEL AUTOR="Leonardo Guilen <leonardoguilen1@gmail.com>"
EXPOSE 5021

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
COPY "/src"  "/src"
WORKDIR "/src/Cloud/Services/FXbox.Cloud.Services.Agents"
RUN dotnet restore "FXbox.Cloud.Services.Agents.csproj"
RUN dotnet build "FXbox.Cloud.Services.Agents.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FXbox.Cloud.Services.Agents.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FXbox.Cloud.Services.Agents.dll"]
