//Rabbits and Recurrence relations, file: rosalind_fib.txt

let getPairs (months: int) (offsprings: int) : int64 =
    let rec pairs (n: int) (state : (int64 * int64)) : int64 =
        let (young, reproductive) = state
        match n with
        | 1 -> young +  reproductive
        | _ ->
            let state' = (reproductive * int64 offsprings, reproductive + young)
            pairs (n - 1) state'
    pairs months (int64 1,int64 0)
    
getPairs 36 3