using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;  
using System.Linq;  
using System.Net.Mail;  
using System.Web;
using BucOverflow.Models;
namespace BucOverflow.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {  
        return View();  
    } 

    //Email verification that would send email to user 
	[HttpPost]  
    public IActionResult Index(MailModel email)
    {  
 
        MailMessage mail = new MailMessage();  
        mail.To.Add(email.To);
        mail.From = new MailAddress("bucoverflow@outlook.com");
        mail.Subject = email.Subject;  
        string Body = email.Body;  
        mail.Body = Body;  
        mail.IsBodyHtml = true;  
        SmtpClient smtp = new SmtpClient();  
        smtp.Host = "smtp.office365.com";  
        smtp.Port = 587;  
        smtp.UseDefaultCredentials = false;  
        smtp.Credentials = new System.Net.NetworkCredential("bucoverflow@outlook.com", "AgileScrum123"); // Enter senders User name and password  
        smtp.EnableSsl = true;  
        smtp.Send(mail);  
        return View("Index", email);  
	}
}
