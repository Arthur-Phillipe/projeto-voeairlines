namespace VoeAirlines.Entities;

public class Piloto
{
    public Piloto(string nome, string matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }
    // public string Breve { get; set; }  COMENTÁRIO: PARA incluir precisa atualizar as demais partes do código
    public ICollection<Voo> Voos { get; set; } = null!;
}