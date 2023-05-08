using System.ComponentModel.DataAnnotations;

namespace devempower_api.Core.Dtos
{
    public class CreateVideoDto
    {
        [MinLength(5)]
        public string Title { get; set; }
    }
}
