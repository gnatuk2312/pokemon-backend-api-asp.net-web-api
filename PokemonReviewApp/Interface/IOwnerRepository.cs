﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonOfAOwner(int ownerId);
        bool OwnerExists(int ownerId);
    }
}
