using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace CrudAsyncXamarin.Model
{
    public class Usuario
    {

        #region "Propriedades"
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public DateTime DataCadastro { get; set; }
        #endregion
    }
}
