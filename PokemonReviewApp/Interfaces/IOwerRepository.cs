using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfaPokemon(int pokeid);
        ICollection<Pokemon> GetPokemonByOwner(int onwerId);
        bool OwnerExists(int ownerId);
        bool CreateOwner(Owner owner);

        bool DeleteOwner(Owner owner);
        bool UpdateOwner(Owner owner);
        bool Save();

    }
}
