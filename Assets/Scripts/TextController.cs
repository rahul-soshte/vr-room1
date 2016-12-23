using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;


public class TextController : MonoBehaviour {

 void Start(){	

		//FileInfo theSourceFile = null;
		StringReader reader = null;
	

		TextAsset Ebook = (TextAsset)Resources.Load ("Ebook", typeof(TextAsset));
		//Ebook.txt is a string containing  the whole file.TO read it line by line
		reader = new StringReader(Ebook.text);
		if (reader == null) {
			Debug.Log ("Ebook.txt not found or readable");

		} else {
			//Read Each line from file
			string txt;

			while((txt=reader.ReadLine())!=null)
				{
					Debug.Log("-->"+txt);
		
				}
		}
	}


}


