﻿using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Request;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public ActionResult Register([FromBody] RequestRegisterExpenseJson request)
        {
            var useCase = new RegisterExpenseUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
    }
}
