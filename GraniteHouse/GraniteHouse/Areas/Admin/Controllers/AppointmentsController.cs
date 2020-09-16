using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Models;
using GraniteHouse.Models.ViewModel;
using GraniteHouse.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraniteHouse.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.AdminEndUser + "," + SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private int pageSize = 2;
        public AppointmentsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(int productPage = 1, string searchName=null, string searchEmail=null, string searchNumber=null, string searchDate = null)
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            AppoitmentsViewModel appointmentsVM = new AppoitmentsViewModel()
            //AppointmentsViewModel appointmentVM = new AppointmentsViewModel()
            {
                Appointments = new List<Models.Appointments>()
            };

            StringBuilder param = new StringBuilder();
            param.Append("/Admin/Appointments?productPage=:");
            param.Append("&searchName=");
            if (searchName != null)
            {
                param.Append(searchName);
            }
            param.Append("&searchEmail=");
            if (searchEmail != null)
            {
                param.Append(searchEmail);
            }
            param.Append("&searchPhone=");
            if (searchNumber != null)
            {
                param.Append(searchNumber);
            }
            param.Append("&searchDate=");
            if (searchDate != null)
            {
                param.Append(searchDate);
            }

            appointmentsVM.Appointments = _db.Appointments.Include(a => a.SalesPerson).ToList();
            if (User.IsInRole(SD.AdminEndUser))
            {
                appointmentsVM.Appointments = appointmentsVM.Appointments.Where(a => a.SalesPersonId == claim.Value).ToList();
            }

            if (searchName != null)
            {
                appointmentsVM.Appointments = appointmentsVM.Appointments.Where(a => a.CustomerName.ToLower().Contains(searchName.ToLower())).ToList();
            }

            if (searchEmail != null)
            {
                appointmentsVM.Appointments = appointmentsVM.Appointments.Where(a => a.CustomerEmail.ToLower().Contains(searchEmail.ToLower())).ToList();
            }

            if (searchNumber != null)
            {
                appointmentsVM.Appointments = appointmentsVM.Appointments.Where(a => a.CustomerPhoneNumber.ToLower().Contains(searchNumber.ToLower())).ToList();
            }

            if (searchDate != null)
            {
                try
                {
                    DateTime appDate = Convert.ToDateTime(searchDate);
                    appointmentsVM.Appointments = appointmentsVM.Appointments.Where(a => a.AppointmentDate.ToShortDateString().Equals(appDate.ToShortDateString())).ToList();
                }
                catch (Exception ex)
                {

                    throw;
                }

            }
            var count = appointmentsVM.Appointments.Count;
            appointmentsVM.Appointments = appointmentsVM.Appointments.OrderBy(p => p.AppointmentDate)
            .Skip((productPage - 1) * pageSize)
            .Take(pageSize).ToList();

            appointmentsVM.PaggingInfo = new PaggingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = pageSize,
                TotalItems = count,
                urlParam = param.ToString()
            };


            //System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            //var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            //AppoitmentsViewModel appoitmentsVM = new AppoitmentsViewModel()
            //{
            //    Appointments = new List<Models.Appointments>()
            //};

            //StringBuilder param = new StringBuilder();
            //param.Append("/Admin/Appointments?productPage:");
            //param.Append("&searchName=");
            //if(searchName!=null)
            //{
            //    param.Append(searchName);
            //}
            //param.Append("&searchEmail=");
            //if (searchEmail != null)
            //{
            //    param.Append(searchEmail);
            //}
            //param.Append("&searchNumber=");
            //if (searchNumber != null)
            //{
            //    param.Append(searchNumber);
            //}
            //param.Append("&searchDate=");
            //if (searchDate != null)
            //{
            //    param.Append(searchDate);
            //}


            //appoitmentsVM.Appointments = _db.Appointments.Include(a => a.SalesPerson).ToList();
            //if(User.IsInRole(SD.AdminEndUser))
            //{
            //    appoitmentsVM.Appointments = appoitmentsVM.Appointments.Where(a => a.SalesPersonId == claim.Value).ToList();
            //}
            //if(searchName!=null)
            //{
            //    appoitmentsVM.Appointments = appoitmentsVM.Appointments.Where(a => a.CustomerName.ToLower().Contains(searchName.ToLower())).ToList();
            //}
            //if (searchEmail != null)
            //{
            //    appoitmentsVM.Appointments = appoitmentsVM.Appointments.Where(a => a.CustomerEmail.ToLower().Contains(searchEmail.ToLower())).ToList();
            //}
            //if (searchNumber != null)
            //{
            //    appoitmentsVM.Appointments = appoitmentsVM.Appointments.Where(a => a.CustomerPhoneNumber.ToLower().Contains(searchNumber.ToLower())).ToList();
            //}
            //if (searchDate != null)
            //{
            //    try
            //    {
            //        DateTime appDate = Convert.ToDateTime(searchDate);
            //        appoitmentsVM.Appointments = appoitmentsVM.Appointments.Where(a => a.AppointmentDate.ToShortDateString().Equals(appDate.ToShortDateString())).ToList();
            //    }
            //    catch (Exception ex)
            //    {

            //        throw;
            //    }
            //}

            //var count = appoitmentsVM.Appointments.Count;
            //appoitmentsVM.Appointments = appoitmentsVM.Appointments.OrderBy(p => p.AppointmentDate)
            //    .Skip((productPage - 1) * pageSize)
            //    .Take(pageSize).ToList();

            //appoitmentsVM.PaggingInfo = new PaggingInfo
            //{
            //    CurrentPage = productPage,
            //    ItemsPerPage = pageSize,
            //    TotalItems = count,
            //    urlParam = param.ToString()
            //};
            return View(appointmentsVM);
        }

        // Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productList = (IEnumerable<Products>)(from p in _db.Products
                                                   join a in _db.ProductsSelectedForAppointments
                                                   on p.Id equals a.ProductId
                                                   where a.AppointmentId == id
                                                   select p).Include("ProductTypes");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = _db.Appointments.Include(a => a.SalesPerson).Where(a => a.Id == id).FirstOrDefault(),
                SalesPerson = _db.ApplicationUsers.ToList(),
                Products = productList.ToList()
            };
            return View(objAppointmentVM);
        }

        // Post : Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AppointmentDetailsViewModel objAppointmentVM)
        {
            if(ModelState.IsValid)
            {
                objAppointmentVM.Appointment.AppointmentDate = objAppointmentVM.Appointment.AppointmentDate
                    .AddHours(objAppointmentVM.Appointment.AppointmentTime.Hour)
                    .AddMinutes(objAppointmentVM.Appointment.AppointmentTime.Minute);

                var appointmentFromDb = _db.Appointments.Where(a => a.Id == objAppointmentVM.Appointment.Id).FirstOrDefault();
                appointmentFromDb.CustomerName = objAppointmentVM.Appointment.CustomerName;
                appointmentFromDb.CustomerEmail = objAppointmentVM.Appointment.CustomerEmail;
                appointmentFromDb.CustomerPhoneNumber = objAppointmentVM.Appointment.CustomerPhoneNumber;
                appointmentFromDb.AppointmentDate = objAppointmentVM.Appointment.AppointmentDate;
                appointmentFromDb.isConfirmed = objAppointmentVM.Appointment.isConfirmed;

                if(User.IsInRole(SD.SuperAdminEndUser))
                {
                    appointmentFromDb.SalesPersonId = objAppointmentVM.Appointment.SalesPersonId;
                }
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(objAppointmentVM);
        }

        // Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productList = (IEnumerable<Products>)(from p in _db.Products
                                                      join a in _db.ProductsSelectedForAppointments
                                                      on p.Id equals a.ProductId
                                                      where a.AppointmentId == id
                                                      select p).Include("ProductTypes");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = _db.Appointments.Include(a => a.SalesPerson).Where(a => a.Id == id).FirstOrDefault(),
                SalesPerson = _db.ApplicationUsers.ToList(),
                Products = productList.ToList()
            };
            return View(objAppointmentVM);
        }

        // Get: Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productList = (IEnumerable<Products>)(from p in _db.Products
                                                      join a in _db.ProductsSelectedForAppointments
                                                      on p.Id equals a.ProductId
                                                      where a.AppointmentId == id
                                                      select p).Include("ProductTypes");
            AppointmentDetailsViewModel objAppointmentVM = new AppointmentDetailsViewModel()
            {
                Appointment = _db.Appointments.Include(a => a.SalesPerson).Where(a => a.Id == id).FirstOrDefault(),
                SalesPerson = _db.ApplicationUsers.ToList(),
                Products = productList.ToList()
            };
            return View(objAppointmentVM);
        }

        // Post  : Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int id)
        {
            var appointment = await _db.Appointments.FindAsync(id);
            _db.Appointments.Remove(appointment);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
