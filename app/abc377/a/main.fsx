let ret = stdin.ReadLine()
        |> Seq.sort
        |> Seq.toArray
        |> System.String

if ret = "ABC" then "Yes" else "No"
|> printfn "%s"
