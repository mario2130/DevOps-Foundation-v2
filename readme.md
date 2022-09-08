# Pasos de configuraci�n

- realizar compilaci�n de la soluci�n desde la la ubicaci�n de la soluci�n
`
dotnet build
`

- correr la pruebas y generar archivo xml de coverage
- la ruta ser� genera en la carpeta donde se encuentra el test
`
dotnet test .\microservicio.dotnet.test\microservicio.dotnet.test.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput='coverage.xml' --configuration Release --no-restore
`
 
- generar container 

`
docker build -t microservicio.dotnet -f microservicio.dotnet/Dockerfile .
`