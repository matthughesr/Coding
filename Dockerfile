# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

# Set the working directory in the container
WORKDIR /app


COPY . ./
RUN dotnet restore


# Build the app
RUN dotnet publish -o out
# Use the official .NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:9.0

# Set the working directory in the container
WORKDIR /app

# Copy the build artifacts from the build container
COPY --from=build /app/out ./

# Set the entry point for the app
ENTRYPOINT ["dotnet", "palindrome.dll"]
