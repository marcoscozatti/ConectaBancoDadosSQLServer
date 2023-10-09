using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConectaBancoDadosSQLServer.Controllers
{
    public class MeuMetodo
    {
        public class MeuControlador : Controller
        {
            [HttpPost]
            public IActionResult MeuMetodo([FromBody] MeuModel modelo)
            {
                // Execute sua lógica do servidor aqui com base nos dados enviados no modelo
                // Por exemplo, você pode executar consultas de banco de dados ou qualquer outra operação necessária.

                // Retorna uma resposta JSON para o cliente
                return Json(new { mensagem = "Método executado com sucesso!" });
            }
        }

    }
}
