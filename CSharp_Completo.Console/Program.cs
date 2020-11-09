using CSharp_Completo.Library.Cap.Enumeracao_Composicao.Entities;
using CSharp_Completo.Library.Cap.Arquivo.Entities;
using CSharp_Completo.Library.Cap.Enumeracao_Composicao.Entities.Enums;
using CSharp_Completo.Library.Cap.Enumeracao_Composicao.Order.Entities;
using CSharp_Completo.Library.Cap.Enumeracao_Composicao.Order.Entities.Enums;
using CSharp_Completo.Library.Cap.EstruturaCondicional;
using CSharp_Completo.Library.Cap.EstruturaSequencial;
using CSharp_Completo.Library.Cap.introducaoPOO;
using CSharp_Completo.Library.Cap.Lista;
using CSharp_Completo.Library.Cap.Metodos_Abstratos.Imposto;
using CSharp_Completo.Library.Cap.Polimorfismo_Heranca.Mercadoria.Entities;
using CSharp_Completo.Library.Cap.POO;
using CSharp_Completo.Library.Cap.Tratamento_Execoes.Entitites;
using CSharp_Completo.Library.Vetores;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CSharp_Completo.Library.Cap.Interface.Entitite;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Concurrent;
using CSharp_Completo.Library.Cap.Linq.Entitite;
using System.Linq;

namespace CSharp_Completo.Console
{
    class Program
    {
        public static int opcao;
        static void Main(string[] args)
        {
            System.Console.WriteLine("ESCOLHA UMA OPÇÃO:");
            System.Console.WriteLine(" 1- POO exercicio 01");
            System.Console.WriteLine(" 2- POO exercicio 02");
            System.Console.WriteLine(" 3- EstruturaSequencial exercicio 01 SOMA");
            System.Console.WriteLine(" 4- EstruturaSequencial exercicio 02 ÁREA CIRCUNFÊRENCIA");
            System.Console.WriteLine(" 5- EstruturaSequencial exercicio 03 DIFERENCIA");
            System.Console.WriteLine(" 6- EstruturaSequencial exercicio 04 FuncionarioB");
            System.Console.WriteLine(" 7- EstruturaSequencial exercicio 05 Conta");
            System.Console.WriteLine(" 8- EstruturaSequencial exercicio 06 ÁREA");
            System.Console.WriteLine(" 9- EstruturaCondicional exercicio 01 Conjunto Numero inteiro");
            System.Console.WriteLine("10- EstruturaCondicional exercicio 02 Conjunto Par Impar ");
            System.Console.WriteLine("11- EstruturaCondicional exercicio 03 Conjunto Multiplos");
            System.Console.WriteLine("12- EstruturaCondicional exercicio 04 Horas de Jogo");
            System.Console.WriteLine("13- EstruturaCondicional exercicio 05 Lanchonete");
            System.Console.WriteLine("14- EstruturaCondicional exercicio 06 Intervalo");
            System.Console.WriteLine("15- EstruturaCondicional exercicio 07 Funcao Segundo Grau");
            System.Console.WriteLine("16- EstruturaCondicional exercicio 08 Salário");
            System.Console.WriteLine("17- Introdução POO exercicio 01 (Retângulo)");
            System.Console.WriteLine("18- Introdução POO exercicio 02 Funcionário");
            System.Console.WriteLine("19- Introdução POO exercicio 03 Aluno");
            System.Console.WriteLine("20- Introdução POO exercicio 04 Conversão Moeda");
            System.Console.WriteLine("21- POO exercicio 05 Banco");
            System.Console.WriteLine("22- Vetor ex 01 ");
            System.Console.WriteLine("23- Lista ex 01 ");
            System.Console.WriteLine("24- Matriz ex 01 ");
            System.Console.WriteLine("25- Enumeração e Composição ex 01 (worker) ");
            System.Console.WriteLine("26- Enumeração e Composição ex 02 (order)");
            System.Console.WriteLine("27- Polimorfismo e Herança ex 01 ");
            System.Console.WriteLine("OBS CLASE E MÉTODO ABSTRATO não se encontram aqui :( acesse Cap.Metodos_Abstratos(28) ");
            System.Console.WriteLine("29- Exeception ex 01");
            System.Console.WriteLine("30- Arquivo ex 01");
            System.Console.WriteLine("30- Interface ex 01");
            System.Console.WriteLine("32- HashSet ex 01");
            System.Console.WriteLine("33 Dictionary ex 01");
            System.Console.WriteLine("34 Lamdda LINQ ex 01");


            opcao = int.Parse(System.Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    ExecutePessoa();
                    break;
                case 2:
                    ExecuteFuncionario();
                    break;
                case 3:
                    ExecuteSoma();
                    break;

                case 4:
                    ExecuteAreaCircunferencia();
                    break;

                case 5:
                    ExecuteDiferencia();
                    break;

                case 6:
                    ExecuteFuncionarioB();
                    break;

                case 7:
                    ExecuteConta();
                    break;

                case 8:
                    ExecuteArea();
                    break;

                case 9:
                    ExecuteConjuntoNumeroInteiro();
                    break;

                case 10:
                    ExecuteValidadorParImpar();
                    break;

                case 11:
                    ExecutarValidadorMultiplos();
                    break;

                case 12:
                    ExecutarJogo();
                    break;

                case 13:
                    ExecutarLanchonete();
                    break;

                case 14:
                    ExecutarIntervalo();
                    break;

                case 15:
                    ExecutarFuncaoSegundoGrau();
                    break;

                case 16:
                    ExecutarFuncaoSalario();
                    break;

                case 17:
                    ExecutarRetangulo();
                    break;

                case 18:
                    ExecutarFuncionarioC();
                    break;

                case 19:
                    ExecutarAluno();
                    break;

                case 20:
                    ExecutarConversorMoeda();
                    break;

                case 21:
                    ExecutarContaBancaria();
                    break;

                case 22:
                    ExecutarPersionato();
                    break;

                case 23:
                    ExecutarEmployee();
                    break;

                case 24:
                    ExecutarMatriz();
                    break;

                case 25:
                    ExecutarContrato();
                    break;

                case 26:
                    ExecutarOrder();
                    break;

                case 27:
                    ExecuteMercadoria();
                    break;

                case 29:
                    ExecuteContaBancaria();
                    break;

                case 30:
                    ExecutarArquivo();
                    break;

                case 31:
                    ExecutarContratoParcela();
                    break;

                case 32:
                    ExecutarHashSet();
                    break;
                case 33:
                    ExecutarVotos();
                    break;
                case 34:
                    ExecutarArquvoFuncionario();
                    break;
                default:
                    System.Console.WriteLine("ESCOLHA UMA OPÇÃO");
                    break;
            }
        }
        static void ExecutePessoa()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            System.Console.WriteLine("DIGITE dados pessoa, NOME e IDADE, um em cada linha");

            //Pessoa 1
            p1.Idade = int.Parse(System.Console.ReadLine());
            p1.Nome = System.Console.ReadLine();
            //Pessoa 2
            p2.Idade = int.Parse(System.Console.ReadLine());
            p2.Nome = System.Console.ReadLine();

            //Dados Tela
            System.Console.WriteLine("Dados primeira pessoa");
            System.Console.WriteLine($"Nome: {p1.Nome}");
            System.Console.WriteLine($"Nome: {p1.Idade}");

            System.Console.WriteLine("Dados segunda  pessoa");
            System.Console.WriteLine($"Nome: {p2.Nome}");
            System.Console.WriteLine($"Nome: {p2.Idade}");

            if (p1.Idade == p2.Idade)
            {
                System.Console.WriteLine($"{p1.Nome} e {p2.Nome} possuem a mesma idade ");
            }
            else if (p1.Idade > p2.Idade)
            {
                System.Console.WriteLine($"{p1.Idade} é maior de idade");
            }
            else
            {
                System.Console.WriteLine($"{p2.Idade} é maior de idade");


            }
        }

        static void ExecuteFuncionario()
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            System.Console.WriteLine("DIGITE dados funcionarios, NOME e SALÁRIO, um em cada linha");

            //Funcionarios 
            f1.Nome = System.Console.ReadLine();
            f1.Salario = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            f2.Nome = System.Console.ReadLine();
            f2.Salario = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            //Dados tela
            System.Console.WriteLine("Dados primeiro funcionário: ");
            System.Console.WriteLine($"Nome: {f1.Nome}");
            System.Console.WriteLine($"Salário: {f1.Salario.ToString("F2", CultureInfo.InvariantCulture)}");

            System.Console.WriteLine("Dados primeiro funcionário: ");
            System.Console.WriteLine($"Nome: {f2.Nome}");
            System.Console.WriteLine($"Salário: {f2.Salario.ToString("F2", CultureInfo.InvariantCulture)}");


            double salarioMedio = (f1.Salario + f2.Salario) / 2.0;
            System.Console.WriteLine($"Salario médio: {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");


        }

        static void ExecuteSoma()
        {
            Soma s1 = new Soma();
            System.Console.WriteLine("DIGITE dados da Soma, Numero01 e Numero02, um em cada linha");

            s1.Valor01 = sbyte.Parse(System.Console.ReadLine());
            s1.Valor02 = sbyte.Parse(System.Console.ReadLine());

            //operacao
            System.Console.WriteLine($"SOMA= {s1.Valor01 + s1.Valor02}");
        }

        static void ExecuteAreaCircunferencia()
        {
            AreaCircunferencia aC1 = new AreaCircunferencia();
            System.Console.WriteLine("DIGITE RAIO");

            aC1.Raio = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            aC1.AreaCircuferencia = 3.14159 * (Math.Pow(aC1.Raio, 2));
            System.Console.WriteLine($"Área Circuferência: {aC1.AreaCircuferencia.ToString("F4", CultureInfo.InvariantCulture)}");

        }

        static void ExecuteDiferencia()
        {
            Diferencia d1 = new Diferencia();
            System.Console.WriteLine("DIGITE dados, Numero01, Numero02, NUmero03. Numero04 um em cada linha");

            //DADOS
            d1.A = int.Parse(System.Console.ReadLine());
            d1.B = int.Parse(System.Console.ReadLine());
            d1.C = int.Parse(System.Console.ReadLine());
            d1.D = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"DIFERENCA= {(d1.A * d1.B) - (d1.C * d1.D)}");

        }

        static void ExecuteFuncionarioB()
        {
            System.Console.WriteLine("DIGITE dados, Codigo funcionario, número horas de trabalho, salário por hora,  um em cada linha");
            FuncionarioB funcionarioB1 = new FuncionarioB();

            //Dados
            funcionarioB1.Id = int.Parse(System.Console.ReadLine());
            funcionarioB1.HorasTrabalhadas = int.Parse(System.Console.ReadLine());
            funcionarioB1.ValorHora = double.Parse(System.Console.ReadLine());

            funcionarioB1.Salario = (double)funcionarioB1.ValorHora * funcionarioB1.HorasTrabalhadas;
            System.Console.WriteLine($" NUMBER = { funcionarioB1.Id}");
            System.Console.WriteLine($" SALARY = U$ {funcionarioB1.Salario.ToString("F2", CultureInfo.InvariantCulture)}");

        }

        static void ExecuteConta()
        {
            Conta c1 = new Conta();
            Conta c2 = new Conta();
            double valorPagar;

            //peça 1
            System.Console.WriteLine("DIGITE dados codPeca, numeroPecas,  valorUnitario. Mesma linha");
            String[] resultadoPeca01 = System.Console.ReadLine().Split(' ');

            //dados
            c1.CodPeca01 = int.Parse(resultadoPeca01[0]);
            c1.NumeroPecas01 = int.Parse(resultadoPeca01[1]);
            c1.ValorUnitario01 = double.Parse(resultadoPeca01[2], CultureInfo.InvariantCulture);

            //peça 2
            System.Console.WriteLine("DIGITE dados codPeca, numeroPecas,  valorUnitario. Mesma linha");

            String[] resultadoPeca02 = System.Console.ReadLine().Split(' ');

            //dados
            c2.CodPeca01 = int.Parse(resultadoPeca01[0]);
            c2.NumeroPecas01 = int.Parse(resultadoPeca01[1]);
            c2.ValorUnitario01 = double.Parse(resultadoPeca01[2], CultureInfo.InvariantCulture);

            // CALCULO VALOR PECA
            valorPagar = (c1.NumeroPecas01 * c1.ValorUnitario01) + (c2.NumeroPecas01 * c2.ValorUnitario01);

            System.Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void ExecuteArea()
        {
            System.Console.WriteLine("DIGITE Numero01, Numero02,  Numero03. na mesma linha");
            Area a1 = new Area();

            //VETOR- com informacao Tela
            string[] resultadoTela = System.Console.ReadLine().Split(' ');
            a1.A = double.Parse(resultadoTela[0], CultureInfo.InvariantCulture);
            a1.B = double.Parse(resultadoTela[1], CultureInfo.InvariantCulture);
            a1.C = double.Parse(resultadoTela[2], CultureInfo.InvariantCulture);

            //AREA TRIANGULO
            a1.Resultado = (a1.A * a1.C) / 2;
            System.Console.WriteLine($"TRIANGULO: { a1.Resultado.ToString("F3", CultureInfo.InvariantCulture)}");

            //AREA CIRCULO
            a1.Resultado = a1.C * a1.C * 3.14159;
            System.Console.WriteLine($"CIRCULO: { a1.Resultado.ToString("F3", CultureInfo.InvariantCulture)}");

            //AREA TRAPEZIO
            a1.Resultado = ((a1.A + a1.B) * a1.C) / 2;
            System.Console.WriteLine($"TRAPEZIO: { a1.Resultado.ToString("F3", CultureInfo.InvariantCulture)}");

            //AREA QUADRADO
            a1.Resultado = a1.B * a1.B;
            System.Console.WriteLine($"QUADRADO: { a1.Resultado.ToString("F3", CultureInfo.InvariantCulture)}");

            //AREA RETANDULO
            a1.Resultado = a1.A * a1.B;
            System.Console.WriteLine($"RETANGULO: { a1.Resultado.ToString("F3", CultureInfo.InvariantCulture)}");
        }

        static void ExecuteConjuntoNumeroInteiro()
        {
            ConjuntoNumerosInteiro cJI = new ConjuntoNumerosInteiro();
            System.Console.WriteLine("DIGITE Numero");

            cJI.Numero = sbyte.Parse(System.Console.ReadLine());
            if (cJI.Numero < 0)
            {
                System.Console.WriteLine("NEGATIVO");
            }
            else
            {
                System.Console.WriteLine("NAO NEGATIVO");
            }
        }

        static void ExecuteValidadorParImpar()
        {
            ValidadorParImpar vPI = new ValidadorParImpar();
            System.Console.WriteLine("DIGITE Numero");

            vPI.Numero = sbyte.Parse(System.Console.ReadLine());
            if (vPI.Numero % 2 == 0 || vPI.Numero == 0)
            {
                System.Console.WriteLine("PAR");
            }
            else
            {
                System.Console.WriteLine("IMPAR");
            }
        }

        static void ExecutarValidadorMultiplos()
        {
            ValidadorMultiplos vM = new ValidadorMultiplos();

            System.Console.WriteLine("DIGITE Dois Numeros, na mesma linha");
            String[] valorDigitado = System.Console.ReadLine().Split(' ');

            vM.A = int.Parse(valorDigitado[0]);
            vM.B = int.Parse(valorDigitado[1]);


            if (vM.B % vM.A == 0 || vM.A % vM.B == 0)
            {
                System.Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                System.Console.WriteLine("NÃO são MULTIPLOS");
            }

        }

        static void ExecutarJogo()
        {
            Jogo jogo = new Jogo();

            System.Console.WriteLine("DIGITE hora inicial e hora final, na mesma linha");
            String[] horarioJogo = System.Console.ReadLine().Split(' ');

            jogo.HoraInicial = int.Parse(horarioJogo[0]);
            jogo.HoraFinal = int.Parse(horarioJogo[1]);

            if (jogo.HoraFinal <= jogo.HoraInicial)
            {
                jogo.HoraTotal = 24 - jogo.HoraInicial + jogo.HoraFinal;

            }
            else
            {
                jogo.HoraTotal = jogo.HoraFinal - jogo.HoraInicial;
            }
            System.Console.WriteLine($"O JOGO DUROU {jogo.HoraTotal} HORA (S)");
        }

        static void ExecutarLanchonete()
        {
            Lanchonete lanche = new Lanchonete();

            System.Console.WriteLine("DIGITE código produto e quantidade, na mesma linha");
            String[] pedido = System.Console.ReadLine().Split(' ');

            lanche.Cod = int.Parse(pedido[0]);
            lanche.QuantidadeProduto = int.Parse(pedido[1]);

            switch (lanche.Cod)
            {
                case 1:
                    lanche.Preco = lanche.QuantidadeProduto * 4.00;
                    System.Console.WriteLine($"Total: {lanche.Preco.ToString("F2", CultureInfo.InvariantCulture) }");
                    break;

                case 2:
                    lanche.Preco = lanche.QuantidadeProduto * 4.50;
                    System.Console.WriteLine($"Total: {lanche.Preco.ToString("F2", CultureInfo.InvariantCulture) }");
                    break;

                case 3:
                    lanche.Preco = lanche.QuantidadeProduto * 5.00;
                    System.Console.WriteLine($"Total: {lanche.Preco.ToString("F2", CultureInfo.InvariantCulture) }");
                    break;
                case 4:
                    lanche.Preco = lanche.QuantidadeProduto * 2.00;
                    System.Console.WriteLine($"Total: {lanche.Preco.ToString("F2", CultureInfo.InvariantCulture) }");
                    break;

                case 5:
                    lanche.Preco = lanche.QuantidadeProduto * 1.50;
                    System.Console.WriteLine($"Total: {lanche.Preco.ToString("F2", CultureInfo.InvariantCulture) }");
                    break;
            }

        }

        static void ExecutarIntervalo()
        {
            System.Console.WriteLine("DIGITE valor");

            Intervalo intervalo = new Intervalo();

            intervalo.Valor = double.Parse(System.Console.ReadLine());

            if (intervalo.Valor < 0.0 || intervalo.Valor > 100.0)
            {
                System.Console.WriteLine("Fora do Intervalo");
            }
            else if (intervalo.Valor <= 25)
            {
                System.Console.WriteLine("Intervalo [0,25]");

            }
            else if (intervalo.Valor <= 50)
            {
                System.Console.WriteLine("Intervalo [25,50]");

            }
            else if (intervalo.Valor <= 75)
            {
                System.Console.WriteLine("Intervalo [50,75]");

            }
            else
            {
                System.Console.WriteLine("Intervalo [75,100]");

            }
        }

        static void ExecutarFuncaoSegundoGrau()
        {
            FuncaoSegundoGrau fSG = new FuncaoSegundoGrau();
            System.Console.WriteLine("DIGITE valor");

            String[] valorEntrada = System.Console.ReadLine().Split(' ');
            fSG.X = double.Parse(valorEntrada[0], CultureInfo.InvariantCulture);
            fSG.Y = double.Parse(valorEntrada[1], CultureInfo.InvariantCulture);
            if (fSG.X == 0.0 && fSG.Y == 0.0)
            {
                System.Console.WriteLine("Origem");
            }
            else if (fSG.X > 0 && fSG.Y < 0)
            {
                System.Console.WriteLine("Q4");
            }
            else if (fSG.X > 0 && fSG.Y > 0)
            {
                System.Console.WriteLine("Q1");
            }
            else if (fSG.X < 0 && fSG.Y < 0)
            {
                System.Console.WriteLine("Q3");
            }
            else
            {
                System.Console.WriteLine("Q2");
            }
        }

        static void ExecutarFuncaoSalario()
        {
            Salario salario = new Salario();

            System.Console.WriteLine("DIGITE salário");

            salario.ValorSalario = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            if (salario.ValorSalario <= 2000.00)
            {
                System.Console.WriteLine("Isento");
            }
            else if (salario.ValorSalario <= 3000.00)
            {
                salario.ValorSalario = salario.ValorSalario * 8 / 100;
                System.Console.WriteLine($"R$ {salario.ValorSalario.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else if (salario.ValorSalario <= 4500.00)
            {
                salario.ValorSalario = salario.ValorSalario * 18 / 100;
                System.Console.WriteLine($"R$ {salario.ValorSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                salario.ValorSalario = salario.ValorSalario * 28 / 100;
                System.Console.WriteLine($"R$ {salario.ValorSalario.ToString("F2", CultureInfo.InvariantCulture)}");

            }

        }

        static void ExecutarRetangulo()
        {
            Retangulo retangulo = new Retangulo();
            System.Console.WriteLine("DIGITE altura e largura, cada um em uma linha");
            retangulo.Altura = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine($" Área:{retangulo.Area().ToString("f2", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($" Perímetro:{retangulo.Perimetro().ToString("f2", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($" Diagonal:{retangulo.Diagonal().ToString("f2", CultureInfo.InvariantCulture)}");


        }

        static void ExecutarFuncionarioC()
        {
            FuncionarioC salario = new FuncionarioC();

            System.Console.WriteLine("DIGITE Nome:");
            salario.Nome = System.Console.ReadLine();

            System.Console.WriteLine("DIGITE  salário bruto: ");
            salario.SalarioBruto = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("DIGITE Imposto: ");
            salario.Imposto = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine();
            System.Console.WriteLine($"Dados:{salario}");

            System.Console.WriteLine();
            System.Console.WriteLine("Quer aumentar o salário? Digite S ou N");
            string x = System.Console.ReadLine();
            if (x == "S" || x == "s")
            {
                System.Console.WriteLine("Digite porcentagem do almento:");
                salario.Porcentagem = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                salario.AumentarSalario(salario.Porcentagem);

                System.Console.WriteLine();
                System.Console.WriteLine($"Dados Atualizados :{salario}");
            }

        }

        static void ExecutarAluno()
        {
            Aluno aluno = new Aluno();

            System.Console.WriteLine();
            System.Console.WriteLine("Nome Aluno:");
            aluno.SetNome(System.Console.ReadLine());

            System.Console.WriteLine("Digite nota primeiro bimestre:");
            aluno.Nota01 = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Digite nota segundo bimestre");
            aluno.Nota02 = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Digite nota terceiro bimestre:");
            aluno.Nota03 = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine(aluno);
            System.Console.WriteLine(aluno.Aprovado());
            if (aluno.Aprovado() == "REPROVADO")
            {
                System.Console.WriteLine($"Faltaram: {aluno.Faltaram().ToString("f2", CultureInfo.InvariantCulture)} pontos");
            }

        }

        static void ExecutarConversorMoeda()
        {
            ConversorMoeda c1 = new ConversorMoeda();

            System.Console.WriteLine();
            System.Console.WriteLine("Qual é a Cotação dolar?");
            double cotacao = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Quantos dólares você vai comprar?");
            double qtd = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine($"valor a ser pago em reais= {ConversorMoeda.Pagar(cotacao, qtd).ToString("F2", CultureInfo.InvariantCulture)}"); ;

        }

        static void ExecutarContaBancaria()
        {
            System.Console.WriteLine("");

            //dados Tela
            System.Console.Write("Número Conta:");
            int numeroConta = int.Parse(System.Console.ReadLine());
            ContaBancaria conta = new ContaBancaria(numeroConta);

            System.Console.Write("Titular:");
            conta.Nome = System.Console.ReadLine();

            System.Console.Write("Haverá depósito inicial?(s/n)");
            char x = char.Parse(System.Console.ReadLine());
            if (x == 'S' || x == 's')
            {
                System.Console.Write("Entre valor do depósito inicial:");
                conta.Deposito(double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine(conta);
            System.Console.WriteLine("");

            System.Console.WriteLine("Deseja efetuar depósito?(s/n)");
            x = char.Parse(System.Console.ReadLine());
            if (x == 'S' || x == 's')
            {
                System.Console.WriteLine("Entre valor do depósito :");
                conta.Deposito(double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture));

                System.Console.WriteLine("Dados da conta atualizado:");
                System.Console.WriteLine(conta);
                System.Console.WriteLine("");

            }

            System.Console.WriteLine("Deseja efetuar saque?(s/n)");
            x = char.Parse(System.Console.ReadLine());
            if (x == 'S' || x == 's')
            {
                System.Console.WriteLine("Entre valor do saque :");
                conta.Saque(double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture));

                System.Console.WriteLine("Dados da conta atualizado:");
                System.Console.WriteLine(conta);
                System.Console.WriteLine("");

            }
        }

        static void ExecutarPersionato()
        {
            System.Console.WriteLine("");

            //dados Tela
            System.Console.Write("Quantos quartos serão alugados?");
            int qtdQuartosAlugados = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();

            Estudantes[] alunos = new Estudantes[10];

            //preencher vetor
            for (int quarto = 1; quarto <= qtdQuartosAlugados; quarto++)
            {
                System.Console.WriteLine($"Aluguel #{quarto}:");
                System.Console.Write($"Nome: ");
                string nome = System.Console.ReadLine();

                System.Console.Write($"Email: ");
                string email = System.Console.ReadLine();

                System.Console.Write($"Quarto: ");
                int numeroQuarto = int.Parse(System.Console.ReadLine());
                alunos[numeroQuarto] = new Estudantes(nome, email, numeroQuarto);
                System.Console.WriteLine();

            }

            //quartos vazios
            System.Console.WriteLine("Quartos Ocupados:");
            int quartosVazios = 0;

            for (int quarto = 0; quarto < alunos.Length; quarto++)
            {
                if (alunos[quarto] == null)
                {
                    quartosVazios += 1;
                }
                else
                {
                    System.Console.WriteLine(alunos[quarto]);
                }
            }
            System.Console.WriteLine($"Quantidade de quartos vazios: {quartosVazios}");
        }

        static void ExecutarEmployee()
        {
            System.Console.WriteLine();
            List<Employee> lista = new List<Employee>();
            System.Console.Write("Quantos funcionarios seram registrados?");
            int n = int.Parse(System.Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.Write($"Emplyoee# {i} :");

                //Dados 
                System.Console.Write("Id:");
                int id = int.Parse(System.Console.ReadLine());
                System.Console.Write("Nome:");
                string nome = System.Console.ReadLine();
                System.Console.Write("Salário:");
                double salario = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.WriteLine();

                //add list          
                lista.Add(new Employee(id, nome, salario));

            }

            System.Console.Write("Deseja efetuar aumento de salário?(s/n)");
            char x = char.Parse(System.Console.ReadLine());
            if (x == 'S' || x == 's')
            {
                System.Console.Write("Digite id do funcionário:");
                int id = int.Parse(System.Console.ReadLine());

                //verificação id
                Employee valorLista = lista.Find(employee => employee.Id == id);

                if (valorLista == null)
                {
                    System.Console.WriteLine("Id não existente");
                }
                else
                {
                    System.Console.Write("Digite porcentagem de aumento do funcionário:");
                    valorLista.Aumento(double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture));
                }
            }

            foreach (Employee employee1 in lista)
            {
                System.Console.WriteLine(employee1);
            }

        }

        static void ExecutarMatriz()
        {
            System.Console.WriteLine();
            System.Console.Write("Digite número de Colunas e Linhas da matriz: ");
            string[] tamanho = System.Console.ReadLine().Split(' ');
            int m = int.Parse(tamanho[0]);
            int n = int.Parse(tamanho[1]);

            //Matriz
            int[,] mat = new int[m, n];
            System.Console.WriteLine("Digite matriz:");
            //preenchimento matriz
            for (int coluna = 0; coluna < m; coluna++)
            {
                string[] values = System.Console.ReadLine().Split(' ');
                for (int linha = 0; linha < n; linha++)
                {
                    mat[coluna, linha] = int.Parse(values[linha]);
                }
            }

            System.Console.Write("Digite um número da matriz: ");
            int numero = int.Parse(System.Console.ReadLine());

            //varrendo matriz
            for (int coluna = 0; coluna < m; coluna++)
            {
                for (int linha = 0; linha < n; linha++)
                {
                    if (mat[coluna, linha] == numero)
                    {
                        System.Console.WriteLine($"Posição: {coluna},{linha}");
                        if (linha != 0)
                        {
                            System.Console.WriteLine($"Esquerda: {mat[coluna, linha - 1]}");
                        }
                        if (linha != n - 1)
                        {
                            System.Console.WriteLine($"Direita : {mat[coluna, linha + 1]} ");
                        }
                        if (coluna != m - 1)
                        {
                            System.Console.WriteLine($"Em baixo: {mat[coluna + 1, linha]}");
                        }
                        if (coluna != 0)
                        {
                            System.Console.WriteLine($"Em cima:  {mat[coluna - 1, linha]}");
                        }
                        System.Console.WriteLine();
                    }
                }
            }
        }

        static void ExecutarContrato()
        {
            System.Console.WriteLine("");
            System.Console.Write("Enter department's name:");
            string deptName = System.Console.ReadLine();
            System.Console.WriteLine("Enter worker data:");
            System.Console.Write("Name: ");
            string name = System.Console.ReadLine();

            //tratando erro         
            System.Console.Write("Level (Junior/MidLevel/Senior):");
            string valorRecebido = System.Console.ReadLine();

            while (valorRecebido != "Junior" && valorRecebido != "MidLevel" && valorRecebido != "Senior")
            {
                System.Console.Write("Level (Junior/MidLevel/Senior):");
                valorRecebido = System.Console.ReadLine();

                if (valorRecebido == "junior" || valorRecebido == "midLevel" || valorRecebido == "senior")
                {
                    string upper = valorRecebido.Substring(0, 1).ToUpper();

                    valorRecebido = upper + valorRecebido.ToString().Substring(1);
                }
                else
                {
                    System.Console.WriteLine("Level not found. Enter valid level");
                }
            }

            WorkerLevel level = Enum.Parse<WorkerLevel>(valorRecebido);
            System.Console.Write("Base Salary: ");
            double baseSalary = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            /*construtor */
            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            System.Console.Write("How many contracts to this worker? ");
            int numberContracts = int.Parse(System.Console.ReadLine());

            //cadastrando contratos 
            for (int cont = 1; cont <= numberContracts; cont++)
            {
                System.Console.WriteLine($"ENTER #{cont} CONTRACT DATA:");
                System.Console.Write("DATE (DD/MM/YYYY):");
                DateTime dateContract = DateTime.Parse(System.Console.ReadLine());
                System.Console.Write("Value per hour:");
                double valuePerHour = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Duration (hours):");
                int hours = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine();

                /*construtor HourContract*/
                HourContract contract = new HourContract(dateContract, valuePerHour, hours);
                worker.AddContract(contract);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Enter moth and year to calculate income (MM/YYYY)");
            string mothAndYear = System.Console.ReadLine();
            int month = int.Parse(mothAndYear.Substring(0, 2));
            int year = int.Parse(mothAndYear.Substring(3));
            System.Console.WriteLine($"Name: {worker.Name}");
            System.Console.WriteLine($"DEPARTMENT: {worker.Department.Name}");
            System.Console.Write($"Income for {mothAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");

        }

        static void ExecutarOrder()
        {
            System.Console.WriteLine("ENTER CLIENTE DATA:");
            System.Console.Write("Name:");
            string name = System.Console.ReadLine();
            System.Console.Write("Email:");
            string email = System.Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY):");
            DateTime date = DateTime.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("----------------------------------------------");
            System.Console.WriteLine();
            System.Console.WriteLine("ENTER ORDER DATA:");
            System.Console.Write("Status (Pending_Payment/Processing/Delivered/Shipped):");
            string valorRecebido = System.Console.ReadLine();
            OrderStatus orderStatus;

            while (valorRecebido != OrderStatus.Pending_Payment.ToString() && valorRecebido != OrderStatus.Processing.ToString()
                && valorRecebido != OrderStatus.Delivered.ToString() && valorRecebido != OrderStatus.Shipped.ToString())
            {
                System.Console.Write("Status (Pending_Payment/Processing/Delivered/Shipped):");
                valorRecebido = System.Console.ReadLine();

                if (valorRecebido == "processing" || valorRecebido == "shipped")
                {
                    string upper = valorRecebido.Substring(0, 1).ToUpper();
                    valorRecebido = upper + valorRecebido.ToString().Substring(1);
                }
                else if (valorRecebido == "pending_payment")
                {
                    valorRecebido += valorRecebido.Replace('p', 'P');
                }
                else
                {
                    System.Console.WriteLine("Satus not found. Enter valid status");
                }
            }

            orderStatus = Enum.Parse<OrderStatus>(valorRecebido);

            /*construtor */
            Client client = new Client(name, email, date);
            Order order = new Order(orderStatus, client);
            Product product = null;
            System.Console.Write("How many itens to this order? ");
            int numberItens = int.Parse(System.Console.ReadLine());

            //cadastrando contratos 
            for (int cont = 1; cont <= numberItens; cont++)
            {
                System.Console.WriteLine($"ENTER #{cont} item DATA:");
                System.Console.Write("Product Name:");
                name = System.Console.ReadLine();
                System.Console.Write("Product price: ");
                double price = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Quantity:");
                int qtd = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine();

                /*construtor */
                product = new Product(name, price);
                OrdemItem item = new OrdemItem(qtd, product);
                order.AddItem(item);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("ORDER SUMMARY");
            System.Console.WriteLine(order);
        }

        static void ExecuteMercadoria()
        {
            System.Console.Write("Enter the number of Mercadorias:");
            int numberMercadorias = int.Parse(System.Console.ReadLine());
            List<Mercadoria> list = new List<Mercadoria>();

            for (int prod = 0; prod < numberMercadorias; prod++)
            {
                System.Console.WriteLine($"ENTER #{prod} DATA:");
                System.Console.Write("Common, used or imported (c/u/i)?");
                char valida = char.Parse(System.Console.ReadLine());

                System.Console.Write("Mercadoria Name:");
                string name = System.Console.ReadLine();
                System.Console.Write("Mercadoria price: ");
                double price = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

                /*construtor */

                if (valida == 'i')
                {
                    System.Console.Write("Custon fee:");
                    double custon = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                    System.Console.WriteLine();
                    /*construtor */
                    list.Add(new ImportedMercadoria(custon, name, price));
                }
                else if (valida == 'u')
                {
                    System.Console.Write("Manufacture da(DD/MM/YYYY):");
                    DateTime date = DateTime.Parse(System.Console.ReadLine());
                    System.Console.WriteLine();
                    /*construtor */
                    list.Add(new UsedMercadoria(date, name, price));
                }
                else
                {
                    list.Add(new Mercadoria(name, price));
                }
                System.Console.WriteLine("PRICE TAGS:");
                foreach (Mercadoria item in list)
                {
                    System.Console.WriteLine(item.PriceTag());
                }
            }
        }

        static void ExecuteContaBancaria()
        {
            try
            {
                System.Console.WriteLine();

                System.Console.WriteLine("Enter account data:");
                System.Console.Write("Number:");
                int id = int.Parse(System.Console.ReadLine());
                System.Console.Write("Holder:");
                string holder = System.Console.ReadLine();
                System.Console.Write("Initial balance: ");
                double initialBalance = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine();
                System.Console.WriteLine("----------------------------------");
                System.Console.WriteLine();

                Account1 contaBancaria = new Account1(id, holder, withdrawLimit, initialBalance);

                System.Console.Write("Would like to enter balance or withdraw?(y/n): ");
                char valida = char.Parse(System.Console.ReadLine());
                while (valida != 'n')
                {
                    System.Console.Write("Would like to enter balance or withdraw?(b/w): ");
                    valida = char.Parse(System.Console.ReadLine());
                    if (valida == 'b' || valida == 'B')
                    {
                        System.Console.Write("Enter amount for balance: ");
                        double amount = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                        try
                        {
                            contaBancaria.Deposito(amount);
                            System.Console.WriteLine("----------------------------------");
                            System.Console.WriteLine(contaBancaria);
                            System.Console.WriteLine("----------------------------------");
                        }
                        catch (CannotUnloadAppDomainException e)
                        {
                            System.Console.WriteLine($"Withdraw error:{e}");
                        }
                    }
                    else if (valida == 'w' || valida == 'W')
                    {
                        System.Console.Write("Enter amount for withdraw: ");
                        double amount = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                        try
                        {
                            contaBancaria.WithDraw(amount);
                            System.Console.WriteLine("----------------------------------");
                            System.Console.WriteLine(contaBancaria);
                            System.Console.WriteLine("----------------------------------");
                        }
                        catch (CannotUnloadAppDomainException e)
                        {
                            System.Console.WriteLine($" Balance error:{e}");
                        }
                    }
                    System.Console.Write("Would like to enter balance or withdraw?(y/n): ");
                    valida = char.Parse(System.Console.ReadLine());
                }
            }
            catch (FormatException e)
            {
                System.Console.WriteLine($"Error in format:{e}");
            }
            catch (AppDomainUnloadedException e)
            {
                System.Console.WriteLine($"Error in Account1:{e}");
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Unexpected error:{e}");
            }
        }

        static void ExecutarArquivo()
        {
            System.Console.Write("Enter path:");
            string path = System.Console.ReadLine();

            try
            {
                //lendo arquivo
                string[] lines = File.ReadAllLines(path);
                // caminho arquivo principal -> pegando pasta
                string folderPath = Path.GetDirectoryName(path);
                //caminho arquivo gerado
                string folderPath02 = folderPath + @"\out";
                string filePath02 = folderPath02 + @"\summary.csv";
                //criando pasta \out
                Directory.CreateDirectory(folderPath02);

                using (StreamWriter streamWriter = File.AppendText(filePath02))
                {
                    foreach (string line in lines)
                    {
                        //line[0] retorna uma letra
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);
                        Produto01 p = new Produto01(name, price, quantity);
                        streamWriter.WriteLine(p);
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("ERROR OCCURED");
                System.Console.WriteLine(e.Message);
            }
        }

        static void ExecutarContratoParcela()
        {
            System.Console.Write("Number:");
            int numberContract = int.Parse(System.Console.ReadLine());
            System.Console.Write("Date:");
            DateTime date = DateTime.Parse(System.Console.ReadLine());
            System.Console.Write("Contract Value:");
            double value = double.Parse(System.Console.ReadLine());
            System.Console.Write("Enter number of installments:");
            int numberParcela = int.Parse(System.Console.ReadLine());

            Contract contract = new Contract(numberContract, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, numberParcela);

            System.Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                System.Console.WriteLine(installment);
            }

        }

        static void ExecutarHashSet()
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            System.Console.Write("How many students for course A?");
            int numberStudents = int.Parse(System.Console.ReadLine());
            Add(courseA, numberStudents);

            System.Console.Write("How many students for course B?");
            numberStudents = int.Parse(System.Console.ReadLine());
            Add(courseB, numberStudents);

            System.Console.Write("How many students for course A?");
            numberStudents = int.Parse(System.Console.ReadLine());
            Add(courseC, numberStudents);

            //Juntando todos os HashSet
            HashSet<int> allCourses = new HashSet<int>(courseA);
            allCourses.UnionWith(courseB);
            allCourses.UnionWith(courseC);

            //Contando o número de registro
            System.Console.WriteLine($"Total students {allCourses.Count}");
        }
        static void Add(HashSet<int> hashSet, int numberStudents)
        {
            for (int student = 0; student < numberStudents; student++)
            {
                int idStudents = int.Parse(System.Console.ReadLine());
                hashSet.Add(idStudents);
            }
        }

        static void ExecutarVotos()
        {
            System.Console.Write("Enter path:");
            string path = System.Console.ReadLine();

            try
            {
                Dictionary<string, int> candidatos = new Dictionary<string, int>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {

                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (candidatos.ContainsKey(candidate))
                        {
                            candidatos[candidate] += votes;
                        }
                        else
                        {
                            candidatos[candidate] = votes;
                        }
                    }

                    foreach (var item in candidatos)
                    {
                        System.Console.WriteLine($"{ item.Key} :  {item.Value}");
                    }
                }

            }
            catch (IOException e)
            {
                System.Console.WriteLine($"An error occurred{e.Message}");
            }


        }

        static void ExecutarArquvoFuncionario()
        {
            System.Console.Write("Enter path:");
            string path = System.Console.ReadLine();

            System.Console.Write("Enter salary:");
            double salarySerch = double.Parse(System.Console.ReadLine());

            List<FuncionarioD> list = new List<FuncionarioD>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] funcionarios = sr.ReadLine().Split(',');
                        string name = funcionarios[0];
                        double salary = double.Parse(funcionarios[1], CultureInfo.InvariantCulture);
                        string email = funcionarios[3];
                        list.Add(new FuncionarioD(salary, name, email));

                        var serchResulEmail = list.Where(funcionario => funcionario.Salary > salarySerch).OrderBy(funcionarios => funcionarios.Email).Select(funcionarios => funcionarios.Email);
                        var salarySum = list.Where(f => f.Name[0] == 'M').Sum(f => f.Salary);

                        System.Console.WriteLine($"Email of employee whose salary is more than {salarySerch.ToString("F2", CultureInfo.InvariantCulture)}");
                        foreach (string eamil in serchResulEmail)
                        {
                            System.Console.WriteLine(email);
                        }
                        System.Console.WriteLine($"Sum salary people whose name star with M{salarySum}");


                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine($"An error occurred{e.Message}");
            }

        }


    }
}
