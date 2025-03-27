namespace chapter01
{
    public class ProjectGames
    {
        public static void ReadValueOut(out string ms) 
        {
            // out devuelve un parametro y no necesariamente debe estar inicialziado para ser modificado
            // dentro del metodo. pero debe ser inicializado antes de ser usado.
            ms = "Hello Bejamin";

            Console.WriteLine($"the message in {ms}");
        }

        public static void ReadValueRef(ref string ms)
        {
            // ref permite devolver un parametro como referecia sin estar inicializado,
            // puede ser inicializado en el metodo o no. 
            Console.WriteLine($"the message ms  {ms} without modifier");
            ms = "Ref Modificado";
        }

        public static void ReadValueIn(in int msCount)
        {
            // in permite devolver un parametro pero no puede ser modificado dentro del metodo,
            // solo lectura
            //error:  ms = "Hello Be";
            Console.WriteLine($"the message count is {msCount + 5}");
        }

        public static async Task Way() 
        {
            Console.WriteLine("Init The call");
            await Task.Delay(2000);
            Console.WriteLine("End The call");
        }

        public static async Task<string> WayWithReturn()
        {
            Console.WriteLine("Init The call");
            await Task.Delay(2000);
            Console.WriteLine("End The call");
            return "The call is done";
        }

    }
}
