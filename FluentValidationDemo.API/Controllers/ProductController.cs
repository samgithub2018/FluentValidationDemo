using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidationDemo.API.Models;
using FluentValidationDemo.API.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemo.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "香蕉",
                Price = 15,
                ProductType = "水果",
                PlaceOfOrigin = new Adress()
                {
                    City = "曼谷",
                    Country = "泰国",
                    Id = 1
                }
            };

            return Newtonsoft.Json.JsonConvert.SerializeObject(product);
        }

        [HttpPost]
        public string SaveProduct(Product product)
        {
            ProductValidator validationRules = new ProductValidator();
            var validationResult = validationRules.ValidateAsync(product).Result;
            if (!validationResult.IsValid)
            {
                return string.Join("\r\n", validationResult.Errors.Select(s => s.ErrorMessage));
            }
            return "保存成功！";
        }


    }
}
