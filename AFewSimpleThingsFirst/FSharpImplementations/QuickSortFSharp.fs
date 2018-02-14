namespace FSharpImplementations

type QuickSortFSharp() = 
    member this.DoQuickSortOn list = 
        match list with 
        | [] -> []
        | firstElement::otherElements ->
            let smallerElements = 
                otherElements |> List.filter (fun x -> x < firstElement ) |> this.DoQuickSortOn
            let biggerElements =
                otherElements |> List.filter (fun x -> x >= firstElement ) |> this.DoQuickSortOn
            List.concat [smallerElements; [firstElement]; biggerElements]

    member this.DoQuickSortOnAlternative list = 
        match list with 
        | [] -> []
        | firstElement::otherElements ->
            let smallerElements = 
                this.DoQuickSortOn (List.filter (fun x -> x < firstElement) otherElements)
            let sortLargerPredicate x = x >= firstElement
            let biggerElements =
                this.DoQuickSortOn (List.filter (sortLargerPredicate) otherElements)
            List.concat [smallerElements; [firstElement]; biggerElements]
