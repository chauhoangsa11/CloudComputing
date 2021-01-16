#build phase
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build

WORKDIR /app

  COPY bin/Debug/netcoreapp3.1/ App/



COPY *csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o pub

#Run phase
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app
EXPOSE 50528
COPY --from=build /app/pub .

ENTRYPOINT [ "dotnet","MVCCloud.dll" ]