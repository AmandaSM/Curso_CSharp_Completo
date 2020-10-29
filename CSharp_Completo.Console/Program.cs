using CSharp_Completo.Library.Cap.EstruturaCondicional;
using CSharp_Completo.Library.Cap.EstruturaSequencial;
using CSharp_Completo.Library.Cap.introducaoPOO;
using CSharp_Completo.Library.Cap.POO;
using CSharp_Completo.Library.Vetores;
using System;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

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
            System.Console.WriteLine("17- Introdução POO exercicio 01 Retângulo)");
            System.Console.WriteLine("18- Introdução POO exercicio 02 Funcionário");
            System.Console.WriteLine("19- Introdução POO exercicio 03 Aluno");
            System.Console.WriteLine("20- Introdução POO exercicio 04 Conversão Moeda");
            System.Console.WriteLine("21- POO exercicio 05 Banco");
            System.Console.WriteLine("22- Vetor ex 01 ");

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


    }
}
