using System;
using System.Collections.Generic;
using System.Text;

namespace GismeteoTest.Shared.ResponseModel
{
    public class CitiesResponse
    {
        public ErrorResponse Error { get; set; }

        public List<string> Cities { get; set; }
    }
}
