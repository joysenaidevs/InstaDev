
namespace Models
{
    public class Usuario : InstadevBase , IUsuario
    {
        public int IdUsuario { get; set; }  
        public string Nome { get; set; }    
        public string Foto { get; set; }
        public string DataDeNascimento { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }

        private const string PATH = "DataBase/usuario.csv";


        //criamos o método para preparar a linha
        private string Preparar(Usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.Email};{u.UserName};{u.DataDeNascimento};{u.Senha}";
        }


        //Cadastramos 
        //para executar o método implementamos o controller
        public void Cadastrar(Usuario user)
        {
            string [] linha = { Preparar(user) };
            File.AppendAllLines(PATH , linha);
        }

    }
}