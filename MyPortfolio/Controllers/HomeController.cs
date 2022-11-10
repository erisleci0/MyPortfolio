using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Skills> skills = new List<Skills>();

            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=MyPortfolio;port=3306;password=erisleci1"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from skills", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Skills skill = new Skills();
                    skill.Id = Convert.ToInt32(reader["Id"]);
                    skill.Name = reader["Name"].ToString();

                    skills.Add(skill);

                }
                reader.Close();
            }
            return View(skills);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Socials()
        {
            List<Socials> socials = new List<Socials>();

            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=MyPortfolio;port=3306;password=erisleci1"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from socials", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Socials social = new Socials();
                    social.Id = Convert.ToInt32(reader["Id"]);
                    social.Name = reader["Name"].ToString();
                    social.URL = reader["URL"].ToString();

                    socials.Add(social);

                }
                reader.Close();
            }
            return View(socials);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}