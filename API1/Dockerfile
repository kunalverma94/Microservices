#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim 
WORKDIR /src
COPY . .
WORKDIR "/src/API1"
RUN dotnet build "API1.csproj" -c Release -o /app/build
WORKDIR /app/buid
EXPOSE 80
EXPOSE 5000
EXPOSE 443
RUN dotnet publish "API1.csproj" -c Release -o /app/publish
WORKDIR  /app/publish

ENTRYPOINT ["dotnet", "API1.dll"]

#FROM build AS publish
#RUN dotnet publish "API1.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
