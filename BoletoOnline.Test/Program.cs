using BoletoOnline.Class;
using BoletoOnline.Class.Objetos;

namespace BoletoOnline.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RemessaCobrancaOnlineService teste = new RemessaCobrancaOnlineService();

            teste.AssinarCriptografar(new EnvioRemessaCobrancaBradescoJson());
        }
    }
}
