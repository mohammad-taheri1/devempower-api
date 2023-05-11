using System.ComponentModel.DataAnnotations;

namespace DevEmpowerApiV6.Core.Dtos.JobCategories;

public class EditJobCategoryDto
{
    [MinLength(2)]
    public string Title { get; set; }
}
