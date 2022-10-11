using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsH6.Models;

namespace WinformsH6.Forms;

public partial class MovieInfoForm : Form
{
    public MovieInfoForm(Movie movie)
    {
        InitializeComponent();
        pictureBoxPoster.Load(movie.Poster);
        lblMovieName.Text = movie.Title;
        lblAwards.Text += movie.Awards;
        lblActors.Text += movie.Actors;
        lblBoxOffice.Text += movie.BoxOffice;
        lblWriter.Text += movie.Writer;
        lblCountry.Text += movie.Country;
        lblDirector.Text += movie.Director;
        lblLanguages.Text += movie.Language;
        lblType.Text += movie.Type;
        lblRuntime.Text += movie.Runtime;
        lblRelased.Text += movie.Released;
        lblGenres.Text += movie.Genre;
        textBox1.Text += movie.Plot;
        
        StringBuilder sb = new StringBuilder();
        foreach(var rating in movie.Ratings!)
            sb.Append(rating.ToString());

        lblRatings.Text += $"\n{sb.ToString()}";
    }

    private void MovieInfoForm_Load(object sender, EventArgs e)
    {
        BackColor = Color.FromArgb(47, 47, 47);
        textBox1.BackColor = Color.FromArgb(47, 47, 47);
    }
}
