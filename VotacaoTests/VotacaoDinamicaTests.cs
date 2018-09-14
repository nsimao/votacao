using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Votacao.Model;

namespace Votacao.Tests
{
    [TestClass()]
    public class VotacaoDinamicaTests
    {
        [TestMethod()]
        public void GerarVotos()
        {
            ApplicationCore appCore = new ApplicationCore();

            appCore.ExcluirVotos();

            int qtdSalas = 4;
            Random randomNumeroAlunos = new Random();

            for (int i = 1; i <= qtdSalas; i++)
            {
                Random randomCandidato = new Random();
                Random randomSexo = new Random();
                int numeroAlunos = randomNumeroAlunos.Next(20, 50);
                int qtdCandidatos = appCore.GetQtdCandidatos();
                int qtdCandidatosForRandom = appCore.GetQtdCandidatos();

                for (int j = 1; j <= numeroAlunos; j++)
                {
                    int indexCandidato = randomCandidato.Next(0, qtdCandidatosForRandom);
                    int indexSexo = randomSexo.Next(0, 20);

                    Candidato candidato = null;

                    if (indexCandidato > qtdCandidatos - 1)
                    {
                        candidato = appCore.GetCandidato(UrnaConstantes.VOTO_NULO);
                    }
                    else
                    {
                        candidato = appCore.Candidatos[indexCandidato];
                    }

                    string sexo = "F";

                    if (indexSexo % 2 == 0)
                        sexo = "M";

                    appCore.ComputarVoto(i.ToString(), sexo, candidato.Partido);
                }
            }

            Assert.IsTrue(true);
        }
    }
}