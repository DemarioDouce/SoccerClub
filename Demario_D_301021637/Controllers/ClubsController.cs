using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demario_D_301021637.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demario_D_301021637.Controllers
{
    public class ClubsController : Controller
    {
        public static Clubs GetClubs;
        private IClubsRepository ClubsRepository;
        private IPlayersRepository PlayersRepository;
        
        public ClubsController(IClubsRepository ClubsRepo, IPlayersRepository PlayersRepo)
        {
            ClubsRepository = ClubsRepo;
            PlayersRepository = PlayersRepo;
        }
        public ViewResult List() => View(ClubsRepository.IClubs);

        [HttpGet]
        [Authorize]
        public ViewResult AddClub()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddClub(Clubs club)
        {
            ClubsRepository.SaveClubs(club);
                return RedirectToAction("Clubs");
        }
        public ViewResult Clubs()
        {
            return View(ClubsRepository.IClubs);
        }

        public ViewResult ClubDetails(int ClubId)
        {
            GetClubs = ClubsRepository.IClubs
            .FirstOrDefault(c => c.ClubID == ClubId);
            List<Players> PlayersList = PlayersRepository.IPlayers.Where(p => p.PlayerClub == GetClubs.ClubName).ToList();
            ViewBag.Players = PlayersList;
            return View(GetClubs);
        }

        [Authorize]
        public ViewResult UpdateClub(int ClubId) =>
    View(ClubsRepository.IClubs
        .FirstOrDefault(c => c.ClubID == ClubId));

        [HttpPost]
        [Authorize]
        public IActionResult UpdateClub(Clubs club)
        {
            ClubsRepository.SaveClubs(club);
                return RedirectToAction("Clubs");
        }

        [HttpPost]
        [Authorize]
        public IActionResult DeleteClub(int ClubId)
        {
            Clubs deletedClub = ClubsRepository.DeleteClub(ClubId);
            return RedirectToAction("Clubs");
        }
    }
}