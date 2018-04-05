// Learn more about F# at http://fsharp.org

module Cipher

open System

let upperCase = Array.ofSeq( seq { 65 .. 90 } )
let lowerCase = Array.ofSeq( seq { 97 .. 122 } )
let numbers = Array.ofSeq( seq { 48 .. 57 } )

let translate ( numbers: int[], letterAsNum:int, cipher:int ) =

    let effectiveCipher = cipher % numbers.Length
    let max = numbers.[numbers.Length-1]
    let mutable translated = letterAsNum + effectiveCipher
    if translated > max then translated <- numbers.[ translated % max - 1 ]
    
    translated

let translateLetter ( letter:char, cipher:int ) = 
    let letterAsNum = letter |> int

    match letterAsNum with 
        | letterAsNum when upperCase |> Array.contains(letterAsNum) -> translate( upperCase, letterAsNum, cipher )
        | letterAsNum when lowerCase |> Array.contains(letterAsNum) ->  translate( lowerCase, letterAsNum, cipher )
        | letterAsNum when numbers |> Array.contains(letterAsNum) ->  translate( numbers, letterAsNum, cipher )
        | _ -> letterAsNum

    |> char

let cipher (word:string, cipher:int) =

    let letters = Seq.ofArray( word.ToCharArray() )
                    |> Seq.map( fun l ->  translateLetter(l, cipher ) )

    let translated = String.Join( "", letters )

    printfn "%s" translated;

    translated

//[<EntryPoint>]
//let main argv =
    
//    let word = Console.ReadLine()
//    let shift = Int32.Parse(Console.ReadLine() )
    
//    cipher( word, shift )

//    0;

