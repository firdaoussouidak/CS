namespace TP1_1;

class Program
{
    static void Main()
    {
        Repertoire repertoire = new Repertoire("Documents", 5);

        repertoire.AjouterFichier(new Fichier("rapport.pdf", 1.5));
        repertoire.AjouterFichier(new Fichier("photo.jpg", 2.3));
        repertoire.AjouterFichier(new Fichier("presentation.pptx", 4.7));

        repertoire.AfficherContenu();
        
        repertoire.AjouterFichier(new Fichier("music.mp3", 3.1));
        repertoire.AjouterFichier(new Fichier("video.mp4", 12.4));
        repertoire.AjouterFichier(new Fichier("extra.docx", 1.8)); 
        
        repertoire.AfficherContenu();
    }
}
