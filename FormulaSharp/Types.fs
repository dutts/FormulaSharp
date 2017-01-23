namespace FormulaSharp

type Country = string

type Team = {
    Name: string
}

type Driver = {
    Number : int
    TLA: string
    Team: Team
    FirstName: string
    LastName: string
    Nationality: Country
    PaceModifier: decimal
}
type TrackRegionPaceModifier = {
    Name: string
    IsEnabled: bool
    Modifier: decimal
}

type TrackRegion = {
    Name: string
    Pace: decimal
    PaceModifiers: TrackRegionPaceModifier seq  
}

type Track = {
    OutLap: decimal // TrackRegion seq
    FlyingLap: decimal // TrackRegion seq
    InLap: decimal // TrackRegion seq
    OutInLap: decimal // TrackRegion seq
}

type Circuit = {
    Name: string
    Country: Country
    Track: Track
    Laps: int
}

type TimingDataLap = {
    Driver: Driver
    Lap: int
    Elapsed: decimal
}

type TimingData = TimingDataLap seq

