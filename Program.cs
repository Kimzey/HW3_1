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
                    if(Fower_input == 'R'){//เช็ค R ตัวแรก
                        Console.WriteLine("Invalid pattern.");
                    }
                    else{
                    fower.Add(Fower_input);
                    }
                }
                else if(Check_length >= 1){

                    if(Check_length <= 2){
                        if(Check_length == 1 && Fower_input == 'R'){//ตัวที่สองห้ามเป็น R เดวมันติดตัวแรกทั้ง 2 ฝั่ง
                            Console.WriteLine("Invalid pattern.");} 
                        else if (fower.Get(-1) == 'R'&& Fower_input == fower.Get(-2)){//เช็คระหว่าง R
                            Console.WriteLine("Invalid pattern.");}     
                        else{
                            fower.Add(Fower_input);
                        }}

                    else if(Check_length >= 3){
                        if (fower.Get(-1) == 'R' && Fower_input == fower.Get(-2)){//เช็คระหว่าง R 
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if(Fower_input == 'G'){ // เช็ค G ห้ามเกิน 4
                            if(Fower_input == fower.Get(-1) && Fower_input == fower.Get(-2)&& Fower_input == fower.Get(-3)){//เช็ค G หลัง 3 ตัว ตัวล่าสุด ห้ามเป็น G
                                Console.WriteLine("Invalid pattern.");
                        }
                        else if(fower.Get(0) == 'G' && fower.Get(1) == 'G' && fower.Get(2) == 'G'){ //เช็ค G ตัว 1 2 3 ตัวล่าสุด ห้าม G
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if (fower.Get(0) == 'G' && fower.Get(-1) == 'G' && fower.Get(-2) == 'G' ){ // เช็ค G ตัวแรก และ เช็คตัวท้าย 2 ตัว ตัวล่าสุด ห้ามเป็น G 
                            Console.WriteLine("Invalid pattern.");
                        }
                        else{
                            fower.Add(Fower_input);
                        }
                    }
                    else {
                        fower.Add(Fower_input);
                    }}
                }
            }
        }
        Console.WriteLine("_____________________________________________________________________________");
        for(int i = 0 ; i < fower.GetLength() ; i++){
            Console.Write(fower.Get(i));
        }
        Console.WriteLine("");
    }
    static void Main(string[] args)
    {
        HW_1();
    }
}
