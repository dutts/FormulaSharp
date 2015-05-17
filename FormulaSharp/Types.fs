namespace FormulaSharp

type Country = string

type Driver = {
    TLA: string;
    FirstName: string;
    LastName: string;
    Nationality: Country;
    PaceModifier: decimal;
}

type Team = {
    Name: string;
    Drivers: Driver seq;
}

type TrackRegionPaceModifier = {
    Name: string;
    IsEnabled: bool;
    Modifier: decimal;
}

type TrackRegion = {
    Name: string;
    Pace: decimal;
    PaceModifiers: TrackRegionPaceModifier seq;    
}

type Track = {
    OutLap: TrackRegion seq;
    FlyingLap: TrackRegion seq;
    InLap: TrackRegion seq;
    OutInLap: TrackRegion seq;
}

type Circuit = {
    Name: string;
    Country: Country;
    Track: Track;
    Laps: int;
}

