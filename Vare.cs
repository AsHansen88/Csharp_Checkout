using System.Dynamic;
using System.Runtime.CompilerServices;

class Vare{
    public String navn {get;set;}
    public char kode {get;set;}
    public int pris {get;set;}
    public int varegruppe {get;set;}

}

delegate void VareScannetHandler(Char varekode);

interface IPrisBeregner{
    void BehandlerScannetVare(char varekode);
    void UdskrivPris();
}