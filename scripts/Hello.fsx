open System

let balance = 2600000.0
let rate = 4.0
let paid = 16000.0


let rec calc balance month =
    if balance > 0.0 then
        let interest = (rate / 100.0 * balance) / 12.0
        let newBalance = balance - paid + interest
        printfn "%A" (String.Format("{0:#,###}", newBalance))
        calc newBalance (month + 1.0)
    else
        month / 12.0


calc balance 0. |> printfn "%A"

