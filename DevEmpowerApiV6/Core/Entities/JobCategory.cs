using System.ComponentModel.DataAnnotations;

namespace DevEmpowerApiV6.Core.Entities;

public class JobCategory : BaseEntity
{
    [MinLength(2)]
    public string Title { get; set; }
}
