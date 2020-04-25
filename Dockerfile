FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app
COPY ENDPOINT/remote_device_api/*.csproj ./remote_device_api/
COPY ENDPOINT/remote_device_dal/*.csproj ./remote_device_dal/

RUN dotnet restore remote_device_api/remote_device.csproj
RUN dotnet restore remote_device_dal/remote_device_dal.csproj

COPY ENDPOINT/remote_device_api/. ./remote_device_api/
COPY ENDPOINT/remote_device_dal/. ./remote_device_dal/

RUN dotnet publish remote_device_api/remote_device.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "remote_device.dll"]