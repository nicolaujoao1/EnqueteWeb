namespace Projecto01.Models
{
    public static class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();  
        public static IEnumerable<Resposta> Respostas
        {
            get { return respostas; }    
        } 
        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }
        static Repositorio()
        {
            respostas.Add(new Resposta { Nome = "Ilola Nicolau", Email = "ilola@gmail.com", Sim=true});
            respostas.Add(new Resposta { Nome = "Pedro Daniel", Email = "pedro@gmail.com", Sim = false });
            respostas.Add(new Resposta { Nome = "Isaque Silva", Email = "isaque@gmail.com", Sim = true });
            respostas.Add(new Resposta { Nome = "Israel Santos", Email = "israel@gmail.com", Sim = false });
        }
    }
}
