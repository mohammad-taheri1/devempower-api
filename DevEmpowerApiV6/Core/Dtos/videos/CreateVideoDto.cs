using System.ComponentModel.DataAnnotations;

namespace DevEmpowerApiV6.Core.Dtos
{
    public class CreateVideoDto
    {
        [MinLength(4)]
        public string Title { get; set; }
    }
}
