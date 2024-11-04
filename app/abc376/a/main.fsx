#nowarn "0025"
let [|_;c|] = stdin.ReadLine().Split() |> Array.map int
let ts = stdin.ReadLine().Split() |> Array.map int

let f (sum, prev) t =
    match prev with
    | -1 -> (1, t)
    | _ when t - prev >= c -> (sum + 1, t)
    | _ -> (sum, prev)

Array.fold f (0, -1) ts
|> fst
|> printfn "%d"
