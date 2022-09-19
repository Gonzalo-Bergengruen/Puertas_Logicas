namespace Compuertas
{
    public class AND
    {
        public String Nombre {get; set;}
        public Boolean Valor {get; set;}

        public AND (string nombre, Boolean valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
        }
        public List<AND> AgregarMetodo(string nombre, Boolean valor, List<AND> Compuertas)
        {
            AND and1 = new AND(nombre, valor);
            if (Compuertas.Count == 0)
            {
            Compuertas.Add(and1);
            } else {
                for (int i = 0; i <= Compuertas.Count; i++)
                {
                    if (Compuertas[i].Nombre == and1.Nombre)
                    { 
                        Compuertas.Remove(Compuertas[i]);
                    } 
                }
            Compuertas.Add(and1);
            }
            return Compuertas;
        }
    }
}