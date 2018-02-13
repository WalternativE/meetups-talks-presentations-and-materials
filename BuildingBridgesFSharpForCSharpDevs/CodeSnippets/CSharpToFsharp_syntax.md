```csharp
public class Person
{
  public Person(string name, DateTime birthday)
  {
    Name = name;
    Birthday = birthday;
  }

  public string Name { get; }
  public DateTime Birthday { get; }
}
```

```csharp
public class Person =

  public Person(string name, DateTime birthday) =

    Name = name;
    Birthday = birthday;


  public string Name = { get; }
  public DateTime Birthday = { get; }
```

```csharp
public class Person =

  public Person(string name, DateTime birthday) =
    Name = name;
    Birthday = birthday;

  public string Name = { get; }
  public DateTime Birthday = { get; }
```

```csharp
public class Person =

  public Person(string name, DateTime birthday) =
    ...

  public string Name = get { return name; }
  public DateTime Birthday = get { return birthday; }
```

```csharp
public class Person(string name, DateTime birthday) =

  public string Name = get { return name; }
  public DateTime Birthday = get { return birthday; }
```

```csharp
public class Person(string name, DateTime birthday) =

  public string Name = return name;
  public DateTime Birthday = return birthday;
```

```csharp
public class Person(string name, DateTime birthday) =

  public string Name = return name
  public DateTime Birthday = return birthday
```

```csharp
public class Person(string name, DateTime birthday) =

  public string Name = name
  public DateTime Birthday = birthday
```

```csharp
class Person(string name, DateTime birthday) =

  string Name = name
  DateTime Birthday = birthday
```

```csharp
class Person(string name, DateTime birthday) =

  Name = name
  Birthday = birthday
```

```fsharp
class Person(string name, DateTime birthday) =

  member this.Name = name
  member this.Birthday = birthday
```

```fsharp
class Person(string name, DateTime birthday) =

  member this.Name = name
  member this.Birthday = birthday

  member this.Age() =
    var daysDiff = DateTime.Today.Subtract(birthday).Days
    daysDiff / 365
```

```fsharp
class Person(name : string, birthday : DateTime) =

  member this.Name = name
  member this.Birthday = birthday

  member this.Age() =
    var daysDiff = DateTime.Today.Subtract(birthday).Days
    daysDiff / 365
```

```fsharp
type Person(name : string, birthday : DateTime) =

  member this.Name = name
  member this.Birthday = birthday

  member this.Age() =
    let daysDiff = DateTime.Today.Subtract(birthday).Days
    daysDiff / 365
```

C# Primary constructor example

```csharp
public class Person(string name, DateTime birthday)
{
  public string Name { get; } = name;
  public DateTime Birthday { get; } = birthday;
}
```

```csharp
public class Person
{
  ...

  public int Age() =>
    DateTime.Today.Subtract(Birthday).Days / 365;
}
```

```fsharp
type Person =
  { Name : string
    Birthday : DateTime }
```

```fsharp
type Person =
  { Name : string
    Birthday : DateTime }

let age person =
  let daysDiff = DateTime.Today.Subtract(person.Birthday).Days
  daysDiff / 365
```

```fsharp
type Person =
  { Name : string
    Birthday : DateTime }

let age person =
  let daysDiff = DateTime.Today.Subtract(person.Birthday).Days
  daysDiff / 365
// Person -> int
```

```fsharp
let doSomething f x =
  let y = f (x + 1)
  "hello" + y
```

```fsharp
let doSomething f x =
  let y = f (x + 1)
  "hello" + y

//val doSomething : (int -> string) -> int -> string
```

```csharp
public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
  this IEnumerable<TSource> source,
  Func<TSource, TKey> keySelector
)
{
  ...
}
```

```fsharp
let groupBy keySelector source =
  ...

or

let groupBy (projection:'T->'Key) (source:seq<'T>) =
  ...
```

```fsharp
let x = 1

x <- 2 // assign 2 to x - this won't compile
```

```fsharp
let mutable x = 1 // we are explicit about mutability

x <- 2 // assign 2 to x - this is allowed
```

```fsharp
type Person =
  { Name : string
    Birthday : DateTime }

let bob : Person = null // this will not compile
```

```fsharp
[<AllowNullLiteral>]
type Person(name : string, birthday : DateTime) =
  member this.Name = name
  member this.Birthday = birthday

let bob : Person = null // this is allowed
```

```fsharp
type Person =
  { Name : string
    Birthday : DateTime }

let bob : Person = null // this will not compile
```

```fsharp
type Person = 
    { Name : string
      Birthday : DateTime }

let franzMueller = { Name = "Franz"; Birthday = DateTime.Parse("1991-09-01") }
let franzBecker = { Name = "Franz"; Birthday = DateTime.Parse("1991-09-01") }

franzBecker = franzMueller // evaluates to true
```

```fsharp
type Person = 
    { Name : string
      Birthday : DateTime }

let aPerson : Person        // leaving it like that is invalid
```

```fsharp
type Person = 
    { Name : string
      Birthday : DateTime }

let maria = { Name = "Maria" } // partial initialization is also invalid
```

```csharp
var x = 1;
DoSomething(x);

var y = "hello " + x;
```

```JavaScript
function DoSomething(something) { x = "world"; }

var x = 1;
DoSomething(x);

var y = "hello " + x;
```

```csharp
var customer1 = new Customer(10, "Gerti Mayer");
var customer2 = new Customer(10, "Gerti Mayer");

customer1 == customer2; // true or false?
```

```csharp
var customer1 = new Customer(10, "Maria Mueller");
var order1 = new Order(10, "Maria Mueller");

customer1.Equals(order1); // true or false?
```

```csharp
var customer = new Customer();

Console.WriteLine(customer.Address.Country);
```

```csharp
// create customer
var customer = new Customer(42, "Arthur Dent");

// add it to a set
var customers = new HashSet<Customer>();
customers.Add(customer);

// process the customer
ProcessCustomer(customer);

// now we look it up again
customers.Contains(customer); // true or false?
```

```csharp
// create customer
var customer = new ImmutableCustomer(42, "Arthur Dent");

// add it to a set
var customers = new HashSet<ImmutableCustomer>();
customers.Add(customer);

// process the customer and return the changed state
var changedCustomer = ProcessCustomer(customer);

// now we look it up again
customers.Contains(customer); // true or false?
```

```csharp
// get connection to data store
var repo = CustomerRepsitory.GetInstance();

// find a customer by Id
var customer = repo.GetById(1337);

// what will be the output?
Console.WriteLine(customer.Id);
```

```csharp
// get connection to data store
var repo = CustomerRepsitory.GetInstance();

// find a customer by Id
var customerOrError = repo.GetById(1337);

if (customerOrError.IsCustomer)
  Console.WriteLine(customerOrError.Customer.Id);

if (cusstomerOrError.IsError)
  Console.WriteLine(customerOrError.Error.Message);
```

```fsharp
let x = 1
```

```fsharp
let add x y = x + y
```

```fsharp
let add1 x = x + 1
let double x = x * 2

let add1AndDouble =
    add1 >> double

add1AndDouble 4
// val it : int = 10
```

```csharp
Func<int, int> add1 = x => x + 1;
Func<int, int> double = x => x * 2;

var composed = add.Compose(double);
```

```fsharp
add1 5                        // 6
double (add1 5)               // 12
square (double (add1 5))      // 144
```

```fsharp
5 |> add1                         // 6
5 |> add1 |> double               // 12
5 |> add1 |> double |> square     // 144
```

```csharp
Func<int, int> add1 = x => x + 1;
Func<int, int> double = x => x * 2;
Func<int, int> square = x => x * x;

5.Pipe(add1).Pipe(double).Pipe(square);
```

```fsharp
let printList () =
    for i in [1..10] do
        printfn "the nuber is %i" i
```

```fsharp
let printList integers =
    for i in integers do
        printfn "the nuber is %i" i
```

```fsharp
let printList action integers =
    for i in integers do
        action i
```

```csharp
public static int Product(int i)
{
  int product = 1;
  for (int i = 1; i <= n; i++)
  {
    product *= 1;
  }
  return product;
}

public static int Sum(int i)
{
  int sum = 0;
  for (int i = 1; i <= n; i++)
  {
    sum += i;
  }
  return sum;
}
```

```fsharp
let fold action initialValue list =
  let mutable totalSoFar = initialValue
  for item in list do
    totalSoFar <- action totalSoFar item
  totalSoFar
```

```fsharp
let product n =
  let initialValue = 1
  let action productSoFar x = productSoFar * x
  [1..n] |> List.fold action initialValue

let sum n =
  let initialValue = 1
  let action sumSoFar x = sumSoFar + x
  [1..n] |> List.fold action initialValue
```

```fsharp
type FruitSalad =
  { Apple : AppleVariant
    Cherry : CherryVariant
    Banana : BananaVariant }
```

```fsharp
type Snack =
  | Apple of AppleVariant
  | Cherry of CherryVariant
  | Banana of BananaVariant
```

```csharp
interface IPaymentMethod
{...}

class Cash : IPaymentMethod
{...}

class Check : IPaymentMethod
{
  Check(int checkNumber) {...}
  ...
}

class Card : IPaymentMethod
{
  Card(string cardType, string cardNumber) {...}
  ...
}
```

```fsharp
type CheckNumber = int
type CardNumber = string
type CardType = Visa | Mastercard
type CreditCardInfo = CardType * CardNumber

type PaymentMethod =
  | Cash
  | Check of CheckNumber
  | Card of CreditCardInfo

type PaymentAmount = decimal
type Currency = EUR | USD

type Payment =
  { Amount : PaymentAmount
    Currency : Currency
    Method : PaymentMethod }
```

```fsharp
type Suit = Club | Diamond | Spade | Heart
type Rank = Two | Three | Four | Five | Six | Seven | Eigh
            | Nine | Ten | Jack | Queen | King | Ace
type Card = Suit * Rank

type Hand = Card list
type Deck = Card list

type Player = { Name : string; Hand : Hand }
type Game = { Deck : Deck; Players : Player list }
```

```fsharp
type Suit = Club | Diamond | Spade | Heart
type Rank = Two | Three | Four | Five | Six | Seven | Eigh
            | Nine | Ten | Jack | Queen | King | Ace
type Card = Suit * Rank

type Hand = Card list
type Deck = Card list

type Player = { Name : string; Hand : Hand }
type Game = { Deck : Deck; Players : Player list }

type Deal = Deck -> (Deck * Card)
type PickupCard = (Hand * Card) -> Hand
```