class Program
{
    public static Tree<string> panpang = new Tree<string>();
    public static Stack<string> coop = new Stack<string>();



    public static void GetPeople(string lastpers){
        int people = int.Parse(Console.ReadLine());
        if(people != 0){

            string tuetueng1 = Console.ReadLine();
            panpang.AddChild(lastpers , tuetueng1);
            GetPeople(tuetueng1);
            coop.Push(tuetueng1);

            if(people >= 1){
                for(int i = 1 ; i < people ; i++){
                    string tuetueng2 = Console.ReadLine();
                    panpang.AddSibling(coop.Pop() , tuetueng2);
                    GetPeople(tuetueng2);
                    coop.Push(tuetueng2);
                }
            }
        }
    }
    static void Main(string[] args){
        string bosses = Console.ReadLine();
        panpang.AddChild(null , bosses);
        GetPeople(bosses);
        string output = Console.ReadLine();
        Queue<string> nani = panpang.ShowUpper(output);
        int i = 0;
        while(i <= nani.GetLength()){
            Console.WriteLine(nani.Pop());
            i++;
        }
    }
}