let _ = stdin.ReadLine()
let ss = stdin.ReadLine()

let f (sum, prev) s =
    match prev, s with
    | "#.", '#' -> (sum + 1, "#")
    | "#", '.' -> (sum, "#.")
    | "#", '#' -> (sum, "#")
    | _ -> (sum, string s)

Seq.fold f (0, "") ss
|> fst
|> printfn "%d"
