using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dojo_.NETcore.Modelo;
using dojo_.NETcore;
using Microsoft.AspNetCore.Mvc;

namespace dojo_.NETcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        FirebaseAccount b = FirebaseAccount.Instance;

        Usuario usuario= new Usuario();
        
        public UsuariosController()
        {
        }
        [HttpGet]
        public async Task<List<Usuario>> Get(){
            return await b.GetUser();
        }
        [HttpPost]
        public async Task<String> Post(Usuario user){
            return await b.AddUser(user);
        }

        [HttpDelete]
        public async Task<String> Delete([FromQuery]String id){
            return await b.deleteUser(id);
        }

    }
}