using System.ComponentModel.DataAnnotations;

namespace DevEmpowerApiV6.Core.Dtos.videos;

public class EditVideoDto
{
    [MinLength(4)]
    public string Title { get; set; }
}
