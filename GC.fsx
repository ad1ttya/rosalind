// Computing GC Content file: rosalind_gc.txt

open System
open System.IO

let sample = File.ReadAllText "data/rosalind_gc.txt"

let inputs = sample.Split '>' |> Array.tail |> Array.map (fun i ->
    let data = i.Trim()
    let id = data.Remove(13)
    let sequence = data.Substring(14).Replace(System.Environment.NewLine, "") //Newlines are the devil!!! :O
    (id, sequence))

let gcContent = inputs |> Array.map (fun (id, sequence) ->
    let allCount = sequence.Length - 1
        
    let gcCount = sequence.Replace("A", "").Replace("T", "").Length - 1
    
    let percentage =  ((gcCount |> double) / (allCount |> double)) * 100.
    (id, percentage))

let largestID, largestPercent = gcContent |> Array.sortBy (fun (id, percent) -> percent) |> Array.last

sprintf "%s\n%f" largestID largestPercent