using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.Data;
using System.Data.SqlClient;
using Rumah_Idaman.Models;
using Rumah_Idaman.Data;

namespace Rumah_Idaman.Controllers
{
    public class LocationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _enviroment;

        public LocationController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _enviroment = environment;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Locations.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var lokasi = await _context.Locations
                .SingleOrDefaultAsync(m => m.Id == id);

            if (lokasi == null)
                return NotFound();

            return View(lokasi);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LokasiRumahModel data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(data);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var data = await _context.Locations
                .SingleOrDefaultAsync(m => m.Id == id);

            if (data == null)
                return NotFound();

            return View(data);
        }

        private bool DataExsists(int id) => _context.Locations.Any(e => e.Id == id);

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Type, Longtitude, Latitude")] LokasiRumahModel data)
        {
            if (id != data.Id)
            {
                return NotFound();
            }
                
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(data);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataExsists(data.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var data = await _context.Locations
                .FirstOrDefaultAsync(m => m.Id == id);

            if (data == null)
                return NotFound();

            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var data = await _context.Locations.SingleOrDefaultAsync(m => m.Id == id);
            _context.Locations.Remove(data);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        
        

        //public IActionResult Create()
        //{
        //    string markers = "[";
        //    string CS = ConfigurationManager.ConnectionStrings["DataRumah"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(CS))
        //    {
        //        SqlCommand cmd = new SqlCommand("spGetMap", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        con.Open();
        //        SqlDataReader sdr = cmd.ExecuteReader();

        //        while (sdr.Read())
        //        {
        //            markers += "{";
        //            markers += string.Format("'Id' : '{0}', ", sdr["id"]);
        //            markers += string.Format("'Type' : {0}, ", sdr["Type"]);
        //            markers += string.Format("'Latitude ' : {0}, ", sdr["Latitude"]);
        //            markers += string.Format("'Longtitude ' : {0}, ", sdr["Longtitude"]);
        //            markers += "}, ";
        //        }
        //    }
        //    markers += "];";
        //    ViewBag.Markers = markers;
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(LokasiRumahModel lokasi)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string CS = ConfigurationManager.ConnectionStrings["DataRumah"].ConnectionString;
        //        using (SqlConnection con = new SqlConnection(CS))
        //        {
        //            SqlCommand cmd = new SqlCommand("spAddNewLocation", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@Id", lokasi.Id);
        //            cmd.Parameters.AddWithValue("@Type", lokasi.Type);
        //            cmd.Parameters.AddWithValue("@Latitude", lokasi.Latitude);
        //            cmd.Parameters.AddWithValue("@Longtitude", lokasi.Longtitude);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    else
        //    {

        //    }
        //    return RedirectToAction("Location");
        //}

    }
}