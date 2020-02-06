FROM mcr.microsoft.com/dotnet/core/sdk AS base
WORKDIR /app
EXPOSE 80

RUN dotnet tool install -g dotnet-ef --version 3.1.1
FROM mcr.microsoft.com/dotnet/core/sdk AS build
WORKDIR /ab
COPY ["/ab.csproj", "/ab"]
RUN dotnet restore "ab.csproj"
COPY . .
RUN dotnet build "ab.csproj" -c Release -o "./build"

FROM build AS publish
RUN dotnet publish "ab.csproj" -c Release -o "./publish"
FROM base AS final
WORKDIR /ab/publish
ENTRYPOINT ["dotnet", "ab.dll"]