using System;


namespace Atividade11
{
public class Program{

	static string nome  ="";
	static float saldo = 0;

	public static void Main(string[] args){
		
		cadastro();
		consultar();
		apagarConta();
		Console.WriteLine("");
        Console.ReadKey();
	}
	
	
	static void  cadastro(){
		Console.WriteLine("Qual o seu nome?");
		nome = Console.ReadLine();
		
		Console.WriteLine("Qual o saldo?");
		saldo = float.Parse(Console.ReadLine());	
		
		Console.WriteLine("digite o valor a depositar?");
		float deposito = float.Parse(Console.ReadLine());	
		
		depositar(deposito);
		
		
		Console.WriteLine("digite o valor a sacar?");
		float saque = float.Parse(Console.ReadLine());	
	
		sacar(saque);
	}
	
	static void  consultar(){
		Console.WriteLine("Seu nome é:" + nome);
		Console.WriteLine("Seu saldo é:" + saldo);
	}
	
	static void  apagarConta(){
		nome = "";
		saldo = 0;
	}
	
	
	
	static void depositar(float deposito){
		saldo += deposito;
		
		Console.WriteLine("seu saldo agora é: "+ saldo);
	}
	

	static void sacar(float saque){
		if(saldo > saque){
			saldo = saldo- saque;
		}else{
			Console.WriteLine("saldo indisponivel");
		}
		
		Console.WriteLine("seu saldo agora é: "+ saldo);
	}
	
}

}