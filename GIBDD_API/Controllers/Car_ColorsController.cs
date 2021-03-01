using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GIBDD_API.Entities;

namespace GIBDD_API.Controllers
{
    public class Car_ColorsController : ApiController
    {
        private GIBDDEntities db = new GIBDDEntities();

        // GET: api/Car_Colors
        public IQueryable<Car_Colors> GetCar_Colors()
        {
            return db.Car_Colors;
        }

        // GET: api/Car_Colors/5
        [ResponseType(typeof(Car_Colors))]
        public IHttpActionResult GetCar_Colors(string id)
        {
            Car_Colors car_Colors = db.Car_Colors.Find(id);
            if (car_Colors == null)
            {
                return NotFound();
            }

            return Ok(car_Colors);
        }

        // PUT: api/Car_Colors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCar_Colors(string id, Car_Colors car_Colors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != car_Colors.Color_code)
            {
                return BadRequest();
            }

            db.Entry(car_Colors).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Car_ColorsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Car_Colors
        [ResponseType(typeof(Car_Colors))]
        public IHttpActionResult PostCar_Colors(Car_Colors car_Colors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Car_Colors.Add(car_Colors);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Car_ColorsExists(car_Colors.Color_code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = car_Colors.Color_code }, car_Colors);
        }

        // DELETE: api/Car_Colors/5
        [ResponseType(typeof(Car_Colors))]
        public IHttpActionResult DeleteCar_Colors(string id)
        {
            Car_Colors car_Colors = db.Car_Colors.Find(id);
            if (car_Colors == null)
            {
                return NotFound();
            }

            db.Car_Colors.Remove(car_Colors);
            db.SaveChanges();

            return Ok(car_Colors);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Car_ColorsExists(string id)
        {
            return db.Car_Colors.Count(e => e.Color_code == id) > 0;
        }
    }
}