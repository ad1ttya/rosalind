// Counting DNA Nucleotides

let text = "CAAGCAGCTATTCGATTATCGTTCCCTTCAGACGC"

['A'; 'C'; 'G'; 'T'] 
|> List.map (fun s -> text.Split(s).Length - 1) 
|> List.map (fun s -> printf "%d " s)