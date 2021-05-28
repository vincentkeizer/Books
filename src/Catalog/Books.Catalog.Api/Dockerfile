#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Catalog/Books.Catalog.Api/Books.Catalog.Api.csproj", "Catalog/Books.Catalog.Api/"]
RUN dotnet restore "Catalog/Books.Catalog.Api/Books.Catalog.Api.csproj"
COPY . .
WORKDIR "/src/Catalog/Books.Catalog.Api"
RUN dotnet build "Books.Catalog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Books.Catalog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Books.Catalog.Api.dll"]