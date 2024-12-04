let mutable x = ref 10
let mutable y = ref 20

let swap (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" (!x) (!y) //This will print 20 10

//Alternative using a tuple
let swapTuple (x:int ref, y:int ref) = 
  let temp = (!x,!y)
  x := temp.Item2
  y := temp.Item1

let mutable x2 = ref 10
let mutable y2 = ref 20
swapTuple (x2,y2)
printf "%d %d" (!x2) (!y2) //This will print 20 10