using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Login:ControllerBase
    {
        
        [HttpGet("teste/{valor}")]
        public object teste(double valor)
        {
            return new {
                nome = "Eduardo",
                idade = valor
            };

        }

        [HttpGet("login/{login}/{senha}")]

        public object RealizarLogin(String login, String senha )
        {
            Usuario user = new Usuario(login, senha);


            user.search(user.getLogin());

            return new{
                login = user.getLogin(),
                senha = user.getSenha()
            };
        }
            

    }
}
