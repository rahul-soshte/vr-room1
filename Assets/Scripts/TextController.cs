using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;


public class TextController : MonoBehaviour {
	private Text txt;//the string to be displayed in GUI Text element attached
	protected int lowBound=0;
	protected int upBound=0;

	 protected string completeText="";

 void Start(){	

		showInConsole ();


	}

	void Update(){
		showInGuiText ();

	}
	void showInConsole(){

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
				completeText = completeText + txt + "\n";


			}
		}
		}

	void showInGuiText(){
		txt = GetComponent<Text> ();
	int length = completeText.Length;

			if (Input.GetKey (KeyCode.RightArrow)) {
			lowBound = upBound;
			upBound = lowBound + 150;
			txt.text = completeText.Substring (lowBound, upBound);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
			upBound = lowBound;
			lowBound = upBound - 150;
		
			txt.text = completeText.Substring (lowBound, upBound);

			}

	
	}
	}





