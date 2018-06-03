
let (|DivisibleBy|_|) divisor i =
    if i % divisor = 0 then Some() else None

let fizzBuzz = function
    | DivisibleBy 3 & DivisibleBy 5 -> "FizzBuzz"
    | DivisibleBy 3 -> "Fizz"
    | DivisibleBy 5 -> "Buzz"
    | input -> string input

[1;3;5;15;17] |> List.map fizzBuzz |> printfn "%A"

