namespace WebAssemby_PickingByVoice.Models
{
    public class UnidadeCompra
    {
        public string Codigo { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }

}

