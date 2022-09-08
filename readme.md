# Pasos de configuración

- realizar compilación de la solución desde la la ubicación de la solución

`
dotnet build
`

- correr la pruebas y generar archivo xml de coverage
	- el archivo será genera en la carpeta donde se encuentra el proyecto de test, el siguiente comando
	genera el archivo en standar opencover que corresponde a un archivo xml el cual puede ser leido por sonar

`
dotnet test .\microservicio.dotnet.test\microservicio.dotnet.test.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput='coverage.xml' --configuration Release --no-restore
`
	- para otros tipos de pipeline tales como Azure DevOps son requeridos en formato .coverage, para 
	conseguirlo ejecute el siguiente comando

	`
	dotnet test .\microservicio.dotnet.test\microservicio.dotnet.test.csproj --collect "Code Coverage"
	`
 
- generar container 

`
docker build -t microservicio.dotnet -f microservicio.dotnet/Dockerfile .
`


- referencias
	- https://docs.microsoft.com/en-us/azure/devops/pipelines/create-first-pipeline?view=azure-devops&tabs=net%2Ctfs-2018-2%2Cbrowser
	- https://docs.microsoft.com/en-us/azure/devops/pipelines/test/review-code-coverage-results?view=azure-devops