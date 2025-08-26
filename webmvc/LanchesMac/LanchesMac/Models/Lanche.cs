using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O nome deve ter no mínimo 10 e no máximo 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição curta do lanche deve ser informada")]
        [MinLength(20, ErrorMessage = "A descrição curta deve ter no mínimo 20 caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição curta deve ter no máximo 200 caracteres")]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informada")]
        [MinLength(20, ErrorMessage = "A descrição detalhada deve ter no mínimo 20 caracteres")]
        [MaxLength(400, ErrorMessage = "A descrição detalhada deve ter no máximo 400 caracteres")]
        [Display(Name = "Descrição detalhada do Lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O preço do lanche deve ser informado")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da Imagem normal")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres.")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres.")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque?")]
        public bool EmEstoque { get; set; }
        // Propriedade de navegação -> Não será criado na tabela
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
