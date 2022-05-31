# .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS dotnet

# Copy Project
COPY /Service/Service.csproj /source/Service/

# .NET Restore
RUN dotnet restore /source/Service/Service.csproj

# Copy All Files
COPY ./ /source

# .NET Publish
RUN dotnet publish /source/Service/Service.csproj -c Release -o /dist --no-restore


# .NET Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
WORKDIR /app
COPY --from=dotnet /dist .
ENTRYPOINT ["dotnet", "Service.dll"]
