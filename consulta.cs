using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


public class Consulta{

   bool retornoCad;

   public bool consulta(string cpf){
    
    int counter = 0;  
    string line; 
    int startIndex = 0;
    int length = 11;      
      
    // Read the file and display it line by line.  
    System.IO.StreamReader file =
        new System.IO.StreamReader("pessoa.txt");  
    while((line = file.ReadLine()) != null)  
    {  
        String substring = line.Substring(startIndex, length);
        Console.WriteLine(substring);

        if (substring == cpf ){
         
          retornoCad =  true;
          
        }else{
         
          retornoCad =  false;

        }
       // System.Console.WriteLine(line);  
        counter++;  
    }

    return retornoCad;  
      
    file.Close();  
    //System.Console.WriteLine("There were {0} lines.", counter);  
    // Suspend the screen.  
    //System.Console.ReadLine();

    

  }



} 