class BilligPrisBeregner : IPrisBeregner{
    private int totalPris = 0;

    public void BehandlerScannetVare(char varekode){
        
        Dictionary<char, int> prisListe = new Dictionary<char, int>{
            {'A', 50},
            {'B', 20},
            {'C', 10},
            {'D', 60},
            {'E', 70},
            {'F', 30},
            {'G', 20},
            {'H', 60},
            {'I', 50},
            {'J', 50},
            {'K', 80},
            {'L', 20},
            {'M', 70},
            {'N', 80},
            {'O', 10},
            {'P', 30},
            {'Q', 10},
            {'R', 40},
            {'S', 40},
            {'T', 50},
            {'U', 70},
            {'V', 50},
            {'W', 80},
            {'X', 20},
            {'Y', 10},
            {'Z', 10}
            
            
        };

        if(prisListe.ContainsKey(varekode)){
            totalPris += prisListe[varekode];
        }
    }

    public void UdskrivPris(){
        Console.WriteLine($"Total pris (Billig): {totalPris} kr\n");
    }
}