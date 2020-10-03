using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dojo_.net.Modelo;
using Microsoft.AspNetCore.Mvc;
namespace dojo_.net.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        FireBaseAccount Instancia = FireBaseAccount.Instancia;
        Usuario usuario = new Usuario();
        [HttpGet]
        public async Task<List<Usuario>> Get()
        {
            return await Instancia.GetUser();
        }
        [HttpPost]
        public async Task<String> Post(Usuario user)
        {
            return await Instancia.AddUser(user);
        }

        [HttpDelete]
        public async Task<String> Delete([FromQuery] String id)
        {
            return await Instancia.deleteUser(id);
        }
    }
}