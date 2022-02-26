static void ciclos()
{
    int x = 1;
    while(x <=100)
    {
        Console.WriteLine($"num con while={x}");
        x++;
    }

    do
    {
        Console.WriteLine($"con DO {x}");
        x--;
    } while(x >=0);

}


static void calculadoraCase()
{
    float a = 0.0f;
    float b = 0.0f;
    float resultado = 0.0f;
    string valor = "";
    int opcion = 0;


    while (opcion != 5)
    {
        Console.WriteLine("1.- Suma");
        Console.WriteLine("2.- Resta");
        Console.WriteLine("3.- Division");
        Console.WriteLine("4.- Multiplicacion");
        Console.WriteLine("5.- Salir");
        Console.Write("Ingrese la Operacion que quiere hacer:");
        valor = Console.ReadLine();
        opcion = Convert.ToInt32(valor);



        //get first value
        Console.Write("Dame numero 1:");
        valor = Console.ReadLine();
        a = Convert.ToSingle(valor);
        Console.Write("Dame el numero 2:");
        valor = Console.ReadLine();
        b = Convert.ToSingle(valor);
        //verificar que quiere hacer el cuate




        switch (opcion)
        {
            case 1:
                resultado = a + b;
                break;
            case 2:
                resultado = a - b;
                break;
            case 3:
                if (b != 0)
                {
                    resultado = a / b;
                }
                else
                {
                    Console.WriteLine("no se puede 0");
                }
                break;
            case 4:
                resultado = a * b;
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }

}


static void contraseña()
{
    byte oportunidades, TienePermiso;
    string clave;
    oportunidades = TienePermiso = 0;

    do
    {
        Console.WriteLine("Ingrese la Clave");
        clave = Console.ReadLine();
        if (clave.ToLower() == "navi")
        {
            TienePermiso = 1;
        }
        else
        {
            Console.WriteLine("No es la clave");
            oportunidades++;
        }
    } while (((oportunidades < 3) & (TienePermiso == 0)));

    if (TienePermiso == 1)
    {
        Console.WriteLine("Bienvenido puede entrar");
        calculadoraCase();
    }
    else
    {
        Console.WriteLine("Se terminaron las oportunidades");
    }
}

static void adivina()
{
    const int oportunidades = 4;
    int NumeroCPU, NumerosUsuarios;
    byte Intentos, BanderasControl;
    string linea;
    Intentos = BanderasControl = 0;

    Random ran = new Random();

    do
    {
        NumeroCPU = Convert.ToInt32(ran.Next(100));
    } while (!(((NumeroCPU >= 1) & (NumeroCPU < 20))));

    Console.WriteLine($"shh {NumeroCPU}");

    do
    {
        Console.WriteLine("Que numero crees que pienso");
        linea = Console.ReadLine();
        NumerosUsuarios = int.Parse(linea);

        if (NumerosUsuarios == NumeroCPU)
        {
            Console.WriteLine("Bieeen !!");
            BanderasControl = 1;

        }
        else
        {
            if (NumerosUsuarios > NumeroCPU)
            {
                Console.WriteLine("Te pasaste");
            }
            else
            {
                Console.WriteLine("Estas abajo");
            }

        }
        Intentos++;
    } while (((Intentos <= oportunidades) & (BanderasControl == 0 )));
    if (BanderasControl == 0)
    {
        Console.WriteLine($"Ese numero era {NumeroCPU}");
    }

    Console.WriteLine("Si te gusto dale like");
}

//adivina();

//ciclos();

//calculadoraCase();

//contraseña();
