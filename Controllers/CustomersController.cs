using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.ViewModels;


namespace MovieRental.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            /*var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);*/

            return View();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        public ActionResult Form()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerViewModel
            {
                customer=new Customer(),
                MembershipTypes = membershipTypes
            };
            return View(viewModel);

        }
        public ActionResult Edit(int id)
        {
            var customer1 = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer1 == null)
                return HttpNotFound();
            var viewModel = new CustomerViewModel
            {
                customer = customer1,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("Form",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addOrEdit(Customer customer)
        {
            if (!ModelState.IsValid)
            {
              
                var viewmodel = new CustomerViewModel
                {
                    customer = customer,
                    MembershipTypes=_context.MembershipTypes.ToList()
                    
                };
                return View("Form", viewmodel);
            }
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthdayDate = customer.BirthdayDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index","Customers");
        }
    }
}