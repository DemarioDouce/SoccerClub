using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demario_D_301021637.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demario_D_301021637.Controllers
{
    public class PlayersController : Controller
    {
        private IPlayersRepository PlayersRepository;
        public PlayersController(IPlayersRepository repo)
        {
            PlayersRepository = repo;
        }
        public ViewResult List() => View(PlayersRepository.IPlayers);

        public ViewResult ManagePlayers()
        {
            return View(PlayersRepository.IPlayers);
        }

        [Authorize]
        public ViewResult AddPlayers(int PlayerId) =>
            View(PlayersRepository.IPlayers
            .FirstOrDefault(c => c.PlayerID == PlayerId));

        [HttpPost]
        [Authorize]
        public IActionResult AddPlayers(Players player)
        {
            PlayersRepository.SavePlayers(player);
            return RedirectToAction("ManagePlayers");
        }

        [Authorize]
        public ViewResult ReassignPlayer(int PlayerId) =>
        View(PlayersRepository.IPlayers
        .FirstOrDefault(p => p.PlayerID == PlayerId));

        [HttpPost]
        [Authorize]
        public IActionResult ReassignPlayer(Players player)
        {
            PlayersRepository.SavePlayers(player);
            return RedirectToAction("ManagePlayers");
        }

        [HttpPost]
        [Authorize]
        public IActionResult DeletePlayer(int PlayerId)
        {
            Players deletePlayer = PlayersRepository.DeletePlayer(PlayerId);
            return RedirectToAction("ManagePlayers");
        }

    }
}