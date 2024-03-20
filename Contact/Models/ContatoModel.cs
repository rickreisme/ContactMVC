using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Contact.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do contato!")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Digite o email do contato!")]
        [EmailAddress(ErrorMessage ="Digite um email válido!")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Digite o celular do contato!")]
        [Phone(ErrorMessage ="Digite um número de celular válido!")]
        public string? Celular { get; set; }
    }
}
