using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public class FakeSearchApi : ISearchApi
    {
        public async Task<IEnumerable<SearchDTO>> GetCatalogAsync([Query] string q, [Query] double lat, [Query] double lng)
        {
            await Task.CompletedTask;
            return new List<SearchDTO>()
            {
                new SearchDTO{
                     Id= 19950,
                    Score= 25.31814,
                    Name= "Outer Barrier Reef Trip",
                    ImageUrl= "https://www.travelr.me/static/5232005972ab2839df5d3982898f7e43/1e170/karaoke.jpg",
                    SupplierName= "Reef Experience",
                    BranchName= "Cairns",
                    Category= 0,
                    DurationInMinutes= 0,
                    NumberOfNights= 0,
                    FormattedAddressName= "Cairns QLD, Australia",
                    ShortDescription= "Fully inclusive day tour to the Outer Great Barrier Reef.",
                },
                new SearchDTO{
                     Id= 19950,
                    Score= 25.31814,
                    Name= "Outer2 Barrier Reef Trip",
                    ImageUrl= "https://www.travelr.me/static/5232005972ab2839df5d3982898f7e43/1e170/karaoke.jpg",
                    SupplierName= "Reef Experience",
                    BranchName= "Cairns",
                    Category= 0,
                    DurationInMinutes= 0,
                    NumberOfNights= 0,
                    FormattedAddressName= "Cairns QLD, Australia",
                    ShortDescription= "Fully inclusive day tour to the Outer Great Barrier Reef.",
                },
                 new SearchDTO{
                     Id= 19950,
                    Score= 25.31814,
                    Name= "Outer Barrier Reef Trip",
                    ImageUrl= "https://www.travelr.me/static/5232005972ab2839df5d3982898f7e43/1e170/karaoke.jpg",
                    SupplierName= "Reef Experience",
                    BranchName= "Cairns",
                    Category= 0,
                    DurationInMinutes= 0,
                    NumberOfNights= 0,
                    FormattedAddressName= "Cairns QLD, Australia",
                    ShortDescription= "Fully inclusive day tour to the Outer Great Barrier Reef.",
                },
                new SearchDTO{
                     Id= 19950,
                    Score= 25.31814,
                    Name= "Outer2 Barrier Reef Trip",
                    ImageUrl= "https://www.travelr.me/static/5232005972ab2839df5d3982898f7e43/1e170/karaoke.jpg",
                    SupplierName= "Reef Experience",
                    BranchName= "Cairns",
                    Category= 0,
                    DurationInMinutes= 0,
                    NumberOfNights= 0,
                    FormattedAddressName= "Cairns QLD, Australia",
                    ShortDescription= "Fully inclusive day tour to the Outer Great Barrier Reef.",
                },
                 new SearchDTO{
                     Id= 19950,
                    Score= 25.31814,
                    Name= "Outer Barrier Reef Trip",
                    ImageUrl= "https://www.travelr.me/static/5232005972ab2839df5d3982898f7e43/1e170/karaoke.jpg",
                    SupplierName= "Reef Experience",
                    BranchName= "Cairns",
                    Category= 0,
                    DurationInMinutes= 0,
                    NumberOfNights= 0,
                    FormattedAddressName= "Cairns QLD, Australia",
                    ShortDescription= "Fully inclusive day tour to the Outer Great Barrier Reef.",
                },
                new SearchDTO{
                     Id= 19950,
                    Score= 25.31814,
                    Name= "Outer2 Barrier Reef Trip",
                    ImageUrl= "https://www.travelr.me/static/5232005972ab2839df5d3982898f7e43/1e170/karaoke.jpg",
                    SupplierName= "Reef Experience",
                    BranchName= "Cairns",
                    Category= 0,
                    DurationInMinutes= 0,
                    NumberOfNights= 0,
                    FormattedAddressName= "Cairns QLD, Australia",
                    ShortDescription= "Fully inclusive day tour to the Outer Great Barrier Reef.",
                },
                 new SearchDTO{
                     Id= 19950,
                    Score= 25.31814,
                    Name= "Outer Barrier Reef Trip",
                    ImageUrl= "https://www.travelr.me/static/5232005972ab2839df5d3982898f7e43/1e170/karaoke.jpg",
                    SupplierName= "Reef Experience",
                    BranchName= "Cairns",
                    Category= 0,
                    DurationInMinutes= 0,
                    NumberOfNights= 0,
                    FormattedAddressName= "Cairns QLD, Australia",
                    ShortDescription= "Fully inclusive day tour to the Outer Great Barrier Reef.",
                },
                new SearchDTO{
                     Id= 19950,
                    Score= 25.31814,
                    Name= "Outer2 Barrier Reef Trip",
                    ImageUrl= "https://www.travelr.me/static/5232005972ab2839df5d3982898f7e43/1e170/karaoke.jpg",
                    SupplierName= "Reef Experience",
                    BranchName= "Cairns",
                    Category= 0,
                    DurationInMinutes= 0,
                    NumberOfNights= 0,
                    FormattedAddressName= "Cairns QLD, Australia",
                    ShortDescription= "Fully inclusive day tour to the Outer Great Barrier Reef.",
                },
            };
        }
    }
}
