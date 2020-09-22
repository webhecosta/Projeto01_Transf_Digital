using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


public class Consulta{
  //DECLRAÇÃO DE VARÁVEIS
  bool retornoCad;
  string line; 
  int startIndex = 0;
  int length = 11; 
  int counter = 0;  // ESSE CONTADOR É PARA IDENTIFICAR O CABEÇALHO DO ARQUIVO 

  //FUNÇÃO PARA CONSULTAR ENTREGA DE MÁSCARA
  public bool consulta(string cpf){
  
 //PREPARANDO O ARQUIVO EXISTENTE PARA LEITURA
  System.IO.StreamReader file =
      new System.IO.StreamReader("pessoa.txt"); 
  
  while((line = file.ReadLine()) != null)  
  {  
      String substring = line.Substring(startIndex, length);
    

      if (substring == cpf ){          
    
        return true;
                
      }    


        
  }

    return false;  
      
  file.Close();  
   

  }

  //FUNÇÃO PARA EXIBIR OS CPFs QUE JÁ RECEBERAM A MÁSCARA
  public void exibirCadastro(){


      // Read the file and display it line by line.  
    System.IO.StreamReader file =
        new System.IO.StreamReader("pessoa.txt"); 
   Console.WriteLine("########CPF's Cadastrados############");
    while((line = file.ReadLine()) != null)  
    {  
        if(counter == 0){

        }else{
          // PEGANDO O CPF ATRAVÉS DE TAMANHO DE CARACTER
           String substring = line.Substring(startIndex, length);
           Console.WriteLine(substring);

        }
        

        counter ++;
     }

    file.Close(); 


  }



} 