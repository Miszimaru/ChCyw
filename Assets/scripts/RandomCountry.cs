using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomCountry : MonoBehaviour
{
    public int interval = 3;
    private DateTime lastTime;
    public List<string> countries;
    private System.Random random;
    public TextMesh textMesh;

	void Start ()
    {
        lastTime = DateTime.Now;
        random = new System.Random();
	}
	
	void Update ()
    {
        string country;
		if (DateTime.Now > lastTime.AddSeconds(interval))
        {
            lastTime = DateTime.Now;
            country = countries[random.Next(countries.Count)];
            textMesh.text = country;
        }
	}
}