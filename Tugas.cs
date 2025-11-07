class Tugas
{
    static void Main()
    {
        // Harus memenuhi setidaknya perulangan dari 2 sampai dengan 10. 
        for (int i = 2; i <= 10; i++)
        {
            CreateTree(i);
        }
    }

    static void CreateTree(int height)
    {
        // Dalam program ini, buatlah sebuah pohon dengan batang lurus dengan tinggi height dan tinggi daun height + 1 yang harus berupa segitiga sama sisi
        // Contohnya pada gambar yang terlampir bersama.
        
        // Print keterangan tinggi pohon
        System.Console.WriteLine("Tinggi Pohon: " + height);
        
        int leafHeight = height + 1;
        int trunkHeight = height;
        
        // Membuat daun (segitiga sama sisi)
        // Lebar maksimal segitiga dengan spasi antar bintang
        // Baris terakhir punya leafHeight bintang = leafHeight * 2 - 1 karakter (dengan spasi)
        int maxWidth = leafHeight * 2 - 1;
        
        for (int i = 0; i < leafHeight; i++)
        {
            // Jumlah bintang pada baris ini
            int stars = i + 1;
            // Lebar total baris ini (stars + spasi antar stars)
            int lineWidth = stars * 2 - 1;
            // Jumlah spasi di kiri (untuk center)
            int spaces = (maxWidth - lineWidth) / 2;
            
            // Print spasi di kiri
            for (int j = 0; j < spaces; j++)
            {
                System.Console.Write(" ");
            }
            
            // Print bintang dengan spasi
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
        
        // Membuat batang (lurus, di tengah)
        int trunkSpaces = (maxWidth - 1) / 2; // batang lebar 1 karakter
        
        for (int i = 0; i < trunkHeight; i++)
        {
            // Print spasi di kiri
            for (int j = 0; j < trunkSpaces; j++)
            {
                System.Console.Write(" ");
            }
            
            // Print batang dengan bintang
            System.Console.Write("*");
            
            System.Console.WriteLine();
        }
        
        // Tambahkan baris kosong untuk pemisah antar pohon
        System.Console.WriteLine();
    }
}

