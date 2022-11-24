FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 7149

ARG URL
ENV URL=${URL}

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY ["SecondApplication.csproj", "./"]
RUN dotnet restore "./SecondApplication.csproj"
COPY . .
WORKDIR "/app/."
RUN dotnet build "SecondApplication.csproj" -c Release -o /app/build

FROM base AS final
WORKDIR /app
COPY --from=build /app/build .

ENTRYPOINT ["dotnet", "SecondApplication.dll"]