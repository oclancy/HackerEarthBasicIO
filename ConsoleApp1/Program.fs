
open System

let isprime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

let upperCase = seq { for n in 65 .. 90 do if isprime n then yield n }
let lowerCase = seq { for n in 97 .. 122 do if isprime n then yield n } 

let primes = Seq.concat [ upperCase ; lowerCase]
             |> Array.ofSeq
             |> Array.sort


let translate ( letter:char ) = 
    let letterAsInt = letter |> int;
    let mutable top = 0;
    let mutable bttom = 0;
    for i in primes do
        if i > letterAsInt && top = 0 then
            top <- i;
        else if i < letterAsInt then 
            bttom <- i;

    if top - letterAsInt < letterAsInt - bttom then top else bttom
        |> char

let testWord( length:int, word:string ) =          

    let translated = String.Join( "", Seq.ofArray( word.ToCharArray() )
                                         |> Seq.map translate );

    printfn "%s" translated;

[<EntryPoint>]
let main argv =
    
    let testCases = Int32.Parse(Console.ReadLine() )
    seq{ 0 .. testCases-1 }
    |> Seq.iter (fun x -> testWord( Int32.Parse( Console.ReadLine() ), Console.ReadLine() ))
    |> ignore

    0 // return an integer exit code


