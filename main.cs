using System;
class MainClass {
  public static void Main () {
    //VARIÁVEIS
    bool ResultConsultaEntraga;
    bool ResultConsultaMulta;
    //INSTANCIAR E CHAMAR CLASSE
    Gravar cad = new Gravar();     

    //INSTANCIAR CLASSE CONSULTA
    Consulta cons = new Consulta();
 
    //MENU DE OPÇÕES
    Console.WriteLine ("------------------------------");
    Console.WriteLine ("1 - CONSULTAR ENTREGA DE MÁSCARA");
    Console.WriteLine ("2 - ENTREGAR MÁSCARA");
    Console.WriteLine ("3 - CONSULTAR MULTA");
    Console.WriteLine ("------------------------------");
    
    //CONVERSÃO DE STRING PARA INTEIRO
    int opcao = int.Parse(Console.ReadLine());
    //LISTA DE OPÇÕES DENTRO DE CASE'S
    switch (opcao){    
      case 1:
        Console.WriteLine("Digite o CPF para consulta"); 
        ResultConsultaEntraga = cons.consulta(Console.ReadLine());
        if(ResultConsultaEntraga){
          Console.WriteLine("Este CPF já recebeu a máscara!");
        }else{
          Console.WriteLine("Este CPF não recebeu a máscara!");
        }
        break;
      case 2:
        Console.WriteLine("Entregar Máscara!");
        cad.gravartxt();
        break;

      case 3:
        Console.WriteLine("Digite o CPF para consultar se já existe multa!!");
        ResultConsultaMulta = cons.consultaMulta(Console.ReadLine());

        if(ResultConsultaMulta){

          Console.WriteLine("Este CPF já recebeu multa!");
        }else{
           Console.WriteLine("Este CPF não recebeu multa!"); 
        }        
     
        break;      
      default:
        Console.WriteLine("Você não digitou nenhuma opção ou Opção inválida");
        break;
    }    


  }
}