# Pasos de configuración

- realizar compilación de la solución desde la la ubicación de la solución
`
dotnet build
`

- correr la pruebas y generar archivo xml de coverage
- la ruta será genera en la carpeta donde se encuentra el test
`
dotnet test .\microservicio.dotnet.test\microservicio.dotnet.test.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput='coverage.xml' --configuration Release --no-restore
`
 
- generar container 

`
docker build -t microservicio.dotnet -f microservicio.dotnet/Dockerfile .
`