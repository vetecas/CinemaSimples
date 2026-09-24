using CinemaDomain;
using System.Diagnostics;
using System.Text.Json;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using static System.Net.WebRequestMethods;

namespace CinemaTest
{
    [TestClass]
    public sealed class TestCinemaDomain
    {
        private JsonSerializerOptions OptionsJson()
        {
            return new JsonSerializerOptions {WriteIndented = true };
        }

        [TestMethod]
        public void TestGenero()
        {
            var genero = new Genero { Id = 1, Nome = "Suspense" };

            var generoJson = JsonSerializer.Serialize(genero,OptionsJson());
            Debug.WriteLine(generoJson);
            Assert.IsNotNull(generoJson);
        }

        [TestMethod]
        public void TestFilme()
        {
            var genero1 = new Genero { Id = 1, Nome = "Suspense" };
            var genero2 = new Genero { Id = 2, Nome = "Comedia" };
            var filme = new Filme { Id = 1, Nome = "Jurassic Park", Genero = genero1, Classificacao = "18+", Duracao = 120 };

            var filmeJson = JsonSerializer.Serialize(filme,OptionsJson());
            Debug.WriteLine(filmeJson);
            Assert.IsNotNull(filmeJson);

        }

        [TestMethod]
        public void TestSala()
        {
            var sala = new Sala { Id = 1, Assentos = 1, Capacidade = 30, Fileiras = "A", Numero = 1 };
        }

        [TestMethod]
        public void TestSessao()
        {
            var genero1 = new Genero { Id = 1, Nome = "Suspense" };
            var filme = new Filme { Id = 1, Nome = "Jurassic Park", Genero = genero1, Classificacao = "18+", Duracao = 120 };
            var sala = new Sala { Id = 1, Assentos = 1, Capacidade = 30, Fileiras = "A", Numero = 1 };
            var sessao = new Sessao { Id = 1, Data = new DateTime(2026,10,1,19,20,00), Preco = 30.55m, Filme = filme, Sala = sala };

            
            var sessaoJson = JsonSerializer.Serialize(sessao, OptionsJson());
            Debug.WriteLine(sessaoJson);
            Assert.IsNotNull(sessaoJson);
        }
       

        [TestMethod]
        public void TestIngresso()
        {

            var genero1 = new Genero { Id = 1, Nome = "Suspense" };
            var filme = new Filme { Id = 1, Nome = "Jurassic Park", Genero = genero1, Classificacao = "18+", Duracao = 120 };
            var sala = new Sala { Id = 1, Assentos = 1, Capacidade = 30, Fileiras = "A", Numero = 1 };
            var sessao = new Sessao { Id = 1, Data = new DateTime(2026, 10, 1, 19, 20, 00), Preco = 30.55m, Filme = filme, Sala = sala };
            var ingresso = new Ingresso { Id = 1, DataCompra = new DateTime(2026, 10, 1, 19, 20, 00), Documento = "111.111.111.11", FormaPagamento = "cartao", Secao = sessao, IngressoItens = [] };

            ingresso.IngressoItens.Add(new IngressoItem { Id = 1, Assento = 1, Fileira = "A", MeiaEntrada = false });
            ingresso.IngressoItens.Add(new IngressoItem { Id = 2, Assento = 2, Fileira = "A", MeiaEntrada = false });

            var ingressoJson = JsonSerializer.Serialize(ingresso, OptionsJson());
            Debug.WriteLine(ingressoJson);
            Assert.IsNotNull(ingressoJson);
        }
    }
}
