module BasicImpl

open System

let hasThree(candidate:int) =
    let mutable value = candidate
    let mutable found = false
    while (value > 0 && not found) do 
     found <- value % 10 = 3;
     value <- value / 10
    found
    

let isThree( candidate:int )=

    match candidate with
    | candidate when candidate % 3 = 0 -> true
    | candidate when candidate |> hasThree -> true
    | _ -> false

let GetNextNon3( start:int ) = 

    let mutable current = start + 1
    while isThree current  do 
       current <- current + 1
    current

//[<EntryPoint>]
let main argv =
    Console.ReadLine() |> int |> GetNextNon3 |> printfn "%d"
    0 // return an integer exit code
