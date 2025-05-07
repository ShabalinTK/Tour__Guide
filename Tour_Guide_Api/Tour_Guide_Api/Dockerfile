# Базовый образ для среды выполнения
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Образ для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Копируем .csproj
COPY ["Tour_Guide_Api/Tour_Guide_Api.csproj", "Tour_Guide_Api/"]
RUN dotnet restore "Tour_Guide_Api/Tour_Guide_Api.csproj"

# Копируем остальной исходный код
COPY . .

WORKDIR "/src/Tour_Guide_Api"
RUN dotnet build "Tour_Guide_Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Публикация
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Tour_Guide_Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Финальный образ
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tour_Guide_Api.dll"]
