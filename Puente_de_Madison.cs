class Puente_de_Madison
{

    public static bool ValidarDescripcion(string descripcion)
    {
        
        descripcion = descripcion.Replace(" ", "");
        int n = descripcion.Length;

        if (descripcion == "**") return true;

     
        if (n < 3) return false;

        if (descripcion[0] != '*' || descripcion[n - 1] != '*') return false;

      
        string izquierda = descripcion.Substring(0, n / 2);
        string derecha = descripcion.Substring((n + 1) / 2);
        char[] derechaReversa = derecha.ToCharArray();
        Array.Reverse(derechaReversa);
        if (izquierda != new string(derechaReversa)) return false;

        if (descripcion.Contains("==="))
        {
       
            if (!(n % 2 == 1 && descripcion.Substring(n / 2 - 1, 3) == "==="))
                return false;
        }

        for (int i = 1; i < n - 1; i++)
        {
            if (descripcion[i] == '=' && descripcion[i - 1] == '=')
            {
                
                bool refuerzoIzq = (i - 2 >= 0 && descripcion[i - 2] == '+');
                bool refuerzoDer = (i + 1 < n && descripcion[i + 1] == '+');
                if (!refuerzoIzq && !refuerzoDer)
                    return false;
            }
        }

        return true;
    }
}
