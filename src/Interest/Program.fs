// Learn more about F# at http://fsharp.org

open System

type Params = {
    OutstandingBalance: double
    InterestRate: double
    PaidAmount: double
}

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
