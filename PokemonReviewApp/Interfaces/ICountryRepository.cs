﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {

        ICollection<Country> getCountries();
        Country getCountry(int id);
        Country getCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExist(int id);

        bool CreateCountry(Country country);

        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
        bool Save();
    }
}