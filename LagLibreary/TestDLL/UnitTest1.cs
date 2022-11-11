using System;
using LagLibreary;

namespace TestDLL;

[TestClass]
public class UnitTest1
{
    //erreur lors du test car la fonction nbMembres est static poser une question au prof
    /*
    [TestMethod]

    public void TestNoMembre()
    {
        Membre samuel = new Membre("Samuel");
        Membre guillaume = new Membre("Guillaume");
        Assert.AreEqual(1, samuel.GetNoMembre());
        Assert.AreEqual(2, guillaume.GetNoMembre());
    }*/

    [TestMethod]
    public void TestAjouterMembre()
    {
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        List<Membre> listeAttente = new List<Membre>();
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Membre samuel = new Membre("Samuel");
        Membre guillaume = new Membre("Guillaume");
        Membre francis = new Membre("Francis");
        Membre mathieu = new Membre("Mathieu");

        Assert.AreEqual(true, artDeLaGuerre.AjouterMembreListeAttente(samuel));
        Assert.AreEqual(false, artDeLaGuerre.AjouterMembreListeAttente(samuel));
        Assert.AreEqual(true, artDeLaGuerre.AjouterMembreListeAttente(guillaume));
        Assert.AreEqual(false, artDeLaGuerre.AjouterMembreListeAttente(francis));
        Assert.AreEqual(false, artDeLaGuerre.AjouterMembreListeAttente(mathieu));
    }
    [TestMethod]
    public void TestEnleverMembre()
    {
        DateTime date = new DateTime(2008, 3, 1, 7, 0, 0);
        List<Membre> listeAttente = new List<Membre>();
        Livre artDeLaGuerre = new Livre("L'art de la guerre", "Sun Tzu", "Apprendre l'art de la guerre", "édition philosophie", listeAttente, date, 258, "A52BJ33", "Bon");
        Membre samuel = new Membre("Samuel");
        Membre guillaume = new Membre("Guillaume");

        Assert.AreEqual(true, artDeLaGuerre.AjouterMembreListeAttente(samuel));
        Assert.AreEqual(true, artDeLaGuerre.EnleverMembreListeAttente(samuel));
        Assert.AreEqual(false, artDeLaGuerre.EnleverMembreListeAttente(guillaume));
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
}