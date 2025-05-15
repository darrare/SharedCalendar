# -------- Build stage --------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything and publish the app
COPY . ./
RUN dotnet publish -c Release -o out

# -------- Runtime stage --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy the published output from build stage
COPY --from=build /app/out ./

# Expose port 80 for Render
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "SharedCalendar.dll"]
