/*
Carlos Felipe
10/27/22
Reverse It - Endpoint
CODE: This code prints out the inputted phrase but starting with the last char and ending with the first (The reverse)
Peer review by : Arely Martinez -- Carlos code looks neat and the program works accordingly. Might want to add more in the return so the user knows whats going on though like adding the original output aswell. Overall lopoks good. 
*/

using Microsoft.AspNetCore.Mvc;

namespace FelipeCReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EnterStringController : ControllerBase
{
   [HttpGet]
   [Route("{phrase}")]
   public string Reverse(string phrase){
    string reversed = "";
    for(int i = phrase.Length; i > 0; i--){
        reversed += phrase[i-1]; 
    }
    return reversed;
   }
  
}
