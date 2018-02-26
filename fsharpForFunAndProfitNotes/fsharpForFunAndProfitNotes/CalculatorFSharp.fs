namespace fsharpForFunAndProfitNotes

type CalculatorFSharp() = 
    member this.DoProductsOverallOnOneTo input =
        let startValue = 1
        let predicate currentValue newValue =
            currentValue * newValue
        [1..input] |> List.fold predicate startValue

    member this.DoSumsOfOddsOnOneTo input =
        let startValue = 0
        let predicate currentValue newValue =
            if newValue%2 = 0 then currentValue else currentValue+newValue
        [1..input] |> List.fold predicate startValue

    member this.DoAlternatingSumOnOneTo input =
        let startValue = (true, 0)
        let predicate (oddStep, currentValue) newValue =
            if oddStep = false then (true, currentValue + newValue)
                              else (false, currentValue - newValue)
        [1..input] |> List.fold predicate startValue