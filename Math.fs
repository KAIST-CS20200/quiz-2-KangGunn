module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let n = int64 n
  let rec iter product count =
    if product = 1L then count
    elif product % 2L = 0L then iter (product/2L) (count+1)
    else iter (3L*product + 1L) (count+1)
  iter n 0
