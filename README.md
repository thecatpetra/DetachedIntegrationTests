# DetachedIntegrationTests

## Steps to reproduce the situation
In CatPhotoApi publish the app via

`dotnet publish --configuration Release`

Add reference to CatPhotoApi.dll from publish folder of CatPhotoApi

Copy .deps.json for cat photo api to root of compilation (`bin/Debug/net7.0`) of project `CaptPhotoApiDetachedTests`

Run unit test in debug and you will see exception `System.IO.DirectoryNotFoundException: <some path>\DifferentSolutions\AspnetDetachedTests\CatPhotoApi\`
