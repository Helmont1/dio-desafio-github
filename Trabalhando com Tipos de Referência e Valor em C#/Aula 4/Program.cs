using static System.Console;

var a = new Numero(2);
var b = new Numero(2);

if(a.N == b.N){
    WriteLine("a is equal to b");
} else {
    WriteLine("a is not equal to b");
}


class Numero {
    public int N { get; set; }
    public Numero(int n) {
        N = n;
    }

}