using Aula0518_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0518_Camadas.Controlers
{
    class AtividadesController
    {
        List<Atividade> minhasAtividades = new List<Atividade>();


        //salvar
        public void Salvar(Atividade atividade)
        {
            minhasAtividades.Add(atividade);
        }
        //listar
        public List<Atividade> Listar()
        {
            return minhasAtividades;
        }
        //editar
        public void Editar(Atividade atividadeAtualizada)
        {
            foreach (Atividade a in minhasAtividades)
            {
                if (a.AtividadeID == atividadeAtualizada.AtividadeID)
                {
                    a.Nome = atividadeAtualizada.Nome;
                    a.Ativo = atividadeAtualizada.Ativo;
                }
            }
        }
        //excluir
        public void Excluir(Atividade atividade)
        {
            minhasAtividades.Remove(atividade);
        }

    }

}
