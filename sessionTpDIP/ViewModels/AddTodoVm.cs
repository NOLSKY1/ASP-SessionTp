namespace sessionTpDIP.ViewModels;
using sessionTpDIP.Enums;
using System.ComponentModel.DataAnnotations;

public class AddTodoVm
{
    [Required(ErrorMessage ="The Libelle is required")]
    public string Libelle {  get; set; }
    [Required(ErrorMessage = "The Description is required")]
    public string Description { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateLimite {  get; set; }
    public State State { get; set; }
}
