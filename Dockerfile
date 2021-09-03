FROM mcr.microsoft.com/dotnet/sdk:5.0-focal as build-env

WORKDIR /app
COPY . .

RUN dotnet publish -c Release -o ./dist --no-cache

# Setup
FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal

EXPOSE 10000

WORKDIR /app

COPY --from=build-env /app/dist .

ENTRYPOINT ["dotnet", "kubetest.dll"]