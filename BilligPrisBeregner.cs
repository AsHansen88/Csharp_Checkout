class BilligPrisBeregner : IPrisBeregner{
    private int totalPris = 0;

    public void BehandlerScannetVare(char varekode){
        
        Dictionary<char, int> prisListe = new Dictionary<char, int>{
            {'A', 50},
            {'B', 30},
            {'C', 30},
            {'D', 30},
            {'E', 30},
            {'F', 30},
            {'G', 30},
            {'H', 30},
            {'I', 30},
            {'J', 30},
            {'K', 30},
            {'L', 30},
            {'M', 30},
            {'N', 30},
            {'O', 30},
            {'P', 30},
            {'Q', 30},
            {'R', 30},
            {'S', 30},
            {'T', 30},
            {'U', 30},
            {'V', 30},
            {'W', 30},
            {'X', 30},
            {'Y', 30},
            {'Z', 30}
            
            
        };

        if(prisListe.ContainsKey(varekode)){
            totalPris += prisListe[varekode];
        }
    }

    public void UdskrivPris(){
        Console.WriteLine($"Total pris (Billig): {totalPris} kr");
    }
}