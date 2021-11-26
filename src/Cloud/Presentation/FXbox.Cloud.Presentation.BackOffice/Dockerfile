FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build

COPY "/src"  "/src"
WORKDIR "/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent"
RUN dotnet restore "FXbox.Cloud.Presentation.Agent.csproj"
RUN dotnet build "FXbox.Cloud.Presentation.Agent.csproj" -c Release -o /build

FROM build AS publish
RUN dotnet publish "FXbox.Cloud.Presentation.Agent.csproj" -c Release -o /publish

# We then get the base image for Nginx and set the 
# work directory 
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html

# We'll copy all the contents from wwwroot in the publish
# folder into nginx/html for nginx to serve. The destination
# should be the same as what you set in the nginx.conf.
COPY --from=publish /publish/wwwroot /usr/local/webapp/nginx/html
COPY "/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/nginx.conf" "/etc/nginx/nginx.conf"
