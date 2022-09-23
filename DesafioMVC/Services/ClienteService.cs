using DesafioMVC.Models;
using DesafioMVC.Repositories;

namespace DesafioMVC.Services
{
    public class ClienteService: IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        public Cliente Create(Cliente cliente) {
           
           if (cliente.Avaliacao== 1)
            {
                cliente.Avaliacao = 1;
            }
            else if(cliente.Avaliacao == 2)
            {
                cliente.Avaliacao = 2;
            }
            else if(cliente.Avaliacao == 3)
            {
                cliente.Avaliacao = 3;
            }
            else if(cliente.Avaliacao == 4)
            {
                cliente.Avaliacao = 4;
            }
            else
            {
                cliente.Avaliacao = 5;
            }
           cliente.Nome = cliente.Nome?.ToUpper();
                return _clienteRepository.Create(cliente);
        }
        public Cliente Edit(Cliente cliente) {
            if (cliente.Avaliacao == 1)
            {
                cliente.Avaliacao = 1;
            }
            else if (cliente.Avaliacao == 2)
            {
                cliente.Avaliacao = 2;
            }
            else if (cliente.Avaliacao == 3)
            {
                cliente.Avaliacao = 3;
            }
            else if (cliente.Avaliacao == 4)
            {
                cliente.Avaliacao = 4;
            }
            else
            {
                cliente.Avaliacao = 5;
            }
            cliente.Nome = cliente.Nome?.ToUpper();
            return _clienteRepository.Update(cliente);
        }
        public Cliente? Find(int? id) { 
            if(id == null)
            {
                return null;
            }
            
            return _clienteRepository.Get(id);

        }
        //listar
        public List<Cliente> GetAll() { 
            return _clienteRepository.GetAll();
        }

   
    }
}
