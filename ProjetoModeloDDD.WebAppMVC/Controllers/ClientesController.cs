using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.WebAppMVC.ViewModels;

namespace ProjetoModeloDDD.WebAppMVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IEFCoreRepository<Cliente> _repo;
        private readonly IClienteRepository _clienteRepo;
        private readonly IMapper _mapper;

        public ClientesController(IClienteRepository clienteRepo, IEFCoreRepository<Cliente> repo, IMapper mapper)
        {
            _clienteRepo = clienteRepo;
            _repo = repo;
            _mapper = mapper;
        }

        // GET: ClientesController
        public async Task<IActionResult> Index()
        {
            var objList = await _clienteRepo.GetAllClientes();
            var objVM = new List<ClienteViewModel>();
            foreach (var obj in objList)
            {
                objVM.Add(_mapper.Map<ClienteViewModel>(obj));
            }

            return View(objVM);
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            var obj = _clienteRepo.GetClienteById(id).Result;
            if (obj != null)
            {
                var objVM = _mapper.Map<ClienteViewModel>(obj);

                return View(objVM);
            }
            else
            {
                return BadRequest($"Something went wrong when recovering the record");
            }
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody] ClienteViewModel clienteVM)
        {
            if (ModelState.IsValid)
            {
                var clienteObj = _mapper.Map<Cliente>(clienteVM);
                _repo.Add(clienteObj);

                return RedirectToAction(nameof(Index));
            }

            return View(clienteVM);
        }


        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
