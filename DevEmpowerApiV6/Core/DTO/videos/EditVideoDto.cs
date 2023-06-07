using System.ComponentModel.DataAnnotations;

namespace DevEmpowerApiV6.Core.DTO.videos;

public class EditVideoDto
{
    [MinLength(4)]
    public string Title { get; set; }
}
