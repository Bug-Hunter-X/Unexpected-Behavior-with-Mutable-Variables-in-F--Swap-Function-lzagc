let swap (x, y) = 
    (y, x)

let mutable x = 10
let mutable y = 20

let (x, y) = swap (x, y)

printfn "%d %d" x y // Output: 20 10