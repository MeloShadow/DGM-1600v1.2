using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {
	public string newAnimal;
	public List<string> zooRoster = new List<string>();
	// Use this for initialization
	void Start () {
		zooRoster.Add("Monkey");
		zooRoster.Add("Gorilla");
		zooRoster.Add("Snake");
		zooRoster.Add("Eel");
	}

	public void AddAnimal ()
	{
		if(newAnimal != "")
		{

			zooRoster.Add(newAnimal);
		}
	}
	/*public void RemoveAnimal ()
	{
		if(newAnimal != "")
		{
			zooRoster.Remove(newAnimal);
			newAnimal = "";
		}
		if(newAnimal == "")
		{
			zooRoster.Remove("Eel");
		}
	}
	public void ClearAnimal()
	{
		if(newAnimal == "" && newAnimal != "")
		{
			zooRoster.Clear(List<"">);
		}
	}
	public void PrintAnimalList ()
	{
		if(newAnimal != "")
		{
			print(zooRoster);
		}
	}*/






	public void RemoveAnimal()
	{
		if (zooRoster.Contains(newAnimal))
		{
			zooRoster.Remove(newAnimal);
		}
	}
	public void Clearlist()
	{
		zooRoster.Clear();
	}
	public void PrintList()
	{
		int i = 0;
		while(i < zooRoster.Count)
		{
			print(zooRoster[i]);
			i++;
		}
	}
}
