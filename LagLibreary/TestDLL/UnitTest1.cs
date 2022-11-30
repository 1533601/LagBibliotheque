using System;
using System.ComponentModel;
using LagLibreary;

namespace TestDLL;

[TestClass]
public class UnitTest1
{
    //erreur lors du test car la fonction nbMembres est static poser une question au prof
    
    [TestMethod]

    public void ATestNoMembre()
    {
        Membre samuel = new Membre("Samuel");
        Membre guillaume = new Membre("Guillaume");
        Assert.AreEqual(1, samuel.GetNoMembre());
        Assert.AreEqual(2, guillaume.GetNoMembre());
    }

    [TestMethod]
    public void TestAjouterMembreListeAttente()
    {
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        List<Membre> listeAttente = new List<Membre>();
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Membre samuel = new Membre("Samuel");
        Membre guillaume = new Membre("Guillaume");
        Membre francis = new Membre("Francis");
        Membre mathieu = new Membre("Mathieu");

        Assert.AreEqual(false, artDeLaGuerre.AjouterMembreListeAttente(samuel));
        artDeLaGuerre.SetEmprunteur(samuel);
        Assert.AreEqual(false, artDeLaGuerre.AjouterMembreListeAttente(samuel));
        Assert.AreEqual(true, artDeLaGuerre.AjouterMembreListeAttente(guillaume));
        Assert.AreEqual(true, artDeLaGuerre.AjouterMembreListeAttente(francis));
        Assert.AreEqual(false, artDeLaGuerre.AjouterMembreListeAttente(mathieu));
    }
    [TestMethod]
    public void TestEnleverMembreListeAttente()
    {
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        List<Membre> listeAttente = new List<Membre>();
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Membre samuel = new Membre("Samuel");
        Membre guillaume = new Membre("Guillaume");
        artDeLaGuerre.SetEmprunteur(samuel);
        Assert.AreEqual(true, artDeLaGuerre.AjouterMembreListeAttente(guillaume));
        Assert.AreEqual(false, artDeLaGuerre.EnleverMembreListeAttente(samuel));
        Assert.AreEqual(true, artDeLaGuerre.EnleverMembreListeAttente(guillaume));
    }
    [TestMethod]
    public void TestIcomparable()
    {
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        DateTime date1 = new DateTime(2009, 3, 1, 7, 0, 0);
        List<Membre> listeAttente = new List<Membre>();
        List<Membre> listeAttente1 = new List<Membre>();
        List<Membre> listeAttente2 = new List<Membre>();
        List<Membre> listeAttente3 = new List<Membre>();
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Livre artDeLaGuerre2 = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente1, date1, 258, "A52BJ33", "Bon");
        Audio mikeWardSurEcoute = new Audio("Mike Ward sur Écoute ep.1", "Mike Ward", "Meilleur Podcast humoristique au Québec", listeAttente2, 126, "Podcast");
        Periodique TheseDeSuzanne = new Periodique("Thèse du Suzanne", "Suzanne", "Thèse de doctorat de Suzanne en science nature", listeAttente3, 2019, 4506, 23);
        Assert.AreEqual(1, artDeLaGuerre.CompareTo(artDeLaGuerre2));
        Assert.AreEqual(0, artDeLaGuerre.CompareTo(mikeWardSurEcoute));
        Assert.AreEqual(0, artDeLaGuerre.CompareTo(TheseDeSuzanne));
    }
    [TestMethod]

    public void TestIsDisopnible()
    {
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        List<Membre> listeAttente = new List<Membre>();
        Membre samuel = new Membre("Samuel");
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Assert.AreEqual(true, artDeLaGuerre.EstDisponible());
        artDeLaGuerre.SetEmprunteur(samuel);
        Assert.AreEqual(false, artDeLaGuerre.EstDisponible());
        artDeLaGuerre.SetEmprunteur(null);
        Assert.AreEqual(true, artDeLaGuerre.EstDisponible());
    }
    [TestMethod]

    public void TestAjouterDocument()
    {
        Membre samuel = new Membre("Samuel");
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        DateTime date1 = new DateTime(2009, 3, 1, 7, 0, 0);
        List<Membre> listeAttente = new List<Membre>();
        List<Membre> listeAttente1 = new List<Membre>();
        List<Membre> listeAttente2 = new List<Membre>();
        List<Membre> listeAttente3 = new List<Membre>();
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Livre artDeLaGuerre2 = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente1, date1, 258, "A52BJ33", "Bon");
        Livre artDeLaGuerre3 = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente1, date1, 258, "A52BJ33", "Bon");
        Audio mikeWardSurEcoute = new Audio("Mike Ward sur Écoute ep.1", "Mike Ward", "Meilleur Podcast humoristique au Québec", listeAttente2, 126, "Podcast");
        Periodique TheseDeSuzanne = new Periodique("Thèse du Suzanne", "Suzanne", "Thèse de doctorat de Suzanne en science nature", listeAttente3, 2019, 4506, 23);
        Assert.AreEqual(true, samuel.AjouterDocument(artDeLaGuerre));
        Assert.AreEqual(false, samuel.AjouterDocument(artDeLaGuerre));
        Assert.AreEqual(true, samuel.AjouterDocument(artDeLaGuerre2));
        Assert.AreEqual(true, samuel.AjouterDocument(artDeLaGuerre3));
        Assert.AreEqual(true, samuel.AjouterDocument(TheseDeSuzanne));
        Assert.AreEqual(false, samuel.AjouterDocument(mikeWardSurEcoute));
    }
    [TestMethod]
    public void TestRetirerDocument()
    {
        Membre samuel = new Membre("Samuel");
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        DateTime date1 = new DateTime(2009, 3, 1, 7, 0, 0);
        List<Membre> listeAttente = new List<Membre>();
        List<Membre> listeAttente1 = new List<Membre>();
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Livre artDeLaGuerre2 = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente1, date1, 258, "A52BJ33", "Bon");
        Assert.AreEqual(true, samuel.AjouterDocument(artDeLaGuerre));
        Assert.AreEqual(true, samuel.RetirerDocument(artDeLaGuerre));
        Assert.AreEqual(false, samuel.RetirerDocument(artDeLaGuerre2));
    }
    [TestMethod]

    public void TestChargerTrouverDocument()
    {
        DateTime laDate = new DateTime(2020, 8, 14);
        List<Membre> listeAttente = new List<Membre>();
        Repertoire leRepertoire = new Repertoire("leRepertoire", "leFichier");
        Livre hola = new Livre("hola", "hola hola", "holy cow", "holapow", listeAttente, laDate, 168, "bg56bs", "baba567");
        leRepertoire.ChargerDocument("Livre1");
        Document leDoc = leRepertoire.TrouverDocument("hola", "hola hola");
        Assert.AreEqual(1, hola.CompareTo(leDoc));
    }
    [TestMethod]
    public void TestChargerDocumentException()
    {
        try
        {
            Repertoire leRepertoire = new Repertoire("leRepertoire", "leFichier");
            leRepertoire.ChargerDocument("Livre2");
        }
        catch(DocumentFormatIncorrectException)
        {
            return;
        }
        Assert.Fail();
    }
    [TestMethod]
    public void TestTrouverDocumentException()
    {
        try
        {
            Repertoire leRepertoire = new Repertoire("leRepertoire", "leFichier");
            leRepertoire.TrouverDocument("hola", "hola hola");
        }
        catch(ReturnValueCannotBeNullException)
        {
            return;
        }
        Assert.Fail();
    }
    [TestMethod]

    public void TestAjouterSupprimerDocument()
    {
        Repertoire leRepertoire = new Repertoire("leRepertoire", "leFichier");
        DateTime laDate = new DateTime(2020, 8, 14);
        List<Membre> listeAttente = new List<Membre>();
        Livre hola = new Livre("hola", "hola hola", "holy cow", "holapow", listeAttente, laDate, 168, "bg56bs", "baba567");
        Assert.AreEqual(true, leRepertoire.AjouterDocument(hola));
        Assert.AreEqual(true, leRepertoire.SupprimerDocument(hola));
    }
    [TestMethod]

    public void TestAjouterTrouverMembre()
    {
        Repertoire leRepertoire = new Repertoire("leRepertoire", "leFichier");
        Bibliotheque laBibliotheque = new Bibliotheque("biblio", leRepertoire);
        Membre Xavier = new Membre("Xavier");
        Membre Maurice = new Membre("Maurice");
        laBibliotheque.AjouterMembre(Xavier);
        laBibliotheque.AjouterMembre(Maurice);
        Assert.AreEqual(Xavier, laBibliotheque.TrouverMembre("Xavier"));
    }
    [TestMethod]
    public void TestAjouteMembreEnDouble() //la Fonction de base permettait verifier l'ajout de 100 membres si après membres la fonctions aurait crash, la fonction ayant réussi j'ai empêché l'ajout de doublon.
    {
        Repertoire leRepertoire = new Repertoire("leRepertoire", "leFichier");
        Bibliotheque laBibliotheque = new Bibliotheque("biblio", leRepertoire);
        Membre Xavier = new Membre("Xavier");
        for(int i = 0; i < 105; i++)
        {
            laBibliotheque.AjouterMembre(Xavier);
        }
        Assert.AreEqual(laBibliotheque.GetMembres()[0], Xavier);
    }
    [TestMethod]

    public void TestAjouterMembreListeAttenteBibliotheque()
    {
        Repertoire leRepertoire = new Repertoire("leRepertoire", "leFichier");
        Bibliotheque laBibliotheque = new Bibliotheque("biblio", leRepertoire);
        List<Membre> listeAttente = new List<Membre>();
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        Membre Xavier = new Membre("Xavier");
        Membre Maurice = new Membre("Maurice");
        laBibliotheque.AjouterMembre(Xavier);
        laBibliotheque.AjouterMembre(Maurice);
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Assert.AreEqual(false, laBibliotheque.AjouterListeAttente(Maurice, artDeLaGuerre));
        artDeLaGuerre.SetEmprunteur(Maurice);
        Assert.AreEqual(false, laBibliotheque.AjouterListeAttente(Maurice, artDeLaGuerre));
        Assert.AreEqual(true, laBibliotheque.AjouterListeAttente(Xavier, artDeLaGuerre));
    }
    [TestMethod]
    public void TestNotifierAjoutEmprunt()
    {
        Repertoire leRepertoire = new Repertoire("leRepertoire", "leFichier");
        Bibliotheque laBibliotheque = new Bibliotheque("biblio", leRepertoire);
        List<Membre> listeAttente = new List<Membre>();
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        Membre Xavier = new Membre("Xavier");
        Membre Maurice = new Membre("Maurice");
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        laBibliotheque.AjouterMembre(Xavier);
        laBibliotheque.AjouterMembre(Maurice);
        Assert.AreEqual(true, laBibliotheque.NotifierEmprunt("Xavier", artDeLaGuerre));
        Assert.AreEqual(false, laBibliotheque.NotifierEmprunt("Maurice", artDeLaGuerre));
        Assert.AreEqual(false, laBibliotheque.NotifierRetour(artDeLaGuerre));
        Assert.AreEqual(true, laBibliotheque.NotifierRetour(artDeLaGuerre));
    }
}