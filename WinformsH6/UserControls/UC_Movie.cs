using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsH6.Forms;
using WinformsH6.Models;

namespace WinformsH6.UserControls;

public partial class UC_Movie : UserControl
{
    public Movie Movie { get; set; }

    public UC_Movie(Movie movie)
    {
        InitializeComponent();

        Movie = movie;

        pictureBoxPoster.Load(movie.Poster);
        lblMovieName.Text = movie.Title;
        lblRated.Text = $"Rated: {movie.Rated}";
        lblCountryAndYear.Text = $"{movie.Country},{movie.Year}";
        lblIMDBRating.Text = $"IMDB: {movie?.Ratings?[0].Value ?? "None"}";
        lblGenres.Text = movie?.Genre;
    }

    private void UC_Movie_Click(object sender, EventArgs e)
    {
        var movieInfo=new MovieInfoForm(Movie);
        movieInfo.Show();
    }
}
