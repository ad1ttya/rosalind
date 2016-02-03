// Complementing a Strand of DNA

let DNASeq = "CTGAGATAGTGGAACATGCACTGGGGTGCTGGCGCGCATGGG"

type DNA = A | G | C | T

let ParseCharacter c =
        match c with
        | 'A' -> A
        | 'C' -> C
        | 'G' -> G
        | 'T' -> T
        | _ -> raise (new System.ArgumentException("Invalid character " + c.ToString()))

let DNAtoComplement c =
        match c with 
        | DNA.A -> DNA.T
        | DNA.T -> DNA.A
        | DNA.C -> DNA.G
        | DNA.G -> DNA.C

let dna = Seq.map ParseCharacter DNASeq
let rev = Seq.toArray dna |> Array.rev |> Array.toSeq
let Complement = Seq.map DNAtoComplement rev |> Seq.iter (fun s -> printf "%A" s)