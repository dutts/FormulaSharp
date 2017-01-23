// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Types.fs"
open FormulaSharp

// Define your library scripting code here

let team : Team = { Name = "Team 1" }

let driver1 = { Number = 1; TLA = "DUT"; Team = team; FirstName = "Richard"; LastName = "Dutton"; Nationality = "British"; PaceModifier = 0.00M }
let driver2 = { Number = 2; TLA = "RIC"; Team = team; FirstName = "Rich"; LastName = "Dutts"; Nationality = "British"; PaceModifier = 0.00M }
let drivers = [ driver1; driver2 ]

let track = { OutLap = 80M; FlyingLap = 77.142M; InLap = 79M; OutInLap = 75M }
let monaco = { Name = "Monaco"; Country = "Monaco"; Track = track; Laps = 60 }

let advanceDriverByLap circuitLapPace driver =
    circuitLapPace + driver.Pace
    
let sortedTiming timing =
    timing
    |>Seq.sortBy (fun f -> f.Elapsed)

let runSim drivers circuit =
    let lapSimData = Seq.empty
    let lapLoop = 
        for lap = 1 to circuit.Laps do 
//            let driverLoop = 
//                for driver in drivers do
//                    let previousLapTime = lapSimData.find (fun t -> t.Driver = driver && t.Lap = lap) 
//                    let driverLapTime = advanceDriverByLap circuit.Track.FlyingLap driver
//                    lapSimData |> Seq.append { Driver = driver; Lap = lap; Elapsed = previousLapTime.Elapsed + driverLapTime}
//                    ignore
        
    lapSimData