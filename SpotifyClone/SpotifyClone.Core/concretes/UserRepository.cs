using System;
using Spotify.core.concretes;
using Spotify.core.DbConnection.EntityFramework;
using Spotify.core.dtos.UserDto;
using Spotify.entities.abstracts;
using SpotifyClone.Core.abstracts;

namespace SpotifyClone.Core.concretes
{
    public class UserRepository : Repository<UserDto>, IUserRepository
    {
        public UserRepository(DataBaseConnection context) : base(context)
        {
        }
    }
}

