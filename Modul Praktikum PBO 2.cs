class program
{
    static void Main (string[] args)
    {
        //vga
        Amd amd = new Amd();
        Nvidia nvdia = new Nvidia();
        //processor
        Corei5 core5 = new Corei5();
        Corei7 core7 = new Corei7();
        Ryzen ryzen = new Ryzen();
        //laptop
        Laptop laptop1 = new Vivobook(nvdia, core5);
        //laptop1.LaptopDinyalakan();
        Laptop laptop2 = new IdeaPad(amd, ryzen);
        //laptop2.LaptopDimatikan();
        Predator predator = new Predator(amd, core7);

        //Soal
        //1
        Console.WriteLine("no1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        //2
        //laptop1.ngoding();
        //3
        Console.WriteLine("no3");
        Console.WriteLine($"Merk VGA = {laptop1.vga}, processor = " + $"{laptop1.processor.merk}, Tipe = {laptop1.processor} ");
        //4 
        Console.WriteLine("no4");
        predator.BermainGame();
        //5
        ACER acer = new Predator(amd, core7);
        //acer.BermainGame();
    }
}

class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
    }

}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
        this.tipe = tipe;
    }
}

class Corei3 : Intel
{
    public Corei3() : base("Core I3")
    {

    }
}
class Corei5 : Intel
{
    public Corei5() : base("Core I5")
    {

    }
}

class Corei7 : Intel
{
    public Corei7() : base("Core I7")
    {

    }
}

class AMD : Processor
{

    public AMD(string tipe) : base("AMD", tipe)
    {
        this.tipe = tipe;
    }
}
class Ryzen : AMD
{
    public Ryzen() : base("Rayzen")
    {

    }
}
class Athlon : AMD
{
    public Athlon() : base("ATHLON")
    {

    }
}

class Vga
{
    public string merk;

    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    {

    }
}

class Amd : Vga
{
    public Amd() : base("AMD")
    {

    }

}

//LAPTOP
class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS(string tipe, Vga vga, Processor processor) : base("asus", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }
}

class ROG : ASUS
{
    public ROG(Vga vga, Processor processor) : base("ROG", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Vivobook : ASUS
{
    public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
    public void ngoding()
    {
        Console.WriteLine("ctak cetak, error lagi !");
    }
}

class ACER : Laptop
{
    public ACER(string tipe, Vga vga, Processor processor) : base("acer", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

}

class Swift : ACER
{
    public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Predator : ACER
{
    public Predator(Vga vga, Processor processor) : base("Predator", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
    }
}

class LENOVO : Laptop
{
    public LENOVO(string tipe, Vga vga, Processor processor) : base("LENOVO", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;

    }
}

class IdeaPad : LENOVO
{
    public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Legion : LENOVO
{
    public Legion(Vga vga, Processor processor) : base("Legion", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}