using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrtamScripti : MonoBehaviour

{
    private ArrayList tamListe = new ArrayList();
    private ArrayList ikiyeBolen = new ArrayList();
    private ArrayList uceBolen = new ArrayList();
    private ArrayList dordeBolen = new ArrayList();
    private ArrayList beseBolen = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        BolenleriBul(5, 30);
    }

    // Update is called once per frame
    void Update()
    {
     
       
    }

    void BolenleriBul(int sayi1, int sayi2)
    {
        for (int i = sayi1; i <= sayi2; i++)
        {
            tamListe.Add(i);

            if (i % 2 == 0)
                ikiyeBolen.Add(i);
            if (i % 3 == 0)
                uceBolen.Add(i);
            if (i % 4 == 0)
                dordeBolen.Add(i);
            if (i % 5 == 0)
                beseBolen.Add(i);
        }

        string listeString = "";

        foreach (int eleman in tamListe)
        {
            listeString += eleman + " ";
        }

        print("Aradaki sayýlar: " + listeString);

        string ikiyeBol = "";

        foreach (int eleman in ikiyeBolen)
        {
            ikiyeBol += eleman + " ";
        }

        print("Ýkiye bölünen sayýlar: " + ikiyeBol);

        string uceBol = "";

        foreach (int eleman in uceBolen)
        {
            uceBol += eleman + " ";
        }

        print("Üçe bölünen sayýlar: " + uceBol);

        string dordeBol = "";

        foreach (int eleman in dordeBolen)
        {
            dordeBol += eleman + " ";
        }

        print("Dörde bölünen sayýlar: " + dordeBol);

        string beseBol = "";

        foreach (int eleman in beseBolen)
        {
            beseBol += eleman + " ";
        }

        print("Bese bölünen sayýlar: " + beseBol);
    }
}