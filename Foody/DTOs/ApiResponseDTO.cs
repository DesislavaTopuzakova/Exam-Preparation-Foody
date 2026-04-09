using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Foody.Tests.DTOs
{
    internal class ApiResponseDTO
    {
        [JsonPropertyName("msg")]
        public string Msg { get; set; }
            
        [JsonPropertyName("foodId")]
        public string FoodId { get; set; }
    }
}
