using BLL_Net;
using BLL_Net.Entidades;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Servicios.Entities;
using Servicios.Helpers;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Services
{
    public interface IUserService
    {
        Users Authenticate(string username, string password);
        IEnumerable<Users> GetAll();
        Users GetById(int id);
        Users RefreshToken(string refreshToken);
    }

    public class UserService : IUserService
    {

        private readonly AppSettings _appSettings;
        private readonly IMemoryCache memoryCache;

        public UserService(IOptions<AppSettings> appSettings, IMemoryCache memory)
        {
            _appSettings = appSettings.Value;
            memoryCache = memory;
        }

        private List<Users> _users = null;
        BLL_Aunteticate BLL_Aunteticate = null;

        public List<Users> UsersList()
        {
            BLL_Aunteticate = new BLL_Aunteticate(_appSettings.ApplicationConnection);

            // Nota: el uso de cache no es tan eficiente en este contexto, ya que el token y/o tokenRefresh se actualizan con frecuencia en la bd, 
            // y no tendria sentido actualizar cache a cada momento (se debe esoger la relacion entre tiempo de expiracion dle token/ uso de cache )
            if (_appSettings.HabilitarCache)
            {// si se habilita el uso de cache en la aplicacion 
                return memoryCache.GetOrCreate("ListaUsuarios", CacheEntry =>
                {
                    MemoryCacheEntryOptions cacheExpirationOptions = new MemoryCacheEntryOptions();
                    cacheExpirationOptions.AbsoluteExpiration = DateTime.Now.AddMinutes(_appSettings.ExpireCacheMinutes);
                    cacheExpirationOptions.Priority = CacheItemPriority.Normal;

                    BLL_Aunteticate = new BLL_Aunteticate(_appSettings.ApplicationConnection);
                    return BLL_Aunteticate.List_All_Users();
                });
            }
            else
            {//si NO se habilita el uso de cache en la aplicacion 
                BLL_Aunteticate = new BLL_Aunteticate(_appSettings.ApplicationConnection);
                return BLL_Aunteticate.List_All_Users();
            }



        }

        public Users Authenticate(string username, string password)
        {
            _users = UsersList();
            Users user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
            {
                return null;
            }

            // authentication successful so generate jwt token
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            int ExpireTokenMinutes = _appSettings.ExpireTokenMinutes;

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]{
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                NotBefore = DateTime.Now,
                Expires = DateTime.Now.AddMinutes(ExpireTokenMinutes),
                IssuedAt = DateTime.Now,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            user.RefreshToken = Guid.NewGuid().ToString();

            // remove password before returning 
            BLL_Aunteticate.Update_Users_Token(user.Id, user.Token, user.RefreshToken);

            return new Users
            {
                Id = null,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = null,
                Role = user.Role,
                Token = user.Token,
                RefreshToken = user.RefreshToken
            };
        }

        public Users RefreshToken(string refreshToken)
        {
            _users = UsersList();
            Users user = _users.SingleOrDefault(m => m.RefreshToken == refreshToken);

            if (user == null)
            {
                return null;
            }

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            int ExpireTokenMinutes = _appSettings.ExpireTokenMinutes;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]{
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                NotBefore = DateTime.Now,
                Expires = DateTime.Now.AddMinutes(ExpireTokenMinutes),
                IssuedAt = DateTime.Now,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            user.RefreshToken = Guid.NewGuid().ToString();

            BLL_Aunteticate.Update_Users_Token(user.Id, user.Token, user.RefreshToken);
            // user.Id = null;


            // la creacion d eeste nuevo objeto, es con fin de no modificar el objeto guardado en cache, ya que se debe cambiar el password a null antes de enviarlo al cliente
            return new Users
            {
                Id = null,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = null,
                Role = user.Role,
                Token = user.Token,
                RefreshToken = user.RefreshToken
            };
        }

        public IEnumerable<Users> GetAll()
        {
            // return users without passwords
            return _users.Select(x =>
            {
                x.Password = null;
                return x;
            });
        }

        public Users GetById(int id)
        {
            Users user = _users.FirstOrDefault(x => x.Id == id);

            // return user without password
            if (user != null)
            {
                user.Password = null;
            }
            return user;
        }


    }
}
