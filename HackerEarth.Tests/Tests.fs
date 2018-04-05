namespace HackerEarth.Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open Cipher

[<TestClass>]
type CipherTests () =

    [<TestMethod>]
    member this.TestCipher_9 () =

        let translation = cipher( "Y", 3)

        Assert.AreEqual("B", translation);

    [<TestMethod>]
    member this.TestCipher_Y () =

        let translation = cipher( "Y", 4)

        Assert.AreEqual("C", translation);

    [<TestMethod>]
    member this.TestCipher () =

        let translation = cipher( "All-convoYs-9-be:Alert1.", 4)

        Assert.AreEqual("Epp-gsrzsCw-3-fi:Epivx5.",translation);

    [<TestMethod>]
    member this.TestCipher2 () =

        let translation = cipher( "abcdZXYzxy-999.@", 200)

        Assert.AreEqual("stuvRPQrpq-999.@", translation);
