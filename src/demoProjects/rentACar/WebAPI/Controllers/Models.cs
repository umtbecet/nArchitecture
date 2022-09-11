﻿using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListModel;
using Core.Application.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Models : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new GetListModelQuery { PageRequest = pageRequest };
            ModelListModel result = await Mediator.Send(getListModelQuery);
            return Ok(result);
        }

    }
}
