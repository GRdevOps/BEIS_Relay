FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["BEIS_message_relay/BEIS_message_relay.csproj", "BEIS_message_relay/"]
RUN dotnet restore "BEIS_message_relay/BEIS_message_relay.csproj"
COPY . .
WORKDIR "/src/BEIS_message_relay"
RUN dotnet build "BEIS_message_relay.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BEIS_message_relay.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BEIS_message_relay.dll"]