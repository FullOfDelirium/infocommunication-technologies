FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

ARG URL
ENV URL=${URL}

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