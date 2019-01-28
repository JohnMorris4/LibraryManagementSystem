FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY LibraryManagementSystem/LibraryManagementSystem.csproj LibraryManagementSystem/
COPY LibraryData/LibraryData.csproj LibraryData/
RUN dotnet restore LibraryManagementSystem/LibraryManagementSystem.csproj
COPY . .
WORKDIR /src/LibraryManagementSystem
RUN dotnet build LibraryManagementSystem.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish LibraryManagementSystem.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LibraryManagementSystem.dll"]
