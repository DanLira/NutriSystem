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
    public class PacienteController : Controller
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;
        public PacienteController(IPacienteRepositorio pacienteRepo)
        {
            _pacienteRepositorio = pacienteRepo;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Paciente> GetAll()
        {
            return _pacienteRepositorio.GetAll();
        }

        [HttpGet("GetById/{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                var paciente = _pacienteRepositorio.Find(id);
                return new OkObjectResult(paciente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Paciente paciente)
        {
            try
            {
                _pacienteRepositorio.Add(paciente);
                return CreatedAtRoute("GetPaciente", new { id = paciente.PacienteId }, paciente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Paciente paciente)
        {
            try
            {
                _pacienteRepositorio.Update(paciente);
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
                _pacienteRepositorio.Remove(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
