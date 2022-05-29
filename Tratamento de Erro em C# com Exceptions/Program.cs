using namespace namespace Tratamento_de_Erro_em_C#_com_Exceptions.Entities;


internal class Program
{
    private static void Main(string[] args)
    {
        static double Dividir(int x, int y)
        {
            if (y == 0)
            {
                throw new MyClassException("Minha mensagem customizada de erro!");
            }
            return x / y;
        }

        int a = 100, b = 0;
        double resultado = 0;

        try
        {
            resultado = Dividir(a, b);
            Console.WriteLine($"{a} dividido por {b} = {resultado}");
        }
        catch (DivideByZeroException ex) when (a < 0)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finalmente a divisao foi finalizada");
        }
    }
}