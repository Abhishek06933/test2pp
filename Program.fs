// Define discriminated union genre
type Genre = 
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

// Define the Director record type
type Director = {
    Name: string
    Movies: int
}

// Define the Movie record type
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDbRating: float
}

// Create movie instances
let coda = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDbRating = 8.1 }
let belfast = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDbRating = 7.3 }
let dontLookUp = { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; Movies = 27 }; IMDbRating = 7.2 }
let driveMyCar = { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDbRating = 7.6 }
let dune = { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDbRating = 8.1 }
let kingRichard = { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDbRating = 7.5 }
let licoricePizza = { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDbRating = 7.4 }
let nightmareAlley = { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDbRating = 7.1 }

// Create a list of movies
let ListOfmovies = [coda; belfast; dontLookUp; driveMyCar; dune; kingRichard; licoricePizza; nightmareAlley]

// Identify probable Oscar winners
let oscarwinners = List.filter (fun movie -> movie.IMDbRating > 7.4) ListOfmovies

// Convert movie run length to hours
let Conversion (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

// Create a list of tuples containing movie name and converted run length
let NameAndLength = List.map (fun movie -> (movie.Name, Conversion movie.RunLength)) ListOfmovies

// Print the probable Oscar winners
printfn "\nOscar Winners:"
oscarwinners |> List.iter (fun movie -> printfn "%s" movie.Name)

printfn""

// Print the movie name and converted run length
printfn "Movie Name and Converted Lengths:"
NameAndLength |> List.iter (fun (name, convertedLength) -> printfn "%s: %s" name convertedLength)
