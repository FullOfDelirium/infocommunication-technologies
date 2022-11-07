FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8080

ENV ASPNETCORE_URLS=http//+:8080

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

CMD ["dotnet", "HumanInfoApplication.dll"]