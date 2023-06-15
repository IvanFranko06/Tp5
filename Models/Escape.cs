using System.Collections.Generic;




static class Escape
{
    static string[] incognitasSalas = { "16", "A", "87", "mongolia" };


    static int estadoDelJuego = 0;


    






    public static int GetEstadoJuego()
    {


        return estadoDelJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {

        if (Sala != estadoDelJuego)
        {
            return false;
        }
        else
        {

            if (Incognita == incognitasSalas[estadoDelJuego])
            {
                estadoDelJuego++;
                return true;

            }
            else { return false; }
        }
    }


}