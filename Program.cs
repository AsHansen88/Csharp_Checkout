using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    static void Main(string[] args){

        var billigPrisberegner = new BilligPrisBeregner();
        var dyrPrisberegner = new DyrPrisBeregner();

        VareScannetHandler billigHandler = billigPrisberegner.BehandlerScannetVare;
        VareScannetHandler dyrHandler = dyrPrisberegner.BehandlerScannetVare;

        char[] scannedVarer = { 'B', 'A', 'B', 'C', 'A', 'A', 'C', 'B' };

        foreach (char vareKode in scannedVarer)
        {
            billigHandler(vareKode);
            dyrHandler(vareKode);
            System.Threading.Thread.Sleep(500);
        }

        billigPrisberegner.UdskrivPris();
        dyrPrisberegner.UdskrivPris();
    }
}


