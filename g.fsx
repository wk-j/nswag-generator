#r "nuget: NSwag.CodeGeneration.TypeScript"
// #r "nuget: NSwag.CodeGeneration.CSharp"
// #r "nuget: NSwag.Core.Yaml"

open System.Net.Http
open NSwag.CodeGeneration.TypeScript

let core =
    "https://raw.githubusercontent.com/Alfresco/rest-api-explorer/master/src/main/webapp/definitions/alfresco-core.yaml"

let client = new HttpClient()

// let document =
//     OpenApiYamlDocument.FromUrlAsync(core)
//     |> Async.AwaitTask
//     |> Async.RunSynchronously
