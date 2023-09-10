#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Juridico.Nucleo.Subsidios/Juridico.Nucleo.Subsidios.csproj", "Juridico.Nucleo.Subsidios/"]
RUN dotnet restore "Juridico.Nucleo.Subsidios/Juridico.Nucleo.Subsidios.csproj"
COPY . .
WORKDIR "/src/Juridico.Nucleo.Subsidios"
RUN dotnet build "Juridico.Nucleo.Subsidios.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Juridico.Nucleo.Subsidios.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Juridico.Nucleo.Subsidios.dll"]