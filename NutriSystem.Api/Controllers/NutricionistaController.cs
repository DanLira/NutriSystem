using Microsoft.AspNetCore.Mvc;
using NutriSystem.Api.Interface;
using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Controllers
{
    [Route("api/[controller]")]
    public class NutricionistaController : Controller
    {
        private readonly INutricionistaRepositorio _nutricionistaRepositorio;
        public NutricionistaController(INutricionistaRepositorio nutricionistaRepo)
        {
            _nutricionistaRepositorio = nutricionistaRepo;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Nutricionista> GetAll()
        {
            return _nutricionistaRepositorio.GetAll();
        }

        [HttpGet("GetById/{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                var nutricionista = _nutricionistaRepositorio.Find(id);
                return new OkObjectResult(nutricionista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Nutricionista nutricionista)
        {
            try
            {
                _nutricionistaRepositorio.Add(nutricionista);
                return CreatedAtRoute("GetNutricionista", new { id = nutricionista.NutricionistaId }, nutricionista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Nutricionista nutricionista)
        {
            try
            {
                _nutricionistaRepositorio.Update(nutricionista);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete/{id}")]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _nutricionistaRepositorio.Remove(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
