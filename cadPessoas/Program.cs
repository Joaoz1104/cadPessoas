using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadPessoas
{
    public static class pessoas
    {
        public struct dados
        {
            public string nome;
            public string DDD;
            public string telefone;
            public string email;
            public string nomeMae;
            public string nomePai;
            public string obs;
            public string endereco;
        }

        public static string menu()
        {
            Console.Clear();
            Console.WriteLine("########    MENU    ########");
            Console.WriteLine("#                          #");
            Console.WriteLine("# INSERIR            < 1 > #");
            Console.WriteLine("# LISTAR             < 2 > #");
            Console.WriteLine("# QUANTIDADE         < 3 > #");
            Console.WriteLine("# BUSCAR             < 4 > #");
            Console.WriteLine("# SAIR               < 9 > #");
            Console.WriteLine("#                          #");
            Console.WriteLine("############################");
            return (   Console.ReadLine()   );
        }

        public static pessoas.dados receberDados()
        {
            pessoas.dados umaPessoa;

            Console.Clear();
            Console.WriteLine("RECEBENDO DADOS DE PESSOAS");

            Console.WriteLine("Digite o nome da pessoa");
            umaPessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite o DDD da pessoa");
            umaPessoa.DDD = Console.ReadLine();

            Console.WriteLine("Digite o telefone da pessoa");
            umaPessoa.telefone = Console.ReadLine();

            Console.WriteLine("Informe seu e-mail");
            umaPessoa.email = Console.ReadLine();

            Console.WriteLine("Informe o nome de sua mãe");
            umaPessoa.nomeMae = Console.ReadLine();

            Console.WriteLine("Informe o nome de seu pai");
            umaPessoa.nomePai = Console.ReadLine();

            Console.WriteLine("Informe suas obbservações");
            umaPessoa.obs = Console.ReadLine();

            Console.WriteLine("Informe seu endereço");
            umaPessoa.endereco = Console.ReadLine();

            return (   umaPessoa   );
        }

        public static void listarDados(List<pessoas.dados> listaRecebida)
        {
            Console.Clear();
            Console.WriteLine("DADOS DA LISTA");
            foreach (pessoas.dados umaPessoa in listaRecebida)
            {
                Console.WriteLine("nome da pessoa    : " + umaPessoa.nome);
                Console.WriteLine("DDD               : " + umaPessoa.DDD);
                Console.WriteLine("Telefone          : " + umaPessoa.telefone);
                Console.WriteLine("E-Mail            : " + umaPessoa.email);
                Console.WriteLine("Nome da mãe       : " + umaPessoa.nomeMae);
                Console.WriteLine("Nome do pai       : " + umaPessoa.nomePai);
                Console.WriteLine("Comentário        : " + umaPessoa.obs);
                Console.WriteLine("Endereço          : " + umaPessoa.endereco);
            }
            Console.ReadKey();
        }

        public static void contaRegistros( List<pessoas.dados> listaRecebida)
        {
            Console.Clear();
            Console.WriteLine("QUANTIDADE DE REGISTROS EFETUADOS");

            Console.WriteLine("Registros: " + listaRecebida.Count());
            Console.ReadKey();
        }
        public static void buscaDados( List<pessoas.dados> listaRecebida )
        {
            Console.Clear();
            Console.WriteLine("BUSCAR DADOS");

            Console.WriteLine("Informe o nome para a busca");
            string buscar = Console.ReadLine();

            Console.WriteLine("Nome encontrado: " + listaRecebida.Contains(buscar));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string ocp = "";
            List<pessoas.dados> listaPessoa = new List<pessoas.dados>();

            while (ocp != "9")
            {
                ocp = pessoas.menu();
                switch (ocp)
                {
                    case "1":
                        listaPessoa.Add(pessoas.receberDados());
                        break;

                    case "2":
                        listaPessoa.Add(pessoas.listarDados());
                        break;

                    case "3":
                        listaPessoa.Add(pessoas.contaRegistros());
                        break;

                    case "4":
                        listaPessoa.Add(pessoas.buscaDados());
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
