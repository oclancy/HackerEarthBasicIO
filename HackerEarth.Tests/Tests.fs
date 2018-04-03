namespace HackerEarth.Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open Cipher

[<TestClass>]
type CipherTests () =

    [<TestMethod>]
    member this.TestCipher () =

        let translation = cipher( "All-convoYs-9-be:Alert1.", 4)

        Assert.AreEqual(translation, "Epp-gsrzsCw-3-fi:Epivx5.");

    [<TestMethod>]
    member this.TestCipher2 () =

        let translation = cipher( "abcdZXYzxy-999.@", 200)

        Assert.AreEqual(translation, "stuvRPQrpq-999.@");
