using System.ComponentModel.DataAnnotations;

namespace DevEmpowerApiV6.Core.Entities
{
    public class VideoEntity : BaseEntity
    {

        public string Url { get; set; }

        public string Title { get; set; }
    }
}
