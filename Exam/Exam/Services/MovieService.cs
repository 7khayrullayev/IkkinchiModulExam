using Exam.Dtos;
using Exam.Entities;

namespace Exam.Services;

public class MovieService : IMovieService
{
    private List<Movie> MovieServices;
    public MovieService()
    {
        MovieServices = new List<Movie>();
    }
    private MovieDto ConvertToMovieDto(Movie movie)
    {
        return new MovieDto()
        {
            Id = movie.Id,
            Title = movie.Title,
            Director = movie.Director,
            DurationMinutes = movie.DurationMinutes,
            Rating = movie.Rating,
            BoxOfficeEarnings = movie.BoxOfficeEarnings,
            ReleaseDate = movie.ReleaseDate

        };
    }
    private List<MovieDto> ConvertToMovieDtos(List<Movie> movies)
    {
        var movieDtos = new List<MovieDto>();
        foreach (var movie in movies)
        {
            movieDtos.Add(ConvertToMovieDto(movie));
        }
        return movieDtos;
    }
    public List<MovieDto> GetAllMoviesByDirector(string director)
    {
        throw new NotImplementedException();
    }
    public Guid AddMovie(MovieDto createMovieDto)
    {
        var movie = new Movie()
        {
            Id = Guid.NewGuid(),
            Title = createMovieDto.Title,
            Director = createMovieDto.Director,
            DurationMinutes = createMovieDto.DurationMinutes,
            Rating = createMovieDto.Rating,
            BoxOfficeEarnings = createMovieDto.BoxOfficeEarnings,
            ReleaseDate = createMovieDto.ReleaseDate,
        };
        return movie.Id;

    }
    public Movie? GetById(Guid Id)
    {
        foreach (var movie in MovieServices)
        {
            if (movie.Id == Id) return ConvertToMovieDto(movie);
        }
        return null;
    }
    public List<MovieDto> GetAll()
    {
        return ConvertToMovieDtos(MovieServices);
    }
    public bool DeleteMovie(Guid id)
    {
        foreach (var movie in MovieServices)
        {
            if (movie.Id == id) return true;
        }

        return false;
    }
    public bool UpdateMovie(Guid id, Movie movie)
    {
        foreach (var m in MovieServices)
        {
            if (m.Id == id)
            {
                movie.Title = m.Title;
                movie.Director = m.Director;
                movie.DurationMinutes = m.DurationMinutes;
                movie.Rating = m.Rating;
                movie.BoxOfficeEarnings = m.BoxOfficeEarnings;
                movie.ReleaseDate = m.ReleaseDate;

                return true;

            }
        }
        return false;
    }

    public MovieDto GetHighestGrossingMovie()
    {
        var max = MovieServices[0];
        foreach (var m in MovieServices)
        {
            if (m.BoxOfficeEarnings > max.BoxOfficeEarnings)
            {
                max = m;
            }
        }
        return ConvertToMovieDto(max);
    }

    public List<MovieDto> GetMoviesReleasedAfterYear(int year)
    {
        var max = new List<Movie>();
        foreach (var m in MovieServices)
        {
            if (m.ReleaseDate.Year > max.ReleaseDate.Year)
            {
                max = m;
            }
        }
        return ConvertToMovieDtos(max);
    }

    public List<MovieDto> GetMoviesSortedByRating()
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> GetMoviesWithinDurationRange(int minMinutes, int maxMinutes)
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> GetRecentMovies(int years)
    {
        throw new NotImplementedException();
    }

    public MovieDto GetTopRatedMovie()
    {
        throw new NotImplementedException();
    }

    public long GetTotalBoxOfficeEarningsByDirector(string director)
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> SearchMoviesByTitle(string keyword)
    {
        throw new NotImplementedException();
    }
}
