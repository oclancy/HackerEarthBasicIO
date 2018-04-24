namespace HackerEarth.Tests 

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open RubiksCube


[<TestClass>]
type RubiksCube () =

    [<TestMethod>]
    member this.Rotate_Row_1() =

        let cube = new Cube(3);
        cube.load( 0, [|1;2;3|])
        cube.load( 1, [|4;5;6|])
        cube.load( 2, [|7;8;9|])

        cube.rotate(1,2,Operation.Row)

        Assert.AreEqual( cube.[0,0], 1 ) 
        Assert.AreEqual( cube.[0,1], 2 ) 
        Assert.AreEqual( cube.[0,2], 3 ) 
        Assert.AreEqual( cube.[1,0], 6 ) 
        Assert.AreEqual( cube.[1,1], 4 ) 
        Assert.AreEqual( cube.[1,2], 5 ) 
        Assert.AreEqual( cube.[2,0], 7 ) 
        Assert.AreEqual( cube.[2,1], 8 ) 
        Assert.AreEqual( cube.[2,2], 9 ) 

    [<TestMethod>]
    member this.Rotate_Row_2() =

        let cube = new Cube(5);
        //5 3 4
        cube.load( 0, [|8;6;3;9;1|]) 
        cube.load( 1, [|7;4;6;4;6|]) 
        cube.load( 2, [|3;4;2;0;4|]) 
        cube.load( 3, [|0;5;3;3;9|]) 
        cube.load( 4, [|8;5;4;9;3|]) 
        //5 2 1 
        cube.rotate(3,5,Operation.Row)
        cube.rotate(3,2,Operation.Row)
        cube.rotate(3,1,Operation.Row)
        //4 5 5 4
        cube.rotate(4,4,Operation.Column)
        cube.rotate(4,5,Operation.Column)
        cube.rotate(4,5,Operation.Column)
        cube.rotate(4,4,Operation.Column)

        print( 5, cube )
//1 8 6 3 9 
//6 7 4 4 9 
//3 4 2 3 9 
//0 5 3 6 4 
//3 8 5 0 4

    [<TestMethod>]
    member this.TestArrayPrint()=
        let res = String.Join( ' ',  [| 1;2;3 |]
                            |> Array.map( fun a -> a.ToString() ) )

        Assert.AreEqual("1 2 3", res);

    [<TestMethod>]
    member this.Rotate_Row_3() =

        let cube = new Cube(4);
        //5 3 4
        cube.load( 0, [|1;2;3;4|]) 
        cube.load( 1, [|5;6;7;8|]) 
        cube.load( 2, [|9;1;1;3|]) 
        cube.load( 3, [|4;5;7;8|]) 
        //5 2 1 
        cube.rotate(2,2,Operation.Row)
        print( 4, cube ) |> ignore
        cube.rotate(2,2,Operation.Row)
        print( 4, cube ) |> ignore
        //4 5 5 4
        cube.rotate(2,1,Operation.Column)
        print( 4, cube ) |> ignore
        cube.rotate(2,3,Operation.Column)
        print( 4, cube ) |> ignore