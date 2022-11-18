class Program
{
    static void HW_1(){
        CircularLinkedList<char> fower = new CircularLinkedList<char>(); 
        while(true){

            Console.Write("Input Fower {J,G,O,R}: ");
            char Fower_input = char.Parse(Console.ReadLine());

            if (Fower_input != 'J' && Fower_input != 'G' && Fower_input != 'O'&& Fower_input != 'R' ){
                break;
            }
            else{
                int Check_length = fower.GetLength();

                if(Check_length == 0){
                    if(Fower_input == 'R'){
                        Console.WriteLine("Invalid pattern.");
                    }
                    else{
                    fower.Add(Fower_input);
                    }
                }
                else if(Check_length >= 1){

                    if(Check_length <= 2){
                        if (fower.Get(-1) == 'R'){//เช็คระหว่าง R
                        if(Fower_input == fower.Get(-2) || Fower_input == 'R'){
                            Console.WriteLine("Invalid pattern.");}
                        else{
                            fower.Add(Fower_input);
                        }
                    }
                    else if(Fower_input == 'R'){ //เช็คกรอก R ห้ามกรอกติดกัน
                        if(Fower_input == fower.Get(-1)){
                            Console.WriteLine("Invalid pattern.");
                        }
                        else{
                            fower.Add(Fower_input);
                        }
                    }
                    else {
                        fower.Add(Fower_input);
                    }}

                    else if(Check_length >= 3){

                    if (fower.Get(-1) == 'R' && Fower_input == fower.Get(-2)){//เช็คระหว่าง R 
                        if (Fower_input == 'R'){
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if (Fower_input == fower.Get(-2)){
                            Console.WriteLine("Invalid pattern.");
                        }
                        else{
                            fower.Add(Fower_input);
                        }
                    }
                    else if(Fower_input == 'R'){ //เช็คกรอก R ห้ามกรอกติดกัน
                        if(Fower_input == fower.Get(-1)){
                            Console.WriteLine("Invalid pattern.");
                        }
                        else{
                            fower.Add(Fower_input);
                        }
                    }
                    else if(Fower_input == 'G'){ // เช็ค G ห้ามเกิน 4 
                        if(fower.Get(0) == 'G' && fower.Get(1) == 'G' && fower.Get(2) == 'G'){
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if(Fower_input == fower.Get(-1) && Fower_input == fower.Get(-2)&& Fower_input == fower.Get(-3)){
                            Console.WriteLine("Invalid pattern.");
                        }
                        else{
                            fower.Add(Fower_input);
                        }
                    }
                    else {
                        fower.Add(Fower_input);
                    }

                    }
            }
        }
        }
        Console.WriteLine("_____________________________________________________________________________");
        int print_fower = fower.GetLength();
        //Console.WriteLine(print_fower);
        int index = 0;
        while(index < print_fower){
            Console.Write(fower.Get(index));
            index++;
        }
        Console.WriteLine("");
    }
    static void Main(string[] args)
    {
        HW_1();
    }
}
