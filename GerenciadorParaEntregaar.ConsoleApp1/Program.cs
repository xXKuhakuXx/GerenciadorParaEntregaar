/*
 
 • Deve ter um nome com no mínimo 6 caracteres;  
• Deve ter um preço de aquisição;  
• Deve ter um número de série;  
• Deve ter uma data de fabricação;  
• Deve ter uma fabricante;  
 */



using System;

namespace AQUELEPROGRAMA.ConsoleApp
{
    internal class Program
    {

        //Variaveis Globais Produtos
        static int[] idProdutos = new int[1000];
        static decimal[] preço = new decimal[1000];
        static string[] nome = new string[1000];
        static string[] numeroDeSerie = new string[1000];
        static string[] dataDeFabricacao = new string[1000];
        static string[] fabricante = new string[1000];
        static int produtosRegistrados = 0;
        static int opcao;
        static int opcaoSeEProdutoOuChamado;


        //Variaveis Globais Chamado 
        static string[] tituloDoChamado = new string[1000];
        static string[] descriçaoDoChamado = new string[1000];
        static string[] dataDeAberturaDoChamado = new string[1000];
        static string[] produtoEchamadoJuntos = new string[1000];
        static int[] idChamados = new int[1000];
        static int[] idDoProdutoRelacionadoAoChamado = new int[1000];
        static int chamadosRegistrados = 0;
        static int OpcoesDoChamado;


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" ---------------------------------------\n" +
                              "|DIGITE 5 PARA COMEÇAR A USAR O PROGRAMA|\n" +
                              " ---------------------------------------\n");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            while (opcao == 5 && opcaoSeEProdutoOuChamado != 3)
            {
                Console.WriteLine("Deseja trabalhar com chamados ou produtos ?\n" +
                                  "Digite 1 Para trabalhar com produtos\n" +
                                  "Digite 2 Para trabalhar com chamados.\n" +
                                  "Digite 3 Para sair");

                opcaoSeEProdutoOuChamado = Convert.ToInt32(Console.ReadLine());

                if (opcao == 6)

                    break;

                if (opcaoSeEProdutoOuChamado == 1)
                {
                    do
                    {
                        Console.WriteLine("Digite 1 para adicionar um produto.\n" +
                                          "Digite 2 Para visualizar Produtos adicionados.\n" +
                                          "Digite 3 Para Editar um Produto já existente\n" +
                                          "Digite 4 Para excluir um item \n" +
                                          "Digite 5 Para sair. ");

                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4)
                        {
                            Console.Clear();

                            while (opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4)
                            {
                                if (opcao == 5)
                                    break;

                                else if (opcao == 1)
                                {
                                    while (opcao == 1)
                                    {
                                        RegistrarProduto();

                                        Console.WriteLine("Deseja adicionar mais um produto?\n" +
                                                           "Digite 1 Caso sim\n" +
                                                           "Digite 2 para visualizar produtos cadastrados\n" +
                                                           "Digite 3 para editar produtos adicionados.\n" +
                                                           "Digite 4 para excluir um item\n" +
                                                           "Digite 5 para sair.");

                                        opcao = Convert.ToInt32(Console.ReadLine());

                                        Console.Clear();
                                    }
                                }
                                else if (opcao == 2)
                                {
                                    while (opcao == 2)
                                    {
                                        mostrarProdutosRegistrados();
                                        Console.WriteLine("Digite 1 para adicionar produtos\n" +
                                                          "Digite 2 para visualizar produtos registrados\n" +
                                                          "Digite 3 Para editar um produto\n" +
                                                          "Digite 4 Para excluir um item\n" +
                                                          "Digite 5 para sair.");

                                        opcao = Convert.ToInt32(Console.ReadLine());

                                        Console.Clear();
                                    }
                                }

                                else if (opcao == 3)
                                {
                                    while (opcao == 3)
                                    {
                                        if (nome[produtosRegistrados] != null)
                                        {
                                            mostrarProdutosRegistrados();
                                            editarProdutosRegistados();
                                            Console.WriteLine("Deseja Continuar Editando?\n" +
                                                "Digite 3 para sim\n" +
                                                "Digite 5 para nao");
                                            opcao = Convert.ToInt32(Console.ReadLine());

                                            Console.Clear();
                                        }
                                        else if (nome[0] == null)
                                        {
                                            do
                                            {
                                                Console.WriteLine("Opçao invalida, Voce nao possui produtos para Editar. \nPor Favor Digite 1 Para adicionar um item.");
                                                opcao = Convert.ToInt32(Console.ReadLine());
                                            } while (opcao != 1);
                                        }
                                    }
                                }

                                else if (opcao == 4)
                                {
                                    while (opcao == 4)
                                    {
                                        for (int i = 0; i < nome.Length; i++)
                                        {
                                            if (nome[i] != null)
                                            {
                                                mostrarProdutosRegistrados();
                                                ExcluirProdutosRegistados();
                                                Console.WriteLine("Deseja Continuar?\n" +
                                                    "Digite 4 para sim\n" +
                                                    "Digite 5 para nao");
                                                opcao = Convert.ToInt32(Console.ReadLine());
                                                if (opcao != 4)
                                                    break;
                                            }
                                            else if (nome[i] == null)
                                            {
                                                do
                                                {
                                                    Console.WriteLine("Opçao invalida, Voce nao possui produtos para Excluir. \nPor Favor Digite 5 para retornar ao menu.");
                                                    opcao = Convert.ToInt32(Console.ReadLine());
                                                } while (opcao != 1);
                                            }
                                        }

                                    }
                                }
                                else if (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 5)
                                {
                                    MensagemOpcaoInvalida();
                                }
                            }
                        }
                        else if (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 5)
                        {
                            do
                            {
                                MensagemOpcaoInvalida();

                            } while (opcao == 1 || opcao == 2);
                        }
                    } while (opcao != 5);
                }
                else if (opcaoSeEProdutoOuChamado == 2)
                {
                    do
                    {
                        Console.WriteLine("Digite 1 para abrir um novo chamado.\n" +
                                          "Digite 2 Para visualizar chamados abertos.\n" +
                                          "Digite 3 Para Editar um chamado já existente \n" +
                                          "Digite 4 Para excluir um chamado \n" +
                                          "Digite 5 Para sair. ");


                        OpcoesDoChamado = Convert.ToInt32(Console.ReadLine());

                        if (OpcoesDoChamado == 1 || OpcoesDoChamado == 2 || OpcoesDoChamado == 3 || OpcoesDoChamado == 4)
                        {
                            Console.Clear();

                            while (OpcoesDoChamado == 1 || OpcoesDoChamado == 2 || OpcoesDoChamado == 3 || OpcoesDoChamado == 4)
                            {
                                if (OpcoesDoChamado == 5)
                                    break;

                                else if (OpcoesDoChamado == 1)
                                {
                                    while (OpcoesDoChamado == 1)
                                    {
                                        AbrirChamado();

                                        Console.WriteLine("Digite 1 para abrir um novo chamado.\n" +
                                                          "Digite 2 Para visualizar chamados abertos.\n" +
                                                          "Digite 3 Para Editar um chamado já existente \n" +
                                                          "Digite 4 Para excluir um chamado \n" +
                                                          "Digite 5 Para sair. ");

                                        OpcoesDoChamado = Convert.ToInt32(Console.ReadLine());

                                        Console.Clear();
                                    }
                                }
                                else if (OpcoesDoChamado == 2)
                                {
                                    while (OpcoesDoChamado == 2)
                                    {
                                        MostrarChamadosRegistrados();
                                        Console.WriteLine("Digite 1 para abrir um novo chamado.\n" +
                                                          "Digite 2 Para visualizar chamados abertos.\n" +
                                                          "Digite 3 Para Editar um chamado já existente \n" +
                                                          "Digite 4 Para excluir um chamado \n" +
                                                          "Digite 5 Para sair. ");

                                        OpcoesDoChamado = Convert.ToInt32(Console.ReadLine());

                                        Console.Clear();

                                    }
                                }

                                else if (OpcoesDoChamado == 3)
                                {
                                    while (OpcoesDoChamado == 3)
                                    {
                                        if (tituloDoChamado[0] != null)
                                        {
                                            MostrarChamadosRegistrados();
                                            EditarChamadoRegistrado();
                                            Console.WriteLine("Deseja Continuar Editando?\n" +
                                                "Digite 3 para sim\n" +
                                                "Digite 2 para nao");
                                            OpcoesDoChamado = Convert.ToInt32(Console.ReadLine());

                                            Console.Clear();
                                        }
                                        else if (tituloDoChamado[0] == null)
                                        {
                                            do
                                            {
                                                Console.WriteLine("Opçao invalida, Voce nao possui chmados para Editar. \nPor Favor Digite 1 Para adicionar um item.");
                                                OpcoesDoChamado = Convert.ToInt32(Console.ReadLine());
                                            } while (OpcoesDoChamado != 1);
                                        }

                                    }
                                }

                                else if (OpcoesDoChamado == 4)
                                {
                                    while (OpcoesDoChamado == 4)
                                    {
                                        if (tituloDoChamado[0] != null)
                                        {
                                            MostrarChamadosRegistrados();
                                            ExcluirChamadoRegistrado();
                                            Console.WriteLine("Deseja Continuar Excluindo?\n" +
                                                "Digite 4 para sim\n" +
                                                "Digite 2 para nao");
                                            OpcoesDoChamado = Convert.ToInt32(Console.ReadLine());
                                            if (OpcoesDoChamado != 4)
                                                break;
                                        }
                                        else if (tituloDoChamado[0] == null)
                                        {
                                            do
                                            {
                                                Console.WriteLine("Opçao invalida, Voce nao possui chmados para Excluir. \nPor Favor Digite 1 Para adicionar um item.");
                                                OpcoesDoChamado = Convert.ToInt32(Console.ReadLine());
                                            } while (OpcoesDoChamado != 1);
                                        }
                                    }
                                }


                                else if (OpcoesDoChamado != 1 && OpcoesDoChamado != 2 && OpcoesDoChamado != 3 && OpcoesDoChamado != 4 && OpcoesDoChamado != 5)
                                {
                                    MensagemOpcaoInvalida();
                                }
                            }
                        }

                        else if (OpcoesDoChamado != 1 && OpcoesDoChamado != 2 && OpcoesDoChamado != 3 && OpcoesDoChamado != 5)
                        {
                            do
                            {
                                MensagemOpcaoInvalida();

                            } while (OpcoesDoChamado == 1 || OpcoesDoChamado == 2);
                        }
                    } while (OpcoesDoChamado != 5);
                }
                Console.Clear();
            }


            #region TRABALHAR COM OS CHAMADOS
            #region EXCLUIR CHAMADO REGISTRADO                         zZCHAMADOZz    
            static void ExcluirChamadoRegistrado()
            {

                Console.WriteLine("Qual a Id do produto deseja excluir?");
                int chamadoASerExcluido = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < idChamados.Length; i++)
                    if (idChamados[chamadoASerExcluido] == idChamados[chamadoASerExcluido])
                    {
                        tituloDoChamado[chamadoASerExcluido] = null;
                        descriçaoDoChamado[chamadoASerExcluido] = null;
                        dataDeAberturaDoChamado[chamadoASerExcluido] = null;
                        idDoProdutoRelacionadoAoChamado[chamadoASerExcluido] = -1;
                    }

                Console.Clear();

                Console.WriteLine($"Chamado excluido com sucesso.");
                Console.ReadLine();


            }

            #endregion
            #region EDITAR CHAMADO REGISTRADO                          zZCHAMADOZz    
            static void EditarChamadoRegistrado()
            {

                if (tituloDoChamado[0] != null)
                {
                    Console.WriteLine("Qual o id do Chamado que deseja editar?");
                    int chamadoASerEditado = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("id:" + idChamados[chamadoASerEditado]);
                    Console.WriteLine();

                    Console.WriteLine($"Faça uma nova Descriçao para o chamado {chamadoASerEditado}:  ");
                    tituloDoChamado[chamadoASerEditado] = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine($"Descriçao do Chamado: {chamadoASerEditado}: ");
                    descriçaoDoChamado[chamadoASerEditado] = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine($"Data de criaçao do chamado {chamadoASerEditado} (00/00/0000): ");
                    dataDeAberturaDoChamado[chamadoASerEditado] = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine($"Id do produto ao qual o chamado está relacionado {chamadoASerEditado}: ");
                    idDoProdutoRelacionadoAoChamado[chamadoASerEditado] = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine($"Chamado editado com sucesso.");
                    Console.ReadLine();
                }
                else if (tituloDoChamado[0] == null)
                {
                    do
                    {
                        Console.WriteLine("Opçao invalida, Voce nao possui produtos para editar. \nPor Favor Digite 1 para tentar novamente");
                        OpcoesDoChamado = Convert.ToInt32(Console.ReadLine());
                    } while (OpcoesDoChamado != 1);
                }
            }
            #endregion
            #region REGISTRAR CHAMADO                                  zZCHAMADOZz    

            static void AbrirChamado()

            {
                for (int i = 0; i + chamadosRegistrados < 1 + chamadosRegistrados; i++)
                {

                    idChamados[i + chamadosRegistrados] = chamadosRegistrados;
                    Console.WriteLine("id:" + idChamados[i + chamadosRegistrados]);

                    Console.WriteLine("Titúlo do chamado:  ");
                    tituloDoChamado[i + chamadosRegistrados] = Console.ReadLine();


                    Console.WriteLine("Descriçao do chamado: ");
                    descriçaoDoChamado[i + chamadosRegistrados] = Console.ReadLine();

                    Console.WriteLine("Data de criaçao do chamado (00/00/0000): ");
                    dataDeAberturaDoChamado[i + chamadosRegistrados] = Console.ReadLine();


                    Console.WriteLine($"Id do produto ao qual o chamado está relacionado: ");
                    idDoProdutoRelacionadoAoChamado[i + chamadosRegistrados] = Convert.ToInt32(Console.ReadLine());

                    chamadosRegistrados++;
                }




                Console.WriteLine($"Chamado registrado com sucesso.");
                Console.ReadLine();
                Console.Clear();


            }
            #endregion
            #region MOSTRAR CHAMADOS REGISTRADOS                       zZCHAMADOZz    
            static void MostrarChamadosRegistrados()
            {
                int j;
                for (int i = 0; i < chamadosRegistrados; i++)
                {


                    Console.ReadLine();
                    if (tituloDoChamado[i] != null)
                    {
                        Console.WriteLine("id: " + idChamados[i]);
                        Console.WriteLine($"Titulo do chamado {i}: {tituloDoChamado[i]}");
                        Console.WriteLine($"Descriçao do chamado: {descriçaoDoChamado[i]}");

                        Console.WriteLine("Id do produto ao qual o chamado está relacionado: " + idDoProdutoRelacionadoAoChamado[i]);
                        for (j = 0; j < idProdutos.Length; j++)
                        {

                            if (idDoProdutoRelacionadoAoChamado[j] == idProdutos[j] && nome[j] != null)
                            {
                                produtoEchamadoJuntos[j] = nome[j];
                                Console.WriteLine("Nome do produto ao qual o chamado se refere: " + nome[j]);
                            }

                        }
                        Console.WriteLine($"Data de criaçao do chamado: {dataDeAberturaDoChamado[i]}");

                        string[] dataSeparada = dataDeAberturaDoChamado[i].Split("/");

                        int dia = Convert.ToInt32(dataSeparada[0]);
                        int mes = Convert.ToInt32(dataSeparada[1]);
                        int ano = Convert.ToInt32(dataSeparada[2]);

                        DateTime dataCriacaoChamado = new DateTime(ano, mes, dia);
                        DateTime dataAtual = DateTime.Now;

                        TimeSpan diferencaTempo = dataAtual - dataCriacaoChamado;
                        int diferencaData = diferencaTempo.Days;

                        Console.WriteLine($"O chamado está aberto à {diferencaData} Dias.");


                        Console.ReadLine();

                    }
                }


            }
            #endregion
            #endregion

            #region TRABALHAR COM OS PRODUTOS 
            #region EXCLUIR PRODUTO REGISTRADO                              kKPRODUTOSKk
            static void ExcluirProdutosRegistados()
            {

                Console.WriteLine("Qual a Id do produto deseja excluir?");
                int produtoASerExcluido = Convert.ToInt32(Console.ReadLine());

                if (idProdutos[produtoASerExcluido] != idDoProdutoRelacionadoAoChamado[produtoASerExcluido])
                {
                    nome[produtoASerExcluido] = null;
                    preço[produtoASerExcluido] = 0;
                    numeroDeSerie[produtoASerExcluido] = null;
                    dataDeFabricacao[produtoASerExcluido] = null;
                    fabricante[produtoASerExcluido] = null;
                }
                else if (idDoProdutoRelacionadoAoChamado[produtoASerExcluido] == idProdutos[produtoASerExcluido])
                {
                    Console.WriteLine("Este produto nao pode ser excluido pois esta concatenado com um chamado.");
                    Console.ReadLine();
                }


                Console.Clear();

                Console.WriteLine($"Produto excluido com sucesso.");
                Console.ReadLine();

            }

            #endregion
            #region OPCAO INVALIDA                                          kKPRODUTOSKk
            static void MensagemOpcaoInvalida()
            {
                Console.WriteLine("Opção invalida tente novamente");
                Console.ReadLine();
                Console.Clear();
            }
            #endregion
            #region EDITAR PRODUTOS REGISTRADOS                             kKPRODUTOSKk
            static void editarProdutosRegistados()
            {

                if (nome[0] != null)
                {
                    Console.WriteLine("Qual o id do produto deseja editar?");
                    int produtoASerEditado = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("id:" + idProdutos[produtoASerEditado]);
                    Console.WriteLine();

                    Console.WriteLine($"Digite o Nome do Equipamento {produtoASerEditado}:  ");
                    nome[produtoASerEditado] = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine($"Digite O Preço do equipamento {produtoASerEditado}: ");
                    preço[produtoASerEditado] = Convert.ToDecimal(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine($"Digite o Número de Série do Equipamento {produtoASerEditado}: ");
                    numeroDeSerie[produtoASerEditado] = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine($"Digite a Data De Fabricação do Equipamento {produtoASerEditado} (00/00/0000): ");
                    dataDeFabricacao[produtoASerEditado] = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine($"Digite A Fabricante do Equipamento {produtoASerEditado}: ");
                    fabricante[produtoASerEditado] = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine($"Produto editado com sucesso.");
                    Console.ReadLine();
                }
                else if (nome[0] == null)
                {
                    do
                    {
                        Console.WriteLine("Opçao invalida, Voce nao possui produtos para editar. \nPor Favor Digite Adicione um produto");
                        opcao = Convert.ToInt32(Console.ReadLine());
                    } while (opcao != 1);
                }
            }
            #endregion
            #region REGISTRAR PRODUTO                                       kKPRODUTOSKk    

            static void RegistrarProduto()

            {
                for (int i = 0; i + produtosRegistrados < 1 + produtosRegistrados; i++)
                {
                    Console.WriteLine("Digite o Nome do Equipamento:  ");
                    nome[i + produtosRegistrados] = Console.ReadLine();

                    if (nome[i + produtosRegistrados].Length >= 6)
                    {
                        idProdutos[i + produtosRegistrados] = produtosRegistrados;
                        Console.WriteLine("id:" + idProdutos[i + produtosRegistrados]);

                        Console.WriteLine("Digite O Preço do equipamento: ");
                        preço[i + produtosRegistrados] = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Digite o Número de Série do Equipamento: ");
                        numeroDeSerie[i + produtosRegistrados] = Console.ReadLine();

                        Console.WriteLine("Digite a Data De Fabricação do Equipamento (00/00/0000): ");
                        dataDeFabricacao[i + produtosRegistrados] = Console.ReadLine();

                        Console.WriteLine($"Digite A Fabricante do Equipamento: ");
                        fabricante[i + produtosRegistrados] = Console.ReadLine();

                        produtosRegistrados++;

                        Console.WriteLine($"Produto(s) registrado(s) com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Falha ao cadastrar o produto, O Numero de caracteres para 'Nome do Equipamento' é invalido");
                    }

                }





                Console.ReadLine();
                Console.Clear();


            }
            #endregion
            #region MOSTRAR PRODUTOS REGISTRADOS                            kKPRODUTOSKk
            static void mostrarProdutosRegistrados()
            {
                for (int i = 0; i < produtosRegistrados; i++)
                {
                    if (nome[i] != null)
                    {
                        Console.WriteLine("id: " + idProdutos[i]);
                        Console.WriteLine($"Nome do equipamento {i}: {nome[i]}");
                        Console.WriteLine($"Numero de Série: {numeroDeSerie[i]}");
                        Console.WriteLine($"Preço: {preço[i]}R$");
                        Console.WriteLine($"Data De Fabricaçao: {dataDeFabricacao[i]}");
                        Console.WriteLine($"Fabricante: {fabricante[i]}\n");
                    }
                    Console.ReadLine();
                }


            }
            #endregion
            #endregion
        }
    }
}
