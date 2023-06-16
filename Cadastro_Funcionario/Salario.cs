using System; 

public class Salario
{
    public string nome;
    public string salario;
    public string cpf;
    public string matricula;
    public string funcao;


    public Salario(string nome, string salario, string cpf, string matricula, string funcao)
    {
        this.nome = nome;
        this.salario = salario;
        this.cpf = cpf;
        this.matricula = matricula;
        this.funcao = funcao;
       
    }
}