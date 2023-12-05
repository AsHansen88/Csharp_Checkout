using System.Runtime.CompilerServices;
using System.Security;

class DyrPrisBeregner : IPrisBeregner {

    private List<Vare> solgteVarer = new List<Vare>();
    public void BehandlerScannetVare(char varekode){

    var varer = new List<Vare>{
        new Vare {navn = "Vare A", kode ='A', pris = 50, varegruppe= 1},
        new Vare {navn = "Vare B", kode ='B', pris = 30, varegruppe= 2}
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

        Console.WriteLine("Solgte varer (Dyr):");
        foreach (var gruppe in grupperetVarer)
        {
            Console.WriteLine($"Varegruppe {gruppe.Varegruppe}: {gruppe.AntalStyk} stk");
        }
    }
}