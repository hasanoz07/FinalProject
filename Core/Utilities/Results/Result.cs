using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        private bool v1;
        private string v2;
        //do not your repeat
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success {get;}

        public string Message {get;}
    }
}
