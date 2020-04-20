FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app
COPY API/*.csproj ./

RUN dotnet restore remote_devices.csproj

COPY API/. ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "remote_devices.dll"]