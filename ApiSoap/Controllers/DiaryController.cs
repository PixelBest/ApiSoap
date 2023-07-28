using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiSoap.Controllers
{
    [ApiController]
    [Route("api/diary")]
    public class DiaryController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(byte[] soapFile)
        {
            /*SoapFormatter formatter = new SoapFormatter();

            using (FileStream fs = new FileStream("SoapPacket.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, soapFile);
            }*/
            using (FileStream fs = System.IO.File.Create(@"C:\Проекты Visual Studion\ApiSoap\ApiSoap\test.xml"))
            {
                await fs.WriteAsync(soapFile, 0, soapFile.Length);
            }
            return Ok();
        }
    }
}
