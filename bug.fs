let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10

//However if we do this:

let swap' (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable x' = ref 10
let mutable y' = ref 20
swap' x' y'
printf "%d %d" (!x') (!y') //this will print 20 10 as expected