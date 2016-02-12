
module MyList =
    open System
    open NUnit.Framework
    open FsUnit

    let rec myLast list = 
        match list with
        | [] -> raise(new ArgumentException("foo"))
        | hd :: [] -> hd
        | hd :: tl -> myLast tl

    [<Test>]
    let myLastTest() =
        myLast [ 1; 2; 3; ] |> should equal 3


[<EntryPoint>]
let main argv = 
    printfn "Lists"
    printfn "myLast [ 1; 2; 3 ] -> %i" (MyList.myLast [ 1; 2; 3; ])
    System.Console.ReadLine()
    0 // return an integer exit code
