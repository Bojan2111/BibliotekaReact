using AutoMapper;
using Biblioteka.Models;
using Biblioteka.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClanoviController : ControllerBase
    {
        private readonly IClanoviRepository _clanoviRepository;
        private readonly IMapper _mapper;

        public ClanoviController(IClanoviRepository clanoviRepository, IMapper mapper)
        {
            _clanoviRepository = clanoviRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("api/clanovi")]
        public IActionResult GetClanovi()
        {
            return Ok(_clanoviRepository.GetAll());
        }

        [HttpGet]
        [Route("api/clanovi/{id}")]
        public IActionResult GetClan(int id)
        {
            var clan = _clanoviRepository.GetById(id);
            if (clan == null)
            {
                return NotFound();
            }
            return Ok(clan);
        }

        [HttpPost]
        [Route("api/clanovi")]
        public IActionResult PostClan([FromBody] Clan clan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _clanoviRepository.Add(clan);
            return CreatedAtAction("GetClan", new Clan() { Id = clan.Id}, clan);
        }

        [HttpPut]
        [Route("api/clanovi/{id}")]
        public IActionResult PutClan(int id, [FromBody] Clan clan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != clan.Id)
            {
                return BadRequest();
            }

            try
            {
                _clanoviRepository.Update(clan);
            }
            catch
            {
                return BadRequest();
            }
            return Ok(clan);
        }

        [HttpDelete]
        [Route("api/clanovi/{id}")]
        public IActionResult DeleteClan(int id)
        {
            var clan = _clanoviRepository.GetById(id);
            if (clan == null)
            {
                return NotFound();
            }

            _clanoviRepository.Delete(clan);
            return NoContent();
        }
    }
}
