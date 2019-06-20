using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // GET api/account

        [HttpGet]
        public IActionResult Get(string type)  
        {

            Byte[] b;  
            if(type == null)  
            {  
                return Content("Hi there is no type value given. Please enter picturefromtext or hostedimagefile in type parameter in url");  
            } 
            if (type.Equals("hostedimagefile"))  
            {  
                b = System.IO.File.ReadAllBytes(@"C:\Users\ssoong\Downloads\logo.jpg");  
            }  
            //https://localhost:5001/api/account?type=decodedFile
            else if (type.Equals("decodedFile"))  
            {  
                b = Convert.FromBase64String("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");
            }  
            else  
            {  
                return Content("No action is defined for this type value");  
            }  
            return File(b, "image/jpeg");  
        }

        // POST api/account
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/account/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/account/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
