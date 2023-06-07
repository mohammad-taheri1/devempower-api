using System.ComponentModel.DataAnnotations;

namespace DevEmpowerApiV6.Core.DTO.JobCategories;

public class CreateJobCategoryDto
{
    [MinLength(2)]
    public string Title { get; set; }
}