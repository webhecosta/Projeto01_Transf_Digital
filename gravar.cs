using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

public class Gravar{ 
   //DECLARAR O TIPO DAS VARIAVEIS QUE RECEBERÃO O ARQUIVO
   StreamWriter x,escrita;

  public void gravartxt(){  

      //BUSCANDO DATA ATUAL
     // DateTime thisDay = DateTime.Today;    
     DateTime thisDay = DateTime.Now;
     Console.WriteLine(thisDay.ToString("u"));


    //DECLARAÇÃO DE VARIÁVEIS
    string cpfDigitado,nome;
    bool cpfValidado;
    int executa = 1;
    bool retornoCad;
   

  //INSTANCIADO A CLASSE
    ValidaCPF valida = new ValidaCPF();
    Consulta cons = new Consulta();
    Multa multa = new Multa();
     

    //PASSANDO O CAMINHO DO ARQUIVO EXISTENTE
    string arquivo = @"pessoa.txt";

    //SE O ARQUIVO EXISTIR ELE NÃO VAI CRIAR NOVAMENTE
     if (File.Exists(arquivo)) {
         
        
        escrita = File.AppendText(arquivo);
        

    }else{
       //CRIAR ARQUIVO 
       StreamWriter escrita = new StreamWriter("pessoa.txt");

    }
   
   
    while (executa != 0){  

    //LENDO O CPF DIGITADO   
    Console.WriteLine ("Qual o número do seu CPF");
    cpfDigitado = Console.ReadLine();
    cpfValidado = (valida.IsCpf(cpfDigitado) ) ;    


    //VALIDANDO O CPF
    if (cpfValidado == true){

      //VERIFICAR SE JÁ EXISTE CADASTRO DE ENTREGA COM ESTE CPF
      retornoCad = cons.consulta(cpfDigitado);
     

      if (retornoCad == true){

        Console.WriteLine("A pessoa cadastrada com este CPF já recebeu a máscara!\n Será multado por não utilizar a proteção obrigatória!");
        multa.multatxt(cpfDigitado);

      }else{

        
      //LENDO NOME
      Console.WriteLine ("Qual o seu nome ?");
      nome = Console.ReadLine();    

      //ESCREVER NO ARQUIVO
      escrita.WriteLine(cpfDigitado + ";" + nome + ";"+"1"+ ";" + thisDay.ToString("u")) ;

      Console.WriteLine ("Máscara entregue : {0}",nome);
      
      //PERGUNTANDO SE DESEJA CADASTRAR MAIS ENTREGAS
      Console.WriteLine ("Deseja cadastrar novamente ? 1 para SIM | 0 - Para Não ");
      executa = int.Parse(Console.ReadLine());

      //SALVANDO E FECHANDO O ARQUIVO A CADA INSERÇÃO DE CPF
      escrita.Close();  
      Console.ReadKey();
        
        
      }



    }else if(cpfValidado == false){

      Console.WriteLine ("CPF INVÁLIDO!");

    }else{
      Console.WriteLine ("ERRO AO VALIDA CPF!");
    }  


   }


     cons.exibirCadastro();
  
  }


  

 

}