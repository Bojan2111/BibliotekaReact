using AutoMapper;
using AutoMapper.QueryableExtensions;
using BibliotekaAPI.Models;
using BibliotekaAPI.Models.Dtos;
using BibliotekaAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotekaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnjigeController : ControllerBase
    {
        private readonly IKnjigeRepository _knjigeRepository;
        private readonly IMapper _mapper;

        public KnjigeController(IKnjigeRepository knjigeRepository, IMapper mapper)
        {
            _knjigeRepository = knjigeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("api/knjige")]
        public IActionResult GetKnjige()
        {
            return Ok(_knjigeRepository.GetAll().ProjectTo<KnjigaDTO>(_mapper.ConfigurationProvider).ToList());
        }

        [HttpGet]
        [Route("api/knjige/{id}")]
        public IActionResult GetKnjiga(int id)
        {
            var knjiga = _knjigeRepository.GetById(id);
            if (knjiga == null)
            {
                return NotFound();
            }
            return Ok(knjiga);
        }

        [HttpPost]
        [Route("api/knjige")]
        public IActionResult PostKnjiga([FromBody] Knjiga knjiga)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _knjigeRepository.Add(knjiga);
            return CreatedAtAction("GetKnjiga", new Knjiga() { Id = knjiga.Id }, knjiga);
        }

        [HttpPut]
        [Route("api/knjige/{id}")]
        public IActionResult PutKnjiga(int id, [FromBody] Knjiga knjiga)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != knjiga.Id)
            {
                return BadRequest();
            }

            try
            {
                _knjigeRepository.Update(knjiga);
            }
            catch
            {
                return BadRequest();
            }
            return Ok(knjiga);
        }

        [HttpDelete]
        [Route("api/knjige/{id}")]
        public IActionResult DeleteKnjiga(int id)
        {
            var knjiga = _knjigeRepository.GetById(id);
            if (knjiga == null)
            {
                return NotFound();
            }

            _knjigeRepository.Delete(knjiga);
            return NoContent();
        }
    }
}
