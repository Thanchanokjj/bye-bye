class Program
{
    public static Tree<string> Byena = new Tree<string>();
    public static Stack<string> labor = new Stack<string>();



    public static void Getperson(string lastpers){
        int person = int.Parse(Console.ReadLine());
        if(person != 0){

            string senior = Console.ReadLine();
            Byena.AddChild(lastpers , senior);
            Getperson(senior);
            labor.Push(senior);

            if(person >= 1){
                for(int i = 1 ; i < person ; i++){
                    string henchman = Console.ReadLine();
                    Byena.AddSibling(labor.Pop() , henchman);
                    Getperson(henchman);
                    labor.Push(henchman);
                }
            }
        }
    }
    static void Main(string[] args){
        string bigboss = Console.ReadLine();
        Byena.AddChild(null , bigboss);
        Getperson(bigboss);
        string target = Console.ReadLine();
        Queue<string> senior = Byena.ShowBigboss(target);
        int i = 0;
        while(i <= senior.GetLength()){
            Console.WriteLine(senior.Pop());
            i++;
        }
    }
}