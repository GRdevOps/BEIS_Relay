using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace BEIS_message_relay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public IConfiguration Configuration { get; set; }

        public DefaultController(IConfiguration config)
        {
            Configuration = config;
        }

        [HttpPost]
        public String Post()
        {
        // XMLModel is a custom class created by Visual Studio from an XML Document
        XMLModel myObject;

            // Convert incoming XML into an XMLModel object
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var mySerializer = new XmlSerializer(typeof(XMLModel));

                myObject = (XMLModel)mySerializer.Deserialize(reader);
            }
            
            var user = JsonConvert.SerializeObject(new JSON_Message(new BannerUser(myObject)));

            // Not sure how to handle these yet or if they are needed ??
            //var psoID = myObject.Body.modifyRequest.psoID;
            //var modificationMode = myObject.Body.modifyRequest.modification.modificationMode;
            //var UDCIdentityAction = myObject.Body.modifyRequest.modification.data.UDCIdentity.action;
            
            var factoryOut = new ConnectionFactory();

            factoryOut.UserName = Configuration["rabbitMQUser"];
            factoryOut.Password = Configuration["rabbitMQUserPassword"];
            factoryOut.VirtualHost = Configuration["rabbitMQVirtualHost"];
            factoryOut.Port = int.Parse(Configuration["rabbitMQPort"]);
            factoryOut.HostName = Configuration["rabbitMQHost"];

            using (var connection = factoryOut.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var body = Encoding.UTF8.GetBytes(user);

                    channel.BasicPublish(exchange: Configuration["rabbitMQExchange"],
                                         routingKey: Configuration["rabbitMQRoutingKey"],
                                         basicProperties: null,
                                         body: body);
                }
            }
            

            //HttpResponseMessage response = new HttpResponseMessage();

            //response.StatusCode = System.Net.HttpStatusCode.OK;
            //response.ReasonPhrase = $"{user.UDCIdentifier} ({user.CN}) accepted";

            return user;
        }
    }
}