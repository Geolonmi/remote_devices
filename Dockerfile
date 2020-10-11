FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app
COPY ENDPOINT/remote_device_api/. ./remote_device_api/
COPY ENDPOINT/remote_device_dal/. ./remote_device_dal/
COPY ENDPOINT/remote_device_services/. ./remote_device_services/
COPY ENDPOINT/remote_device_data/. ./remote_device_data/

RUN dotnet restore remote_device_api/remote_device.csproj
RUN dotnet restore remote_device_dal/remote_device_dal.csproj
RUN dotnet restore remote_device_services/remote_device_services.csproj
RUN dotnet restore remote_device_data/remote_device_data.csproj

RUN dotnet publish remote_device_api/remote_device.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "remote_device.dll"]