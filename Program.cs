using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    static void Main(string[] args){

        var billigPrisberegner = new BilligPrisBeregner();
        var dyrPrisberegner = new DyrPrisBeregner();

        VareScannetHandler billigHandler = billigPrisberegner.BehandlerScannetVare;
        VareScannetHandler dyrHandler = dyrPrisberegner.BehandlerScannetVare;

        Console.WriteLine("Indtast varenavne (et ad gangen). Skriv 'exit' for at afslutte og se priser.");

        string input;
        while((input = Console.ReadLine()) != "exit"){
            if(!string.IsNullOrWhiteSpace(input) && input.Length == 1){
                char vareKode = input[0];
                billigHandler(vareKode);
                dyrHandler(vareKode);
            }
            else{
                Console.WriteLine("Ugyldigt input. Indtast venligst et enkelt bogstav for varen.");
            }
        }

        billigPrisberegner.UdskrivPris();
        dyrPrisberegner.UdskrivPris();
    }
}


