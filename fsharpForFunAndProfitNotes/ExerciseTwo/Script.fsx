// Weitere Informationen zu F# finden Sie unter http://fsharp.org. Im Projekt "F#-Tutorial" finden Sie
// einen Leitfaden zum Programmieren in F#.

#load "Library1.fs"
open ExerciseTwo

// Skriptcode für die Bibliothek hier definieren

type AstronomicalDistance =
    | Km of float //kilometres
    | AU of float //Astronomical Units
    | Lys of float //Light years
    | Pc of float //Parsec

type AstronomicalObject = {name:string; meanDistance:AstronomicalDistance}

let nearestObjectsToTheSun = 
    [{name="Sol";meanDistance= Km 0.0};
     {name="Mercury";meanDistance= Km 57909050.00};
     {name="Venus";meanDistance=Km 108208000.00};
     {name="Earth";meanDistance=AU 1.0};
     {name="Mars";meanDistance=AU 1.523679 };
     {name="Ceres";meanDistance=AU 2.7675 };
     {name="Alpha Centauri";meanDistance=Lys 4.37 };
     {name="Arcturus";meanDistance=Pc 11.26}];
    
// As a citizen astronomer from Nürnberg I want all distances 
// to be visualized in "Nues" which are equivalent to the average length
// of a Nürnberger (8 cm)
let convertToNues input =
    match input.meanDistance with
        | Km(distance) -> distance * 12500.0
        | AU(distance) -> distance * 1875000000000.0
        | Lys(distance) -> distance * 1.18259125e+17
        | Pc(distance) -> distance  * 3.8570975e+17

nearestObjectsToTheSun |> List.map(convertToNues) |> List.map (fun f -> printfn "%f" f)

