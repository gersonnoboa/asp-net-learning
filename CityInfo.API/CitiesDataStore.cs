﻿using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities =
            [
                new()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }

                    }
                },
                new()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one  with the cathedral that was never really finished.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new(){
                            Id = 1,
                            Name = "Cathedral of Our Lady",
                            Description = ""
                        },
                        new(){
                            Id= 2,
                            Name = "Antwerp Central Station",
                            Description = "The finest example of railway architecture in Belgium"
                        }
                    }
                },
                new() {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the Champ de Mars."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "The Louvre",
                            Description = "The world's largest museum."
                        }
                    }
                }
            ];
        }
    }
}
