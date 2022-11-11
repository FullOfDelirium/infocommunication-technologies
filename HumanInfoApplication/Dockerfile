FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 7215

ENV ASPNETCORE_URLS=http//+:7215

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY ["HumanInfoApplication.csproj", "./"]
RUN dotnet restore "./HumanInfoApplication.csproj"
COPY . .
WORKDIR "/app/."
RUN dotnet build "HumanInfoApplication.csproj" -c Release -o /app/build

FROM base AS final
WORKDIR /app
COPY --from=build /app/build .

ENTRYPOINT ["dotnet", "HumanInfoApplication.dll"]