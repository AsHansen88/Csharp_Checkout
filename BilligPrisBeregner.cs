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
            {'L', 70},
            {'M', 80},
            {'N', 10},
            {'O', 30},
            {'P', 10},
            {'Q', 40},
            {'R', 40},
            {'S', 50},
            {'T', 70},
            {'U', 50},
            {'V', 80},
            {'W', 30},
            {'X', 20},
            {'Y', 10},
            {'Z', 10}
            
            
        };

        if(prisListe.ContainsKey(varekode)){
            totalPris += prisListe[varekode];
        }
    }

    public void UdskrivPris(){
        Console.WriteLine($"Total pris (Billig): {totalPris} kr");
    }
}