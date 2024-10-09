//main
class Program{
    static void Main(){
        while(true){
            MenuInterface();
            string userChoice = OpenMainMenu();
            UserChoice(userChoice);
        }
    }
//end main
    static void MenuInterface(){ //menu
        System.Console.Clear();
        System.Console.WriteLine("Welcome to the Crimson Crust\nPlease select a menu choice\n1.Plain Pizza\n2.Cheese Pizza\n3.Pepperoni Pizza\n4.Exit");
    }

    static string OpenMainMenu(){
        return(System.Console.ReadLine());
    }

    static void UserChoice(string userChoice){
        switch(userChoice){
            case "1":
                PlainPizza();
                break;
            case "2":
                CheesePizza();
                break;
            case "3":
                PepPizza();
                break;
            case "4":
                Exit();
                break;
            default:
                System.Console.WriteLine("Invalid menu selection.");
                Pause();
                break;
        }
    }

    static void PlainPizza(){
        System.Console.Clear();
        System.Console.WriteLine("ONE PLAIN PIZZA:)\n");

        Random rnd = new Random(); 
        int rows = rnd.Next(8, 12); // random number between 8 and 12
        
        for(int i = rows; i >= 1; i--){
            for(int j = 1; j < rows + 1; j++){
                System.Console.Write(" ");
            }
             for(int k = 1; k <= i; k++){
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }
        Pause();
    }

    static void CheesePizza(){
        System.Console.Clear();
        System.Console.WriteLine("ONE CHEESE PIZZA:)\n");

        Random rnd = new Random(); 
        int rows = rnd.Next(8, 12); // random number between 8 and 12
        
        for(int i = rows; i >= 1; i--){
            for(int j = 1; j < rows + 1; j++){
                System.Console.Write(" ");
            }
            for(int k = 1; k <= i; k++){
                if(i == 1 || i == rows || k == 1 || k == i){ 
                    System.Console.Write("* "); //crust
                }
                else{
                    System.Console.Write("# "); //cheese
                }
            }
            System.Console.WriteLine();
        }
        Pause();
    }

    static void PepPizza(){
        System.Console.Clear();
        System.Console.WriteLine("ONE PEPPERONI PIZZA:)\n");

        Random rnd = new Random(); 
        int rows = rnd.Next(8, 12); // random number between 8 and 12
        
        for(int i = rows; i >= 1; i--){
            for(int j = 1; j < rows + 1; j++){
                System.Console.Write(" ");
            }
            for(int k = 1; k <= i; k++){
                if(i == 1 || i == rows || k == 1 || k == i){ 
                    System.Console.Write("* ");
                }
                else{
                    if(rnd.Next(0, 10) == 0){ //random number of pepperonis
                        System.Console.Write("[]"); //pepperoni
                    }
                    else{
                        System.Console.Write("# "); //cheese
                    }
                }
            }
            System.Console.WriteLine();
        }
        Pause();
    }

    static void Pause(){
        System.Console.WriteLine("\nPress any key to return to Menu.\n");
        System.Console.ReadKey();
    }

    static void Exit(){
        System.Console.WriteLine("Thank you for picking Crimson Crust. :)\n");
        System.Environment.Exit(0);
    }
}