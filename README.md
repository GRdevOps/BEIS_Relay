# BEIS_Relay

This program is a simple .Net Core ASP web application that is used to capture BEIS messages, translate them to JSON, and send them to rabbitMQ

Some assembly is required (Developer jokes the only thing better than Dad jokes)
- You will start by updating three classes
	1. You should start with the Envelope class.  This class is what models your XML from BEIS and is very ugly code, but .Net can scaffold it for you.  Follow the link to see how to automagically model your class using Visual Studio https://dailydotnettips.com/did-you-know-you-can-automatically-create-classes-from-json-or-xml-in-visual-studio/
	2. Next you will need to update the BannerUser class.  This class is what defines your user as a .Net Object and ultimately stores it in the Payload field of the JSON object.  You will need to first define the fields that you will want as attributes and then map those fields inside of the class constructor.
	3. Lastly you will need to update the JSON_Message class.  This class is ultimately what the object will look like when it's sent to rabbitMQ.  The payload field will include the BannerUser object but any additional attributes you want sent to rabbitMQ will be defined here
- At this point you will need to build and setup the application on whatever server you prefer.  I personally deploy it on Linux and put it behind Apache but .Net Core is extremely flexible.  If you need a quick tutorial on using .Net Core ASP check out this link https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-apache?view=aspnetcore-3.1
- Lastly, you will want to update your config file, this will be named "rabbitMQConfig.json" with the appropriate rabbitMQ config information.  This is pulled in when the application launches so any changes to the config require a simple restart of the application (not a rebuild)
- To send BEIS messages you will need to point them to:
	http(s)://{server}:{port}/api/default
- If you have a deployment process already that is fantastic if you do not then my recommendation is do not overthink it.  Build locally on your machine and winsrp it to the server, setup a service object to ensure it survives restarts and move on.