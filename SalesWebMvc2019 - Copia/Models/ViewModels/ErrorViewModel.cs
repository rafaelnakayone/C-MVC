using System;

namespace SalesWebMvc2019.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string Request
        
        { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}