module RubiksCube

open System
open System.Diagnostics

type Operation = Row | Column 

type Cube(n:int) =
    let mutable _cube = Array2D.zeroCreate<int> n n;
    let _width = n;
    
    let getTarget op rowCol = 
        match op with
            | Operation.Column -> _cube.[ * , rowCol] 
            | Operation.Row -> _cube.[rowCol, *] 

    member this.Item
        with get(x,y) = _cube.[x,y]
        and  set(x,y) value = _cube.[x,y] <- value

    member this.rotate( count:int, rowCol:int, op:Operation) =

        let zeroBasedRowCol = rowCol - 1;
        let target = getTarget op ( zeroBasedRowCol )
        let effectiveMove = count % _width 

        let temp = Array.zeroCreate<int> _width;
        for a in 0.._width - 1 do temp.[(a + effectiveMove ) % _width] <- target.[a]

        match op with
         | Operation.Column -> for index in 0 .. _width - 1 do _cube.[index, zeroBasedRowCol] <- temp.[index]
         | Operation.Row -> for index in _width - 1 .. 0 do _cube.[zeroBasedRowCol, index] <- temp.[index]

    member this.load( row:int, values:int[]) =
        for index in  0 .. _width - 1 do  _cube.[row, index] <- values.[index]

    member this.GetRowAsString( index:int) = 
        String.Join( " ",  _cube.[index,*]
                            |> Array.map( fun a -> a.ToString() ) )
        
        

let getSplitInput =
    Console.ReadLine()
            .Split( [| ' ' |] )
        |>Array.map int


let print( n:int, cube: Cube ) =
    for index in 0..n - 1 do cube.GetRowAsString index |> Debug.WriteLine 
    for index in 0..n - 1 do cube.GetRowAsString index |> printfn "%s" 
