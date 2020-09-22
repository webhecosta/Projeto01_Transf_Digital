using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


public class Consulta{

  bool retornoCad;
  string line; 
  int startIndex = 0;
  int length = 11; 
  int counter = 0;   

  public bool consulta(string cpf){
  
  // Read the file and display it line by line.  
  System.IO.StreamReader file =
      new System.IO.StreamReader("pessoa.txt"); 
  
  while((line = file.ReadLine()) != null)  
  {  
      String substring = line.Substring(startIndex, length);
      //Console.WriteLine(substring);

      if (substring == cpf ){          
    
        return true;
                
      }    

      // System.Console.WriteLine(line);  
        
  }

    return false;  
      
  file.Close();  
   

  }

  public void exibirCadastro(){


      // Read the file and display it line by line.  
    System.IO.StreamReader file =
        new System.IO.StreamReader("pessoa.txt"); 
   Console.WriteLine("########CPF's Cadastrados############");
    while((line = file.ReadLine()) != null)  
    {  
        if(counter == 0){

        }else{

           String substring = line.Substring(startIndex, length);
           Console.WriteLine(substring);

        }
        

        counter ++;
     }

    file.Close(); 


  }



} 