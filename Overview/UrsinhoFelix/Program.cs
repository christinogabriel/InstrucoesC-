// Sistema Ursinho Feliz

string mensagemDeBoasVindas = "Boas Vindas ao SISTEMA URSINHO FELIZ\n";


List<string> listaDeNomes = new List<string>();

void ExibirLogo()
{
    Console.WriteLine(@"\r
\n██╗░░░██╗██████╗░░██████╗██╗███╗░░██╗██╗░░██╗░█████╗░  ███████╗███████╗██╗░░░░░██╗███████╗\r
\n██║░░░██║██╔══██╗██╔════╝██║████╗░██║██║░░██║██╔══██╗  ██╔════╝██╔════╝██║░░░░░██║╚════██║\r
\n██║░░░██║██████╔╝╚█████╗░██║██╔██╗██║███████║██║░░██║  █████╗░░█████╗░░██║░░░░░██║░░███╔═╝\r
\n██║░░░██║██╔══██╗░╚═══██╗██║██║╚████║██╔══██║██║░░██║  ██╔══╝░░██╔══╝░░██║░░░░░██║██╔══╝░░\r
\n╚██████╔╝██║░░██║██████╔╝██║██║░╚███║██║░░██║╚█████╔╝  ██║░░░░░███████╗███████╗██║███████╗\r
\n░╚═════╝░╚═╝░░╚═╝╚═════╝░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░  ╚═╝░░░░░╚══════╝╚══════╝╚═╝╚══════╝");

    Console.WriteLine(mensagemDeBoasVindas);
}



// Não tem retorno, usa void
/*void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("****************************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("****************************************");
}*/

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("DIGITE 1 para registrar um aluno");
    Console.WriteLine("DIGITE 2 para mostrar todos os alunos");
    Console.WriteLine("DIGITE 3 para lançar a nota do aluno");
    Console.WriteLine("DIGITE 4 para exibir a média de um aluno");
    Console.WriteLine("DIGITE 5 para sair do sistema");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!; // para opções não nulas. Pesquisar

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);




    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarAluno();
            break;
        case 2:
            MostrarAlunosRegistrados();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Você está saindo do sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

}






// ExibirMensagemDeBoasVindas();

ExibirLogo();
ExibirOpcoesDoMenu();



void RegistrarAluno()
{
    Console.Clear();
    Console.WriteLine("*************************");
    Console.WriteLine("R E G I S T R A R  A L U N O");
    Console.WriteLine("*************************");
    Console.WriteLine("Digite o nome do aluno que deseja registrar: ");
    string nomeDoAluno = Console.ReadLine()!;
    listaDeNomes.Add(nomeDoAluno);
    Console.WriteLine($"O aluno {nomeDoAluno} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}


void MostrarAlunosRegistrados()
{
    Console.WriteLine("*************************");
    Console.WriteLine("E X I B I R  R E G I S T R O  D E  A L U N O S");
    Console.WriteLine("*************************");

    /*for(int i = 0; i < listaDeNomes.Count; i++)
    {
        Console.WriteLine($"Aluno: {listaDeNomes[i]}");
    }*/

    foreach(string nome in listaDeNomes)
    {
        Console.WriteLine($"Aluno: {nome}");
    }


    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();


    
}























/*for(int i = 0; i < mensagemDeBoasVindas[i]; i++)
{
    Console.Write("*");

}*/