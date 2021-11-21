FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FXbox.Cloud.Presentation.Agents/FXbox.Cloud.Presentation.Agents.csproj", "FXbox.Cloud.Presentation.Agents/"]
RUN dotnet restore "FXbox.Cloud.Presentation.Agents/FXbox.Cloud.Presentation.Agents.csproj"
COPY . .
WORKDIR "/src/FXbox.Cloud.Presentation.Agents"
RUN dotnet build "FXbox.Cloud.Presentation.Agents.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FXbox.Cloud.Presentation.Agents.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FXbox.Cloud.Presentation.Agents.dll"]
