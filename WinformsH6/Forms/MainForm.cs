using Guna.UI2.WinForms;
using System.Text.Json;
using WinformsH6.Forms;
using WinformsH6.Models;
using WinformsH6.UserControls;

namespace WinformsH6;

public partial class MainForm : Form
{
    const string _apiKey = "5aa4e11a";
    const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";
    private List<string> _movieDataBase;
    private List<string> _filters;

    public MainForm()
    {
        InitializeComponent();
        _movieDataBase = new();
        if (File.Exists("MovieDataBase.json"))
            _movieDataBase = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("MovieDataBase.json"))!;
        _filters = new();
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        BackColor = Color.FromArgb(47, 47, 47);
        btnSearch.BackColor = Color.FromArgb(252, 163, 47);

        using HttpClient client = new();
        string jsonStr;

        foreach (var m in _movieDataBase)
        {
            jsonStr = await client.GetStringAsync($"{_url}&t={m}&plot=full");

            if (!jsonStr.Contains("Error"))
            {
                var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
                flowLayoutPanel1.Controls.Add(new UC_Movie(movie));
            }
        }

    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            MessageBox.Show("Please Enter Movie Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using HttpClient client = new();
        string jsonStr = await client.GetStringAsync($"{_url}&t={txtSearch.Text}&plot=full");

        if (!jsonStr.Contains("Error"))
        {
            var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
            MovieInfoForm movieInfoForm = new(movie);
            movieInfoForm.ShowDialog();

            if (!AddMovie(movie))
                return;

            flowLayoutPanel1.Controls.Add(new UC_Movie(movie!));
            _movieDataBase.Add(movie?.Title!);
            string str = JsonSerializer.Serialize(_movieDataBase);
            File.WriteAllText("MovieDataBase.json", str);
            return;
        }

        MessageBox.Show("Movie Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please Enter Movie Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using HttpClient client = new();
            string jsonStr = await client.GetStringAsync($"{_url}&t={txtSearch.Text}&plot=full");

            if (!jsonStr.Contains("Error"))
            {
                var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
                MovieInfoForm movieInfoForm = new(movie);
                movieInfoForm.ShowDialog();

                if (!AddMovie(movie))
                    return;

                flowLayoutPanel1.Controls.Add(new UC_Movie(movie!));
                _movieDataBase.Add(movie?.Title!);
                string str = JsonSerializer.Serialize(_movieDataBase);
                File.WriteAllText("MovieDataBase.json", str);
                return;
            }

            MessageBox.Show("Movie Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void CheckBox_CheckedChanged(object sender, EventArgs e)
    {
        var chk = sender as Guna2CheckBox;

        if (chk!.Checked)
            _filters.Add(chk.Text);
        else
            _filters.Remove(chk.Text);

        bool isFiltered;

        foreach (var control in flowLayoutPanel1.Controls.OfType<UC_Movie>())
        {
            isFiltered = false;

            foreach (var filter in _filters)
            {
                if (control.Movie.Genre!.ToLower().Contains(filter.ToLower()))
                {
                    isFiltered = true;
                    break;
                }
            }

            if (!isFiltered)
            {
                control.Enabled = false;
                control.Visible = false;
            }
            else
            {
                control.Enabled = true;
                control.Visible = true;
            }
        }
    }



    private bool AddMovie(Movie movie)
    {
        foreach (var m in _movieDataBase)
        {
            if (m.ToLower() == movie.Title.ToLower()!)
                return false;
        }
        return true;
    }

    private void btnResetFilters_Click(object sender, EventArgs e)
    {
        foreach (var cb in panelFilters.Controls.OfType<Guna2CheckBox>())
            cb.Checked = false;

        foreach (var control in flowLayoutPanel1.Controls.OfType<UC_Movie>())
        {
            control.Enabled = true;
            control.Visible = true;
        }
    }
}