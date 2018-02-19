// Weitere Informationen zu F# finden Sie unter http://fsharp.org. Im Projekt "F#-Tutorial" finden Sie
// einen Leitfaden zum Programmieren in F#.

#load "SquareCalculatorFSharp.fs"
open FSharpImplementations


// Skriptcode für die Bibliothek hier definieren
let parseFirst condition = 
    match condition with 
    | true -> "Hello "
    | false -> "Goodbye "

let parseSecond condition = 
    match condition with
    | true -> "Country"
    | false -> "World"

let parseThird condition =
    match condition with 
    |true -> "!"
    |false -> "?"

parseFirst true + parseSecond true + parseThird true