using Razorvine.Pyro;

class Program
{
    static void Main(string[] args)
    {
        using (NameServerProxy ns = NameServerProxy.locateNS(null))
        {
            using PyroProxy something = new(ns.lookup("Abc.Bolinhas"));

            // realiza a invocação remota dos métodos
            Console.WriteLine("<<<<< teste função getNumeroSorte() >>>>>>>>>");
            something.call("getNumeroSorte"); // Este não exibe o resultado
            Console.WriteLine("Seu número da sorte é: {0}", something.call("getNumeroSorte"));

            Console.WriteLine("<<<<< teste função getSoma() >>>>>>>>>");
            int a = 90, b = 21;
            Console.WriteLine("{0} + {1} = {2}", a, b, something.call("getSoma", a, b));

            Console.WriteLine("<<<<< teste função listarDiretorio() >>>>>>>>>");
            string diretorio = "./teste";
            dynamic x = something.call("listarDiretorio", diretorio);
            Console.WriteLine("{0}", string.Join(", ", x.ToArray()));
        }
    }
}