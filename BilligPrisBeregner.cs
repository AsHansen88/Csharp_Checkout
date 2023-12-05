class BilligPrisBeregner : IPrisBeregner{
    private int totalPris = 0;

    public void BehandlerScannetVare(char varekode){
        
        Dictionary<char, int> prisListe = new Dictionary<char, int>{
            {'A', 50},
            {'B', 30}
        };

        if(prisListe.ContainsKey(varekode)){
            totalPris += prisListe[varekode];
        }
    }

    public void UdskrivPris(){
        Console.WriteLine($"Total pris (Billig): {totalPris} kr");
    }
}