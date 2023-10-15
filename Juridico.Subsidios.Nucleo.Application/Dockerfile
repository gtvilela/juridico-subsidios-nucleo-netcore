#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Juridico.Subsidios.Nucleo.Application/Juridico.Subsidios.Nucleo.Application.csproj", "Juridico.Subsidios.Nucleo.Application/"]
COPY ["Juridico.Subsidios.Nucleo.Domain/Juridico.Subsidios.Nucleo.Domain.csproj", "Juridico.Subsidios.Nucleo.Domain/"]
RUN dotnet restore "Juridico.Subsidios.Nucleo.Application/Juridico.Subsidios.Nucleo.Application.csproj"
COPY . .
WORKDIR "/src/Juridico.Subsidios.Nucleo.Application"
RUN dotnet build "Juridico.Subsidios.Nucleo.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Juridico.Subsidios.Nucleo.Application.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Juridico.Subsidios.Nucleo.Application.dll"]