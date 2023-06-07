using System.ComponentModel.DataAnnotations;

namespace DevEmpowerApiV6.Core.DTO.videos;

public class CreateVideoDto
{
    [MinLength(4)]
    public string Title { get; set; }
}
