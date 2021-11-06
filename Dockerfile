FROM mcr.microsoft.com/dotnet/sdk:5.0.402 AS build
WORKDIR /Bubelinez

COPY ["Bubelinez/Bubelinez.csproj", "."]

RUN dotnet restore "Bubelinez.csproj"
COPY ["Bubelinez", "."]
RUN dotnet build "Bubelinez.csproj"

WORKDIR "/Bubelinez.Tests"
COPY ["Bubelinez.Tests", "."]
RUN ls
RUN dotnet test "Bubelinez.Tests.csproj"
