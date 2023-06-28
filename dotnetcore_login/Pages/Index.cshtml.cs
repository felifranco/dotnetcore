using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_login.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    
    [BindProperty]
    public Credential credential { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        this.credential = new Credential {User = ""};

    }

    public void OnPost()
    {
        if (!ModelState.IsValid) return;

        if(credential.User == "admin" && credential.Password == "123")
        {
            //Login OK
            Console.WriteLine("Login OK");
        }

    }

    public class Credential 
    {
        [Required(ErrorMessage = "Usuario requerido")]
        [Display(Name = "Usuario")]
        public string User {get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password {get; set; }
    }

}
