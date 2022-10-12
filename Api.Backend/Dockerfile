#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Api.Backend/Api.Backend.csproj", "Api.Backend/"]
RUN dotnet restore "Api.Backend/Api.Backend.csproj"
COPY . .
WORKDIR "/src/Api.Backend"
RUN dotnet build "Api.Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Backend.dll"]