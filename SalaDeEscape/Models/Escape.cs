public static class Escape
{
    static string[] incognitasSalas;
    static int estadoJuego=1;


    //Métodos
    private static void InicializarJuego()
    {
        incognitasSalas = new string[5];

        incognitasSalas[0] = "XIX";
        incognitasSalas[1] = "Geronima Garrizzo";
        incognitasSalas[2] = "Banco de La Nación Argentina";
        incognitasSalas[3] = "5267689";
        incognitasSalas[4] = "ganastE";

    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {   
        if (incognitasSalas[0]=="")
        {
            InicializarJuego();
        }
        
        if (Sala==estadoJuego)
        {
            if (Incognita==incognitasSalas[Sala])
            {
                estadoJuego++;
                return true;
            }
            else
            {
                return false;
            }
        }
        else return false;
        
    }
}
