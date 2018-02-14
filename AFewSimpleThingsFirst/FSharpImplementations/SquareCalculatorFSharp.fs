namespace FSharpImplementations

type SquareCalculatorFSharp() = 
    member this.Square input = input * input
    //member this.SquaresFromOneTo upper = 
    //    [1..upper] |> List.map (this.Square) |> List.sum
    member this.SquaresFromOneTo upper =
        List.sum ( List.map ( this.Square ) [1..upper] )
