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
    public class ConsultorioController : Controller
    {
        private readonly IConsultorioRepositorio _consultorioRepositorio;
        public ConsultorioController(IConsultorioRepositorio consultorioRepo)
        {
            _consultorioRepositorio = consultorioRepo;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Consultorio> GetAll()
        {
            return _consultorioRepositorio.GetAll();
        }

        [HttpGet("GetById/{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                var consultorio = _consultorioRepositorio.Find(id);
                return new OkObjectResult(consultorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Consultorio consultorio)
        {
            try
            {
                _consultorioRepositorio.Add(consultorio);
                return CreatedAtRoute("GetConsultorio", new { id = consultorio.ConsultorioId }, consultorio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Consultorio consultorio)
        {
            try
            {
                _consultorioRepositorio.Update(consultorio);
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
                _consultorioRepositorio.Remove(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
