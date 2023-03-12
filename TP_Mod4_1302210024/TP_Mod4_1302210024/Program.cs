// See https://aka.ms/new-console-template for more information
using System;

public class KodePos
{
    public static string getKodePos(string kelurahan)
    {
        switch (kelurahan)
        {
            case "Batununggal":
                return "40266";
            case "Kujangsari":
                return "40287";
            case "Mengger":
                return "40267";
            case "Wates":
                return "40256";
            case "Cijaura":
                return "40287";
            case "Jatisari":
                return "40286";
            case "Margasari":
                return "40286";
            case "Sekejati":
                return "40286";
            case "Kebonwaru":
                return "40272";
            case "Maleer":
                return "40274";
            case "Samoja":
                return "40273";
            default:
                return "Kode pos tidak ditemukan";
        }
    }
}

public enum DoorState
{
    Terkunci,
    Terbuka
}

public class DoorMachine
{
    private readonly Action[] _stateActions;
    public DoorState currentState { get; private set; }

    public DoorMachine()
    {
        _stateActions = new Action[] { TerkunciAction, TerbukaAction };
        currentState = DoorState.Terkunci;
        _stateActions[(int)currentState]();
    }

    public void Lock()
    {
        currentState = DoorState.Terkunci;
        _stateActions[(int)currentState]();
    }

    public void Unlock()
    {
        currentState = DoorState.Terbuka;
        _stateActions[(int)currentState]();
    }

    private void TerkunciAction()
    {
        Console.WriteLine("Pintu terkunci");
    }

    private void TerbukaAction()
    {
        Console.WriteLine("Pintu tidak terkunci");
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kelurahan              Kode pos");
        Console.WriteLine();
        Console.WriteLine("Kode pos Batununggal : " + KodePos.getKodePos("Batununggal"));
        Console.WriteLine("Kode pos Kujangsari : " + KodePos.getKodePos("Kujangsari"));
        Console.WriteLine("Kode pos Mengger : " + KodePos.getKodePos("Mengger"));
        Console.WriteLine("Kode pos Wates : " + KodePos.getKodePos("Wates"));
        Console.WriteLine("Kode pos Cijaura : " + KodePos.getKodePos("Cijaura"));
        Console.WriteLine("Kode pos Jatisari : " + KodePos.getKodePos("Jatisari"));
        Console.WriteLine("Kode pos Margasari : " + KodePos.getKodePos("Margasari"));
        Console.WriteLine("Kode pos Sekejati : " + KodePos.getKodePos("Sekejati"));
        Console.WriteLine("Kode pos Kebonwaru : " + KodePos.getKodePos("Kebonwaru"));
        Console.WriteLine("Kode pos Maleer : " + KodePos.getKodePos("Maleer"));
        Console.WriteLine("Kode pos Samoja : " + KodePos.getKodePos("Samoja"));

        Console.WriteLine();

        DoorMachine doorMachine = new DoorMachine();
        doorMachine.Lock();
        doorMachine.Unlock();
        doorMachine.Lock();

    }
}

