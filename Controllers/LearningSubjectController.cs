using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Subject.Models;
using Subject.Services;

namespace Subject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LearningSubjectController : ControllerBase
    {
        public LearningSubjectController()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<LearningSubject>> GetAll() =>
        LearningSubjectService.GetAll();

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<LearningSubject> Get(int id)
        {
            var subject = LearningSubjectService.Get(id);

            if (subject == null)
                return NotFound();

            return subject;
        }

        // POST action
        [HttpPost]
        public IActionResult Create(LearningSubject subject)
        {
            // This code will save the pizza and return a resultPizzaService.Add(pizza);
            return CreatedAtAction(nameof(Create), new { id = subject.Id }, subject);

        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, LearningSubject subject)
        {
            if (id != subject.Id)
                return BadRequest();

            var existingSubject = LearningSubjectService.Get(id);
            if (existingSubject is null)
                return NotFound();

            LearningSubjectService.Update(subject);

            return NoContent();
        }

        // DELETE action

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var subject = LearningSubjectService.Get(id);

            if (subject is null)
                return NotFound();

            LearningSubjectService.Delete(id);

            return NoContent();
        }
    }
}

