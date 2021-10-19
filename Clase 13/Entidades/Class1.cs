using System;

namespace Entidades
{
    public class Class1 : Class2, IMiInterfaz
    {
        int Propiedad { get { return 4; } set => throw new NotImplementedException(); }
        
        List<int> 
        public string Saludar()
        {
            return "oli";
        }
    }
}
