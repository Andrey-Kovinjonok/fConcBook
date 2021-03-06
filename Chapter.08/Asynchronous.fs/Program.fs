﻿module Program

[<EntryPoint>]
let main argv =
    Demo.benchmark "Async impl" (fun () ->
        AsyncModule.runAsync() |> ignore)
    Demo.benchmark "Sync impl" (fun () ->
        AsyncModule.runSync() |> ignore)

    0