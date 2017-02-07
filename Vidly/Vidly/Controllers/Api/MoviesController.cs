using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

       public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        //GET /api/movies
        public IEnumerable<MovieDto> GetMovies()
        {
     
            return _context.Movies.ToList().Select(Mapper.Map<Movie,MovieDto>);

        }


        //GET /api/movies/1
        public MovieDto GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if(movie ==null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Movie,MovieDto>(movie);

        }
        //POST /api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        //PUT /api/customers/1
        [HttpPut]
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map<Movie, MovieDto>(movieInDb, movieDto);


            _context.SaveChanges();

        }

        //DELETE /api/customers/1
        public void DeleteMovie(int id)
        {
            var movieInDB = _context.Movies.SingleOrDefault(m => m.Id == id);

            if(movieInDB==null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDB);
            _context.SaveChanges();
        }

    }
}
