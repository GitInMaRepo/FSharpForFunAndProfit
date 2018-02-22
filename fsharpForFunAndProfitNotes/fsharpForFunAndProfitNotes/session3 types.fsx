
let i = 1
let s = "Hello"
let tupleOfboth = i,s
let iout, sout = tupleOfboth
let list = [sout]

let strings = ["Hello"; "World"; "How"; "Are"; "You" ]
strings |> List.map String.length |> List.sum



type TimePeriod = Hours | Days | Minutes | Seconds

type elapsedTime = {scale:TimePeriod; value:int}
let timeuntilLunch = {scale=Hours; value=3}
match timeuntilLunch.scale with
    | Hours -> printfn "Hours until Lunch %d" timeuntilLunch.value



type Temperature =
    | C of float
    | F of float 
    | K of float

let waterBoilsAt = C 100.0
let averageAdultBodyTemperature = F 100.0
let waterFreezesAt = K 273.5

type Title = 
    | Herr 
    | Frau 
    | Doktor 
    | Professor

type Person = { title:Title; vorname:string; nachname:string }

type Street = { streetname:string; housenumber:string; addition:string}

type ZipCode = { zip:string; city:string; state:string }

type PostCode = { post:string; city:string; }

type Postleitzahl = { post:int;  city:string }

type UsAdress = { street:Street; zip:ZipCode }
type UkAdress = { street:Street; post:PostCode }
type GerAdress = { street:Street; plz:Postleitzahl }
type Adress = UsAdress of UsAdress
            | UkAdress of UkAdress
            | GerAdress of GerAdress

type recipient = {person:Person; adress:Adress }

let person = {title=Title.Herr;vorname="Homer";nachname="Simpson"}
let street = {streetname="Evergreen Terrace"; housenumber = "724"; addition =""}
let zipCode = {zip="unknown"; city="Springfield"; state="unknown"}
let adress = {street=street;zip=zipCode}
let sendto = {person=person;adress=adress}