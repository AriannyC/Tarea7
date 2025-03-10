using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea7.Contex;
using Tarea7.Repository;

namespace Tarea7.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [ApiController]
    public class CT_PR_PV_Controller : ControllerBase
    {
        private readonly UserContex _context;
        public CT_PR_PV_Controller(UserContex cont)
        { 
        
           _context = cont;
        
        
        }

        [HttpGet("CateEspecifico")]

        public async Task<IActionResult> CatEspecifi(int idc)
        {
            var tot = await _context.prod.Where(x => x.IdCategoria == idc).ToListAsync();
            return Ok(tot);
        }



        [HttpGet("PROEspecifico")]

        public async Task<IActionResult> Especifi(int idpv)
        {
            var tot = await _context.prod.Where(x => x.IdProveedor == idpv).ToListAsync();
            return Ok(tot);
        }

        [HttpGet("total")]

        public async Task<IActionResult> GetCat()
        {
            var tot = await _context.prod.Where(x=>x.Id>=0).CountAsync();
           return Ok(new { cant=tot });
        }
    
    
    
    }
}
