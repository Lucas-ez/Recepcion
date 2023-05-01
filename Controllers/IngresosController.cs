using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recepcion.Data;
using Recepcion.Models;

namespace Recepcion.Controllers
{
	public class IngresosController : Controller
	{
		private readonly RecepcionContext _context;

		//Se declara la base de datos
		public IngresosController(RecepcionContext context)
		{
			_context = context;
		}

		// GET: Ingresos
		public IActionResult Index()
		{
			return _context.Ingreso != null ?
						View(_context.Ingreso.ToList()) :
						Problem("Error en la base de datos");
		}

		// GET: Ingresos/Details/1234
		public IActionResult Details(int? id)
		{
			if (id == null || _context.Ingreso == null)
			{
				return NotFound();
			}

			var ingreso = _context.Ingreso
				.FirstOrDefault(m => m.Id == id);
			if (ingreso == null)
			{
				return NotFound();
			}

			return View(ingreso);
		}

		// GET: Ingresos/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Ingresos/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Id,ClienteDni,ClienteNombre,RoomNumber,CheckInDate,CheckOutDate")] Ingreso ingreso)
		{
			if (ModelState.IsValid)
			{
				_context.Add(ingreso);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(ingreso);
		}

		// GET: Ingresos/Edit/1234
		public IActionResult Edit(int? id)
		{
			if (id == null || _context.Ingreso == null)
			{
				return NotFound();
			}

			var ingreso = _context.Ingreso.Find(id);
			if (ingreso == null)
			{
				return NotFound();
			}
			return View(ingreso);
		}

		// POST: Ingresos/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, [Bind("Id,ClienteDni,ClienteNombre,RoomNumber,CheckInDate,CheckOutDate")] Ingreso ingreso)
		{
			if (id != ingreso.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(ingreso);
					_context.SaveChanges();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!IngresoExists(ingreso.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(ingreso);
		}

		// GET: Ingresos/Delete/1234
		public IActionResult Delete(int? id)
		{
			if (id == null || _context.Ingreso == null)
			{
				return NotFound();
			}

			var ingreso = _context.Ingreso
				.FirstOrDefault(m => m.Id == id);
			if (ingreso == null)
			{
				return NotFound();
			}

			return View(ingreso);
		}

		// POST: Ingresos/Delete/1234
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			if (_context.Ingreso == null)
			{
				return Problem("La entidad es nula");
			}
			var ingreso = _context.Ingreso.Find(id);
			if (ingreso != null)
			{
				_context.Ingreso.Remove(ingreso);
			}

			_context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}

		private bool IngresoExists(int id)
		{
			return (_context.Ingreso?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
