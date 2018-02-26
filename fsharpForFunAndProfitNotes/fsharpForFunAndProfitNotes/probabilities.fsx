let randomizer = 
    new System.Random();
    
let rolld input =
    randomizer.Next(1, input)

let getPercentage input =
    match input with
        | (a, b) ->
            

[1..10] 
    |> List.map(fun _ -> rolld 7) 
    |> List.countBy (fun f -> f >= 4)
    |> 

