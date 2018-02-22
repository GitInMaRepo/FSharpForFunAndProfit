// the inevitable
printfn "Hello World"


//types
type Person = {Name:string; Vorname:string}
type Robot = {Id:string}

let Fry = {Name="Fry"; Vorname="Philip J."}
let Bender = {Id="BendingBenderRodriguez"}

type PlanetExpressEmployee =
    | Human of Person
    | Bot of Robot

let Deliveryboy = Human Fry
let Cook = Bot Bender


//operators
let person1 = {Name="Fry"; Vorname="Philip J."}
let person2 = {Name="Fry"; Vorname="Philip J."}
printfn "%A" (person1 = person2)


//type inference
printfn "%s" 123
printfn "%d" true


//immutability
let number = 100;
number = 200;
number <- 200;


// list handling
let twoToFive = [2..5]
let oneToFive = 1 :: twoToFive
let oneToSeven = oneToFive @ [6;7]


// functions 
let square x = x * x
square 4

let multiply x y = x * y
multiply 3 4

let findEvens list =
    let isEven x = x%2 = 0
    List.filter isEven list

findEvens oneToSeven
// piping
let maximum = 100
[1..maximum] |> List.sum |> printfn "%d"
//alternative
printfn "%d" ( List.sum ( [1..maximum] ) )

let isEven x = x%2 = 0
oneToSeven |> List.filter( isEven ) |> List.map (fun x -> x * 2)


// pattern matching
let doAMatch x =
    match x with
        | "a" -> printfn "Hello World"
        | "b" -> printfn "Good Bye"
        | _ -> printfn "Unknown"

doAMatch "a" 
doAMatch "b" 
doAMatch "c"
doAMatch "d"


//recursion
let rec recursiveCall list =
    match list with
    | [] -> []
    | first:: rest ->
        [first-1;first+1] :: recursiveCall (rest) 

let list = [1;3;5;7]
recursiveCall list

      

