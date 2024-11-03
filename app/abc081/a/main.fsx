stdin.ReadLine()
|> Seq.filter(fun w -> w = '1')
|> Seq.length
|> printfn "%d"