﻿using HotelProject.BusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		private readonly IServiceService _serviceService;

		public ServicesController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		[HttpGet]
		public IActionResult ServiceList()
		{
			var values = _serviceService.TGetList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddService(Service service)
		{
			_serviceService.TInsert(service);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteService(int id)
		{
			var values = _serviceService.TGetById(id);
			_serviceService.TDelete(values);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateService(Service service)
		{
			_serviceService.TUpdate(service);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetService(int id)
		{
			var values = _serviceService.TGetById(id);
			return Ok(values);
		}
	}
}