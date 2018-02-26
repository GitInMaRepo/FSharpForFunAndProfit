let doProductsOverallOnOneTo input =
    let startValue = 1
    let predicate currentValue newValue =
        currentValue * newValue
    [1..input] |> List.fold predicate startValue

doProductsOverallOnOneTo 5

let buildSumOfOddNumberedFromOneTo input =
    let startValue = 0
    let predicate currentValue newValue =
        if newValue%2 = 0 then currentValue else currentValue+newValue
    [1..input] |> List.fold predicate startValue

buildSumOfOddNumberedFromOneTo 5

let BuildAlternatingSumFromOneTo input =
    let startValue = (true, 0)
    let predicate (oddStep, currentValue) newValue =
        if oddStep = true then (false, currentValue + newValue)
                          else (true, currentValue - newValue)
    [1..input] |> List.fold predicate startValue

BuildAlternatingSumFromOneTo 5
