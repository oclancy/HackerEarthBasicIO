
#r @"E:\Projects\HackerEarth\BasicImpl\bin\Debug\netcoreapp2.0\BasicImpl.dll"

open System
open RubiksCube

let getSplitInput =
    Console.ReadLine()
           .Split( [| ' ' |] )
     |>Array.map int


let print( n:int, cube: Cube ) =

    for index in 0..n do cube.GetRowAsString index |> printfn "%s" 

//[<EntryPoint>]
let main = 
    let nrc = getSplitInput

    let cube = new Cube( nrc.[0] )

    for count in 0.. nrc.[0] do cube.load( count, getSplitInput )

    getSplitInput
        |> Array.map (fun r -> cube.rotate( nrc.[1], r - 1, Operation.Row ) )
        |> ignore

    getSplitInput
        |> Array.map (fun c -> cube.rotate( nrc.[1], c - 1, Operation.Column ) )
        |> ignore

    for count in 0.. nrc.[0] do print( count, cube )
    0
    
