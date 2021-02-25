using API.Entity;
using API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    [Route("~/")]
    public class StudentController : ApiController
    {
        private readonly IStudentBAL context;

        public StudentController(IStudentBAL context)
        {
            this.context = context;
        }
        // GET: api/Student
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var result = context.Get;
                if (result != null)
                    return Content(HttpStatusCode.OK, result);
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Student/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var result = context.GetById(id);
                if (result != null)
                    return Content(HttpStatusCode.OK, result);
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // POST: api/Student
        [HttpPost]
        public IHttpActionResult Post(Student student)
        {
            try
            {
                var result = context.Insert(student);
                if (result > 0)
                    return Content(HttpStatusCode.OK, result);
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [HttpPut]
        // PUT: api/Student/5
        public IHttpActionResult Put(Student student)
        {
            try
            {
                var result = context.Update(student);
                if (result > 0)
                    return Content(HttpStatusCode.OK, result);
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [HttpDelete]
        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var result = context.Delete(id);
                if (result > 0)
                    return Content(HttpStatusCode.OK, result);
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
