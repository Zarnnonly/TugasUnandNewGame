class Tugas
{
    static void Main()
    {
        
        for (int i = 2; i <= 10; i++)
        {
            CreateTree(i);
        }
    }

    static void CreateTree(int height)
    {
   
        
        System.Console.WriteLine("Tinggi Pohon: " + height);
        
        int leafHeight = height + 1;
        int trunkHeight = height;
        
     
        int maxWidth = leafHeight * 2 - 1;
        
        for (int i = 0; i < leafHeight; i++)
        {
            int stars = i + 1;
            int lineWidth = stars * 2 - 1;
            int spaces = (maxWidth - lineWidth) / 2;
            
            for (int j = 0; j < spaces; j++)
            {
                System.Console.Write(" ");
            }
            
            for (int j = 0; j < stars; j++)
            {
                System.Console.Write("*");
                if (j < stars - 1) // jangan tambah spasi setelah bintang terakhir
                {
                    System.Console.Write(" ");
                }
            }
            
            System.Console.WriteLine();
        }
        
        int trunkSpaces = (maxWidth - 1) / 2; // batang lebar 1 karakter
        
        for (int i = 0; i < trunkHeight; i++)
        {
            for (int j = 0; j < trunkSpaces; j++)
            {
                System.Console.Write(" ");
            }
            
            System.Console.Write("*");
            
            System.Console.WriteLine();
        }
        
        System.Console.WriteLine();
    }
}

