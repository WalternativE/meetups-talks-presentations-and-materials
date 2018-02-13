open System

type Person (name : string, birthday : DateTime) =

  let Age() =
    let diff = DateTime.Today.Subtract(birthday).Days
    (diff + 365) / 365 

  member this.Name = name
  member this.Birthday = birthday

  member this.PublicAge() = Age()
  
let doSomething f x =
    let doSomething () = "hello "
    let y = f (x + 1)
    (doSomething ()) + y

let partiallyApplied = doSomething (fun x -> sprintf "%i" x)

partiallyApplied 10

let otherAdd t = snd t

let partialExplain x =
    let otherPart y =
        x + y
    otherPart

let onePart = partialExplain 5;

onePart 10;

partialExplain 10 5

let inOne x y = x + y

let inOneTup (x, y) = x + y

[<AllowNullLiteral>]
type NullablePerson(name : string, birthday : DateTime) =
  member this.Name = name
  member this.Birthday = birthday

type APerson = 
    { Name : string
      Birthday : DateTime }


let franzMueller = { Name = "Franz"; Birthday = DateTime.Parse("1991-09-01") }
let franzBecker = { Name = "Franz"; Birthday = DateTime.Parse("1991-09-01") }

franzBecker = franzMueller

let add1 x = x + 1
let double x = x * 2

let add1AndDouble =
    add1 >> double

let printList () =
    for i in [1..10] do
        printfn "the nuber is %i" i


type Rank = Two | Three | Four | Five | Six | Seven | Eigh
            | Nine | Ten | Jack | Queen | King | Ace


let aList = [1..15]

let greaterThan x y = y > x

let filtered =
    aList
    |> List.filter (greaterThan 5)

filtered

let addiere x y = x + y

let addiereCurried x =
    let curry y =
        x + y
    curry

let addiere5 = addiere 5