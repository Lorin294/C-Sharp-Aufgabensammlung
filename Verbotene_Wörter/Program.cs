namespace Verbotene_Wörter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countWords = 0;
            Console.Write("Dein Kommentar: ");
            string comment = Console.ReadLine();
            string[] forbiddenWords = {
    "viagra", "sex", "porno", "fick", "schlampe", "arsch", "scheiss", "scheiß", "scheisse",
    "kacke", "fotze", "wichser", "wixer", "hure", "hurensohn", "nutte", "bastard",
    "miststück", "mistkerl", "mistvieh", "idiot", "vollidiot", "depp", "trottel", "dummkopf",
    "blödmann", "blöde kuh", "dumme kuh", "spast", "penner", "missgeburt", "drecksau",
    "dreckskerl", "dreckspack", "fresse", "halt die klappe", "verpiss", "pisser", "kotzen",
    "abschaum", "schwachkopf", "hirnlos", "lauch", "opfer", "spinner", "vollpfosten",
    "honk", "flachwichser", "arschgeige", "arschkriecher", "wichsen", "titten", "schwanz",
    "pimmel", "möse", "votze", "fickfehler", "verrecke", "krepier", "geh sterben",
    "halts maul", "maul halten", "leck mich", "scheißkerl", "scheisskerl", "saftsack",
    "sack", "dummschwätzer", "schwätzer", "lappen", "waschlappen", "niete", "versager",
    "loser", "hässlich", "fett", "dumm", "blöd", "verdammt", "verflucht",
    "fuck", "fucking", "shit", "bitch", "asshole", "bullshit", "cunt", "pussy", "slut",
    "whore", "dick", "cock", "bastard", "damn", "crap", "piss", "prick", "douche",
    "douchebag", "wanker", "twat", "bollocks", "motherfucker", "dumbass", "jackass",
    "dipshit", "moron", "idiot", "stupid", "retard", "loser", "ugly", "scumbag",
    "bloody hell", "son of a bitch", "shut up", "kill yourself", "go die", "porn",
    "nude", "nudes", "boobs", "tits", "blowjob", "horny", "milf", "cum", "anal"
};
            bool valid = true;
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                if (comment.Contains(forbiddenWords[i], StringComparison.OrdinalIgnoreCase))
                {
                    valid = false;
                    countWords++;
                }
            }
            if (valid)
            {
                Console.WriteLine("Dein Kommentar wurde Veröffentlicht.");
            }
            else
            { 
                Console.WriteLine("Dein Kommentar hat "+countWords+" Verbotene Wörter");
                Console.WriteLine("Dein Kommentar wurde nicht Veröffentlich.");
            }
        }
    }
}