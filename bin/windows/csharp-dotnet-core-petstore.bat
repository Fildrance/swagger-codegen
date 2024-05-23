set executable=.\modules\swagger-codegen-cli\target\swagger-codegen-cli.jar

If Not Exist %executable% (
  mvn clean package
)

REM set JAVA_OPTS=%JAVA_OPTS% -Xmx1024M
set ags=generate -i modules/swagger-codegen/src/test/resources/2_0/petstore.yaml -l csharp-dotnet-core -o samples/client/petstore/csharp-dotnet-core --additional-properties hideGenerationTimestamp=true --template-engine mustache

java %JAVA_OPTS% -jar %executable% %ags%
