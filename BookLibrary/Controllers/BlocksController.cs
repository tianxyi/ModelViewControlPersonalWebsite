using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Models;

using System.Diagnostics;

using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore.Extensions;
using Microsoft.AspNetCore.Authorization;
using BookLibrary.Data;//???
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace BookLibrary.Controllers
{
  [Authorize(Roles = "User, Admin")]
  public class BlocksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private const string sessionId_ = "SessionId";

        public BlocksController(ApplicationDbContext context)
        {
            _context = context;
        }

    // GET: Books
    public IActionResult Home()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    public IActionResult Index()
        {
            return View(_context.Blocks.ToList<Block>());
        }


    [HttpGet]
    public IActionResult Records()
        {
            // fluent API
            var recs = _context.Records.Include(c => c.Block);
            var orderedRecs = recs.OrderByDescending(c =>c.Time)//order by title first sort 
              .OrderBy(c=>c.Block)//order by cousrse second sort 
              .Select(c => c);
            return View(orderedRecs);
            //return View(_context.Records.ToList<Record>());
        }

    // GET: Books/Create
    [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateBlock(int id)
        {
            var model = new Block();
            return View(model);
        }


        // POST: Books/Create

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreateBlock(int id, Block block)
        {

            _context.Blocks.Add(block);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    //vise delete view!
    
    public IActionResult DeleteBlock(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }
     
        var block = _context.Blocks.Find(id);
        if (block == null)
        {
        return NotFound();
      }
  
      return View(block);

    } 

    [HttpPost, ActionName("DeleteBlock")]
    [ValidateAntiForgeryToken]

    public IActionResult DeleteConfirmed(int id) {
      var block = _context.Blocks.Find(id);
      try
      {
        _context.Remove(block);
        _context.SaveChanges();
      }
      catch { return NotFound(); }
      
      return RedirectToAction("Index");
    }

    //public IActionResult DeleteBook(int? id)
    //{
    //    if (id == null)
    //    {
    //        return NotFound();
    //    }
    //    try
    //    {
    //        var block = _context.Blocks.Find(id);
    //        if (block != null)
    //        {
    //            _context.Remove(block);
    //            _context.SaveChanges();
    //        }
    //    }
    //    catch (Exception)
    //    {

    //    }
    //    return RedirectToAction("Index");

    //}

    // GET: Books/Details/5
    public ActionResult BlockDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
      Block block = _context.Blocks.Find(id);

            if (block == null)
            {
                return NotFound();
            }
            var recs = _context.Records.Where(c => c.Block == block);
            block.Records=recs.OrderBy(l => l.Time).Select(l => l).ToList<Record>();
            if (block.Records == null)
            {
                block.Records = new List<Record>();
                Record rec = new Record();
                rec.Comment = "null";
                rec.Name = "null";
        
                //rec.Time = DateTime.Now;
                block.Records.Add(rec);
            }


            return View(block);
        }

      

        // GET: Books/Edit/5
        [HttpGet]
        public IActionResult EditBlock(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

      Block block = _context.Blocks.Find(id);
            if (block == null)
            {
                return NotFound();
            }
            return View(block);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult EditBlock(int? id, Block bok)
        {
            if (id == null)
            {
                return NotFound();
            }
            var block = _context.Blocks.Find(id);
            if (block!=null)
            {
                block.Title = bok.Title;
                block.Text = bok.Text;
        block.Diagram = bok.Diagram;
        block.Photo = bok.Photo;
        block.Genre = bok.Genre;
                try
                {
                    _context.SaveChanges();
                   
                }
                catch (Exception)
                {

                }
               
            }
            return RedirectToAction("Index");
        }



    //// GET: Comments/Create

    //[HttpGet]
    //[Authorize(Roles = "User, Admin")]
    //public IActionResult CreateRecord(int id)
    //    {
    //        var model = new Record();
    // // model.Time = DateTime.Now;
    //        return View(model);
    //    }

    //// POST:Comments/Create

    //[HttpPost]

    //public IActionResult CreateRecord(int id ,Record rec)
    //    {
    //        _context.Records.Add(rec);
    //        _context.SaveChanges();
    //        return RedirectToAction("Records");
    //    }

    // GET: Comments/Create Add new comment to Topic
    [HttpGet]
    [Authorize(Roles = "User, Admin")]
    public IActionResult AddRecord(int id)
        {
            HttpContext.Session.SetInt32(sessionId_, id);//session service. book id store id to session

      Block block = _context.Blocks.Find(id);
            if(block == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);

            }
            Record rec = new Record();
            return View(rec);
        }
    // POST: Comments/Create Add new comment to Topic
 
    //[Authorize(Roles = "User")]
    [HttpPost]
    
    public IActionResult AddRecord(int? id,Record rec)
        {
            if(id == null)//id -record id
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

            int? blockId_ = HttpContext.Session.GetInt32(sessionId_);

            var block = _context.Blocks.Find(blockId_);

            if (block != null)
            {
                if (block.Records == null)
                {
                    List<Record> records = new List<Record>();
                    block.Records = records;
                }
        rec.Name = User.Identity.Name;////////////////////
                block.Records.Add(rec);

                try
                {
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    
                }
                
            }
      //return RedirectToAction("Index");
      return RedirectToAction("BlockDetails",new { id=blockId_});
        }
    //----< gets form to edit a specific lecture via id >---------
    // GET: Comments/Edit 
    [HttpGet]
        public IActionResult EditRecord(int? id)
        {
            if (id == null)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }
            Record record = _context.Records.Find(id);

            if (record == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(record);
        }

    //----< posts back edited results for specific lecture >------
    // POST: Comments/Edit 
    [HttpPost]
        public IActionResult EditRecord(int? id, Record rec)// edit id          rec-new record
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var record= _context.Records.Find(id);

            if (record != null)
            {
                record.Comment = rec.Comment;
                record.Time = rec.Time;

                try
                {
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Records");
        }

    // DELETE: Comments/Delete 
    //vise delete view!//vise delete view!

    //[HttpGet]
    //public IActionResult DeleteRecord(int? id)
    //{
    //  if (id == null)
    //  {
    //    return StatusCode(StatusCodes.Status400BadRequest);
    //  }

    //    var record = _context.Records.Find(id);
    //    if (record == null)
    //    {
    //      return StatusCode(StatusCodes.Status400BadRequest);
    //    }

    //  return View(record);
    //}


    
    public IActionResult DeleteRecord(int? id)
    {
      if (id == null)
      {
        return StatusCode(StatusCodes.Status400BadRequest);
      }
      
        var record = _context.Records.Find(id);
        if (record == null)
        {
        return StatusCode(StatusCodes.Status400BadRequest);
        //_context.Remove(record);
        //  _context.SaveChanges();
        }
      
     return View(record);
        // nothing for now
      }

    [HttpPost, ActionName("DeleteRecord")]
    [ValidateAntiForgeryToken]

    public IActionResult DeleteConfirmed2(int id)
    {
      var record = _context.Records.Find(id);

      _context.Remove(record);
      _context.SaveChanges();



      return RedirectToAction("Records");
      
    }

   }
}
