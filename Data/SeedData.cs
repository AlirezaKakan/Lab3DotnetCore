using System.Net.Mime;
using Lab03.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data;
using Microsoft.Extensions.DependencyInjection;
using Lab03.Data;

namespace Lab03.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<City>().HasData
                (
                    GetCities()  
                );

                modelBuilder.Entity<Province>().HasData
                (
                    GetProvinces()  
                );
        }

    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City() {
                CityId = 1,
                CityName = "Vancouver",
                Population = 100,
                Province = "BC",
            },
            new City() {
                CityId = 2,
                CityName = "Burnaby",
                Population = 150,
                Province = "BC",
            },
            new City() {
                CityId = 3,
                CityName = "Surrey",
                Population = 200,
                Province = "BC",
            },
            new City() {
                CityId = 4,
                CityName = "Edmonton",
                Population = 250,
                Province = "AL",
            },
        };

        return cities;
    }

    public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province() {
                ProvinceName = "British Columbia",
                ProvinceCode = "BC"
            },
            new Province() {
                ProvinceName = "Alberta",
                ProvinceCode = "AL",
            },
        };

        return provinces;
    }
}

}