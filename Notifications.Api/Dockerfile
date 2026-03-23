FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Notifications.Api/Notifications.Api.csproj", "Notifications.Api/"]
COPY ["Notifications.Application/Notifications.Application.csproj", "Notifications.Application/"]
COPY ["Notifications.Infrastructure/Notifications.Infrastructure.csproj", "Notifications.Infrastructure/"]
RUN dotnet restore "Notifications.Api/Notifications.Api.csproj"
COPY . .
WORKDIR /src/Notifications.Api
RUN dotnet publish "Notifications.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Notifications.Api.dll"]
