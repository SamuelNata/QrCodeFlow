# Criando projetos
dotnet new webapi -n "Qrcode.Flow.API"
dotnet new classlib -n "Qrcode.Flow.Model"
dotnet new classlib -n "Qrcode.Flow.Repository"
dotnet new classlib -n "Qrcode.Flow.Service"

# Criando arquivo da solução
dotnet new sln -n Qrcode.Flow.API

# Adicionando projetos a solução
dotnet sln add "Qrcode.Flow.API" "Qrcode.Flow.Model" "Qrcode.Flow.Repository" "Qrcode.Flow.Service"

# Adicionando referencias
dotnet add Qrcode.Flow.API reference Qrcode.Flow.Model
dotnet add Qrcode.Flow.API reference Qrcode.Flow.Repository
dotnet add Qrcode.Flow.API reference Qrcode.Flow.Service
dotnet add Qrcode.Flow.API package MongoDb.Driver

dotnet add Qrcode.Flow.Service reference Qrcode.Flow.Repository
dotnet add Qrcode.Flow.Service reference Qrcode.Flow.Model

dotnet add Qrcode.Flow.Repository reference Qrcode.Flow.Model
dotnet add Qrcode.Flow.Repository package MongoDb.Driver
