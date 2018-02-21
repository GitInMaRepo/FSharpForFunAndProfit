namespace fsharpForFunAndProfitNotes

type QuickSortFSharp() = 
    member this.DoQuickSortOn input = 
        match input with 
            | [] -> []
            | first::rest ->
                let smallerValues = rest |> List.filter(fun x -> x < first) |> this.DoQuickSortOn
                let largerValues = rest |> List.filter(fun x -> x >= first) |> this.DoQuickSortOn
                List.concat [smallerValues;[first];largerValues] 
