using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

public class Multa{ 
   //DECLARAR O TIPO DAS VARIAVEIS QUE RECEBERÃO O ARQUIVO
   StreamWriter escrita;

  public void multatxt(string cpf){  

    
     DateTime thisDay = DateTime.Now;
     Console.WriteLine(thisDay.ToString("u"));

  
    //PASSANDO O CAMINHO DO ARQUIVO EXISTENTE
    string arquivo = @"listamulta.txt";

    //SE O ARQUIVO EXISTIR ELE NÃO VAI CRIAR NOVAMENTE
     if (File.Exists(arquivo)) {
         
       
        escrita = File.AppendText(arquivo);
        

    }else{
       //CRIAR ARQUIVO
       
      StreamWriter escrita = new StreamWriter("listamulta.txt");    
      escrita.WriteLine(" CPF; QUANTIDADE; VALOR MULTA; DATA") ;
      escrita.Close(); 

     
    }
   
      //ESCREVER NO ARQUIVO
      escrita.WriteLine(cpf + ";"+"1"+ ";" +"100,00" +";"+ thisDay.ToString("u")) ;

      Console.WriteLine ("Máscara entregue ao CPF : {0} Porém a multa de R$ 100,00 foi aplicada",cpf);   

      //FECHAR E SALVAR OS DADOS NO ARQUIVO
      escrita.Close();  
      Console.ReadKey();

  
  }


  

 

}