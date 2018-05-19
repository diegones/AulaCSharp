using Aula0518_Camadas.Controlers;
using Aula0518_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0518_Camadas.Views
{
    class AtividadesView

        
    {
        AtividadesController ac = new AtividadesController();
        public void ExibirMenu()

        {
            int opcao = 6;
            do
            {

                Console.WriteLine("=============================");
                Console.WriteLine("= 1) Cadastrar Atividade");
                Console.WriteLine("= 2) Listar Atividade");
                Console.WriteLine("= 3) Editar Atividade");
                Console.WriteLine("= 4) Excluir Atividade");
                Console.WriteLine("= 6) --- Sair ---");
                Console.WriteLine("=============================");

                Console.Write("Digite sua opcao: ");
                opcao = int.Parse(Console.ReadLine()); //converte string para inteiro

                switch (opcao)
                {
                    case 1:
                        CadastrarAtividade();

                        break;

                    case 2:
                        ExibiAtividadesCadastradas();

                        break;

                    case 3:
                        EditarAtividadeCadastrada();

                        break;

                    default:
                        break;
                }

            } while (opcao != 6);
        }

        private void EditarAtividadeCadastrada()
        {
            ExibiAtividadesCadastradas();

            Atividade atividade = new Atividade();
            Console.Write("Digite o id da atividade que deseja alterar: ");
            atividade.AtividadeID = int.Parse(Console.ReadLine());

            Console.Write("Digite o novo nome: ");
            atividade.Nome = Console.ReadLine();

            Console.Write("Ativo? (s/n)");
            atividade.Ativo = Console.ReadLine() == "s" ? true : false;

            ac.Editar(atividade);
          


        }

        private void ExibiAtividadesCadastradas()
        {
            Console.WriteLine("-- Exibindo atividades cadastradas --");
            foreach (Atividade a in ac.Listar())
            {
                Console.WriteLine(" Id: " + a.AtividadeID);
                Console.WriteLine(" Nome: " + a.Nome);
                Console.WriteLine(" Ativo: " + a.Ativo);
                Console.WriteLine("--");
            }
            Console.WriteLine("-- Fim da Lista -- ");
        }

        private void CadastrarAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();
            atividade.Ativo = true;


            ac.Salvar(atividade);
        }
    }
}
