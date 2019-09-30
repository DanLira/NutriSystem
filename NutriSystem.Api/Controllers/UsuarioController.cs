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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepo)
        {
            _usuarioRepositorio = usuarioRepo;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepositorio.GetAll();
        }

        [HttpGet("GetById/{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                var usuario = _usuarioRepositorio.Find(id);
                return new OkObjectResult(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.Add(usuario);
                return CreatedAtRoute("GetUsuario", new { id = usuario.UsuarioId }, usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.Update(usuario);
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
                _usuarioRepositorio.Remove(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
