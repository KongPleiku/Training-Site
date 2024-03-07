namespace Single_responsibility_principle;
class PlayerObj
{
    Movement movement;
    PlayerAnimation animation;

    Input input; 

    static void Main(string[] args)
    {
        while(true){
            Console.WriteLine("running.....");
        }
    }

    void update(){
        input.getInput();
        movement.Move(10f,this);
        animation.PlayAnimation(this);
    }
}

class Movement{
    public void Move(float speed, PlayerObj p){
        Console.Write("Moved");
    }
}

class PlayerAnimation{
    public void PlayAnimation(PlayerObj p){
        Console.Write("Played");
    }
}

class Input{
    public void getInput(){
        Console.Write("Enter Input: ");
        string input = Console.ReadLine();

        if(input == "play"){
            Console.WriteLine("Executed! ");
        }
    }
}
