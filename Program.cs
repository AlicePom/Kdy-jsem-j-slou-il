namespace Když_jsem_já_sloužil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zvirata = new string[] { "kuřátko", "kačničku", "husičku", "vepříka", "telátko", "kravičku", "volečka" };
            string[] roky = new string[] { "první", "druhé", "třetí", "čtvrté", "páté", "šesté", "sedmé" };
            string[] sloky = new string[] 
            { 
                "a to kuře krákoře běhá po dvoře, má panenka pláče doma v komoře.", 
                "a ta kačka bláto tlačká", 
                "a ta husa chodí bosa", 
                "a ten vepř jako pepř", 
                "a to tele hubou mele", 
                "a ta kráva mléko dává", 
                "a ten vůl jako kůl"
            };

            for (int i = 0; i < zvirata.Length; i++) 
            {
                Console.WriteLine($"Když jsem já sloužil to {roky[i]} léto,");
                Console.WriteLine($"vysloužil jsem si {zvirata[i]} za to,");

                for (int j = i; j >= 0; j--)
                {
                    Console.WriteLine(sloky[j]);
                }

                Console.WriteLine();
            }
        }
    }
}