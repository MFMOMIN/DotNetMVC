using DealDouble.Entities;
using DealDouble.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DealDouble.Web.Controllers
{
    public class AuctionsController : Controller
    {
        // GET: Auctions
        public ActionResult Index()
        {
            AuctionsService service = new AuctionsService();
            var auctions = service.GetAllAuction();
            return View(auctions);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            AuctionsService service = new AuctionsService();

            service.SaveAuction(auction);

            return View();
        }

        // GET: Auctions
        public ActionResult Edit(int ID)
        {
            AuctionsService service = new AuctionsService();

            var auction =  service.GetAuctionByID(ID);

            return View(auction);
        }

        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            AuctionsService service = new AuctionsService();

            service.UpdateAuction(auction);

            return View(auction);
        }
    }
}