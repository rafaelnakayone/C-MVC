using System;


namespace SalesWebMvc2019.Services.Exceptions
{
    public class DBConcurrencyException : ApplicationException
    {
        public DBConcurrencyException(string message) : base(message)
        {

        }
    }
}
