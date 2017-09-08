using BoletoOnline.Class;
using BoletoOnline.Class.Objetos;

namespace BoletoOnline.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RemessaCobrancaOnlineService tt = new RemessaCobrancaOnlineService();

            tt.AssinarCriptografar(new EnvioRemessaCobrancaBradescoJson());
        }
    }
}
