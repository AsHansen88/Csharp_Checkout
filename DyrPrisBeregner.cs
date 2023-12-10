using System.Runtime.CompilerServices;
using System.Security;

class DyrPrisBeregner : IPrisBeregner {

    private List<Vare> solgteVarer = new List<Vare>();
    public void BehandlerScannetVare(char varekode){

    var varer = new List<Vare>{
        new Vare {navn = "Vare A", kode ='A', pris = 50, varegruppe= 1},
        new Vare {navn = "Vare B", kode ='B', pris = 20, varegruppe= 2},
        new Vare {navn = "Vare C", kode ='C', pris = 10, varegruppe= 3},
        new Vare {navn = "Vare D", kode ='D', pris = 60, varegruppe= 4},
        new Vare {navn = "Vare E", kode ='E', pris = 70, varegruppe= 5},
        new Vare {navn = "Vare F", kode ='F', pris = 30, varegruppe= 7},
        new Vare {navn = "Vare G", kode ='G', pris = 20, varegruppe= 8},
        new Vare {navn = "Vare H", kode ='H', pris = 60, varegruppe= 9},
        new Vare {navn = "Vare I", kode ='I', pris = 50, varegruppe= 1},
        new Vare {navn = "Vare J", kode ='J', pris = 50, varegruppe= 2},
        new Vare {navn = "Vare K", kode ='K', pris = 80, varegruppe= 3},
        new Vare {navn = "Vare L", kode ='L', pris = 20, varegruppe= 4},
        new Vare {navn = "Vare M", kode ='M', pris = 70, varegruppe= 5},
        new Vare {navn = "Vare N", kode ='N', pris = 80, varegruppe= 6},
        new Vare {navn = "Vare O", kode ='O', pris = 10, varegruppe= 7},
        new Vare {navn = "Vare P", kode ='P', pris = 30, varegruppe= 8},
        new Vare {navn = "Vare Q", kode ='Q', pris = 10, varegruppe= 9},
        new Vare {navn = "Vare R", kode ='R', pris = 40, varegruppe= 1},
        new Vare {navn = "Vare S", kode ='S', pris = 40, varegruppe= 2},
        new Vare {navn = "Vare T", kode ='T', pris = 50, varegruppe= 3},
        new Vare {navn = "Vare U", kode ='U', pris = 70, varegruppe= 4},
        new Vare {navn = "Vare V", kode ='V', pris = 50, varegruppe= 5},
        new Vare {navn = "Vare W", kode ='W', pris = 80, varegruppe= 6},
        new Vare {navn = "Vare X", kode ='X', pris = 20, varegruppe= 7},
        new Vare {navn = "Vare Y", kode ='Y', pris = 10, varegruppe= 8},
        new Vare {navn = "Vare Z", kode ='Z', pris = 10, varegruppe= 8}
    };

    var vare = varer.FirstOrDefault(v => v.kode == varekode);
    if(vare != null)
    {
        solgteVarer.Add(vare);
    }
}

public void UdskrivPris(){
    var grupperetVarer = solgteVarer.GroupBy(v => v.varegruppe)
            .Select(g => new { Varegruppe = g.Key, AntalStyk = g.Sum(v => 1) });

        Console.WriteLine("Solgte varer (Dyr):\n");
        foreach (var gruppe in grupperetVarer)
        {
            Console.WriteLine($"Varegruppe {gruppe.Varegruppe}: {gruppe.AntalStyk} stk");
        }
    }
}