# Pasos de configuraci�n

- realizar compilaci�n de la soluci�n desde la la ubicaci�n de la soluci�n
`
dotnet build
`

- correr la pruebas y generar archivo xml de coverage
`
dotnet test .\microservicio.dotnet.test\microservicio.dotnet.test.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput='coverage.xml' --configuration Release --no-restore
`
 
