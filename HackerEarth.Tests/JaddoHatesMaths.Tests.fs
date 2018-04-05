namespace HackerEarth.Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open BasicImpl

[<TestClass>]
type JadoHatesMaths () =

    [<TestMethod>]
    member this.HasThree_123() =

        Assert.IsTrue( hasThree 123 )

    [<TestMethod>]
    member this.HasNotThree_121() =

        Assert.IsFalse( hasThree 112 )

    [<TestMethod>]
    member this.IsThree() =

        Assert.IsTrue( isThree 3 )

    [<TestMethod>]
    member this.IsNotThree() =

        Assert.IsFalse( isThree 4 )

    [<TestMethod>]
    member this.GetNext_is_5() =

        Assert.AreEqual( 5, GetNextNon3 4 )   
   
    [<TestMethod>]
    member this.GetNext_is_7() =

        Assert.AreEqual( 7, GetNextNon3 5 )  