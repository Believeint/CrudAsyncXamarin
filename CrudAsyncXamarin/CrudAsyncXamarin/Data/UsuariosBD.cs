using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using CrudAsyncXamarin.Model;
using System.Threading.Tasks;

namespace CrudAsyncXamarin.Data
{
    public class UsuariosBD
    {
        readonly SQLiteAsyncConnection _database;

        // Construtor
        public UsuariosBD(string strPath)
        {
            _database = new SQLiteAsyncConnection(strPath);
            _database.CreateTableAsync<Usuario>().Wait();
        }

        // Metodo Get Usuários
        public Task<List<Usuario>> GetUsuarios()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        // Metodo Get Usuario
        public Task<Usuario> GetUsuario(int id)
        {
            return _database.Table<Usuario>()
                            .Where(u => u.Id == id)
                            .FirstOrDefaultAsync();
        }

        // Metodo Incluir Usuário
        public Task<int> IncluirUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }

        // Metodo Excluir Usuário
        public Task<int> ExcluirUsuarioAsync(Usuario usuario)
        {
            return _database.DeleteAsync(usuario);
        }
    }
}
