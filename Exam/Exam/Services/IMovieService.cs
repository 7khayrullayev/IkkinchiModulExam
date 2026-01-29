using Exam.Dtos;
using System.Diagnostics.Contracts;

namespace Exam.Services;

public interface IMovieService
{
    public List<MovieDto> GetAllMoviesByDirector(string director);
    public MovieDto GetTopRatedMovie();
    public List<MovieDto> GetMoviesReleasedAfterYear(int year);
    public MovieDto GetHighestGrossingMovie();
    public List<MovieDto> SearchMoviesByTitle(string keyword);
    public List<MovieDto> GetMoviesWithinDurationRange(int minMinutes, int maxMinutes);
    public long GetTotalBoxOfficeEarningsByDirector(string director);
    public List<MovieDto> GetMoviesSortedByRating();
    public List<MovieDto> GetRecentMovies(int years);
}
