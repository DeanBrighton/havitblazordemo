using System.ComponentModel.DataAnnotations;

namespace EndpointDesignWeb.WebUI.Models
{
    public class TenantViewModel
    {

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tenant Display Name is required.")]
        [MaxLength(50, ErrorMessage = "Maximum length of text is 50 letters.")]
        [MinLength(3, ErrorMessage = "The name needs to be at least 3 characters")]
        public string DisplayName { get; set; } = "";

        [MaxLength(50, ErrorMessage = "Maximum length of text is 50 letters.")]
        public string Description { get; set; } = "";


    }
}
