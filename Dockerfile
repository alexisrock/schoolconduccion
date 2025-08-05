FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /App
EXPOSE 8097

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS  build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src 
COPY . ./
RUN dotnet restore
RUN dotnet build "Api/Api.csproj" -c $BUILD_CONFIGURATION -o /App/build


FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Api/Api.csproj"  -c $BUILD_CONFIGURATION -o /App/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /App
COPY --from=publish /App/publish . 
ENTRYPOINT ["dotnet", "Api.dll"]