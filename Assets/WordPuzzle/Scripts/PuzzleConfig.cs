/// <summary>
/// Puzzle config. Take a array of string as input, which will be used to construct the puzzle
/// </summary>
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
//using System.Linq;
using System.Collections.Generic;
public class PuzzleConfig : MonoBehaviour {
   
    public string[] wordz = new string[]  { "both", "bowl", "bulk", "burn", "bush", "busy", "call", "calm", "came", "camp", "card", "care", "case", "cash", "cast", "cell", "chat", "chip", "city", "club", "coal", "coat", "code", "cold", "come", "cook", "cool", "cope", "copy", "CORE", "cost", "crew", "crop", "dark", "data", "date", "dawn", "days", "dead", "deal", "dean", "dear", "debt", "deep", "deny", "desk", "dial", "dick", "diet", "disc", "disk", "does", "done", "door", "dose", "down", "draw", "drew", "drop", "drug", "dual", "duke", "dust", "duty", "each", "earn", "ease", "east", "easy", "edge", "else", "even", "ever", "evil", "exit", "face", "fact", "fail", "fair", "fall", "farm", "fast", "fate", "fear", "feed", "feel", "feet", "fell", "felt", "file", "fill", "film", "find", "fine", "fire", "firm", "fish", "five", "flat", "flow", "food", "foot", "ford", "form", "fort", "four", "free", "from", "fuel", "full", "fund", "gain", "game", "gate", "gave", "gear", "gene", "gift", "girl", "give", "glad", "goal", "goes", "gold", "Golf", "gone", "good", "gray", "grew", "grey", "grow", "gulf", "hair", "half", "hall", "hand", "hang", "hard", "harm", "hate", "have", "head", "hear", "heat", "held", "hell", "help", "here", "hero", "high", "hill", "hire", "hold", "hole", "holy", "home", "hope", "host", "hour", "huge", "hung", "hunt", "hurt", "idea", "inch", "into", "iron", "item", "jack", "jane", "jean", "john", "join", "jump", "jury", "just", "keen", "keep", "kent", "kept", "kick", "kill", "kind", "king", "knee", "knew", "know", "lack", "lady", "laid", "lake", "land", "lane", "last", "late", "lead", "left", "less", "life", "lift", "like", "line", "link", "list", "live", "load", "loan", "lock", "logo", "long", "look", "lord", "lose", "loss", "lost", "love", "luck", "made", "mail", "main", "make", "male", "many", "Mark", "mass", "matt", "meal", "mean", "meat", "meet", "menu", "mere", "mike", "mile", "milk", "mill", "mind", "mine", "miss", "mode", "mood", "moon", "more", "most", "move", "much", "must", "name", "navy", "near", "neck", "need", "news", "next", "nice", "nick", "nine", "none", "nose", "note", "okay", "once", "only", "onto", "open", "oral", "over", "pace", "pack", "page", "paid", "pain", "pair", "palm", "park", "part", "pass", "past", "path", "peak", "pick", "pink", "pipe", "plan", "play", "plot", "plug", "plus", "poll", "pool", "poor", "port", "post", "pull", "pure", "push", "race", "rail", "rain", "rank", "rare", "rate", "read", "real", "rear", "rely", "rent", "rest", "rice", "rich", "ride", "ring", "rise", "risk", "road", "rock", "role", "roll", "roof", "room", "root", "rose", "rule", "rush", "ruth", "safe", "said", "sake", "sale", "salt", "same", "sand", "save", "seat", "seed", "seek", "seem", "seen", "self", "sell", "send", "sent", "sept", "ship", "shop", "shot", "show", "shut", "sick", "side", "sign", "site", "size", "skin", "slip", "slow", "snow", "soft", "soil", "sold", "sole", "some", "song", "soon", "sort", "soul", "spot", "star", "stay", "step", "stop", "such", "suit", "sure", "take", "tale", "talk", "tall", "tank", "tape", "task", "team", "tech", "tell", "tend", "term", "test", "text", "than", "that", "them", "then", "they", "thin", "this", "thus", "till", "time", "tiny", "told", "toll", "tone", "tony", "took", "tool", "tour", "town", "tree", "trip", "true", "tune", "turn", "twin", "type", "unit", "upon", "used", "user", "vary", "vast", "very", "vice", "view", "vote", "wage", "wait", "wake", "walk", "wall", "want", "ward", "warm", "wash", "wave", "ways", "weak", "wear", "week", "well", "went", "were", "west", "what", "when", "whom", "wide", "wife", "wild", "will", "wind", "wine", "wing", "wire", "wise", "wish", "with", "wood", "word", "wore", "work", "yard", "yeah", "year", "your", "zero", "zone" };
	public string[] puzzleWords = new string[4];
	public static int cellSize;
	//h
	//public string[] sample;
	public ArrayList arrayOfWords = new ArrayList(4) ;
	public ArrayList ArrayW = new ArrayList(4) ;
	public static string randString;
	public string[] lines;
	public string stringify;
  //  public int counterx;
	public static string[] searchWords;//for accessing in searcher
  //  public ArrayList puzzWords = new ArrayList(3);
	// Use this for initialization
	void Start () {
      
		searchWords = puzzleWords;
		GameObject.Find("w1").GetComponentInChildren<Text>().text = puzzleWords[0];
		GameObject.Find("w2").GetComponentInChildren<Text>().text = puzzleWords[1];
		GameObject.Find("w3").GetComponentInChildren<Text>().text = puzzleWords[2];
		GameObject.Find("w4").GetComponentInChildren<Text>().text = puzzleWords[3];
		GameObject.Find("w5").GetComponentInChildren<Text>().text = puzzleWords[4];
		GameObject.Find("w6").GetComponentInChildren<Text>().text = puzzleWords[5];
		GameObject.Find("w7").GetComponentInChildren<Text>().text = puzzleWords[6];


	}

    public  void ShuffleArray<T>(T[] arr)
    {
  
		for (int i = arr.Length - 1; i > 0; i--)
        {
            int counter = 0;
            int r = Random.Range(0, i);
            T tmp = arr[i];
            arr[i] = arr[r];
            arr[r] = tmp;
            counter--;

            Debug.Log("counter+");
      
        }

    }

    void Awake()
    {



	
	



      
        ShuffleArray(wordz);
        arrayOfWords.AddRange(wordz);
		ArrayW.AddRange (wordz);
		for (int i = 7; i < wordz.Length; i++) {
			ArrayW.Remove (wordz [i]);
		}
            string[] myArray = (string[])arrayOfWords.ToArray(typeof(string));
		string[] myArrays = (string[])ArrayW.ToArray(typeof(string));
            Debug.Log(arrayOfWords[0]);


            puzzleWords = myArrays;

            GetPuzzleSize();
            RandomizeString(puzzleWords);
       
    }

	public void Rands(){
        string[] myArrays = (string[])ArrayW.ToArray(typeof(string));
		GameObject[] others = GameObject.FindGameObjectsWithTag("brick");
     
		foreach (GameObject game in others) {

			if(game != gameObject)
			{
				Destroy(game);
			}
		}
		//searchWords = puzzleWords;
		//GetPuzzleSize ();

		GetPuzzleSize ();
		RandomizeString (myArrays);
		GameObject.Find ("CellFactory").GetComponent<CellFactory> ().GeneratePuzzleBricks ();
	}

   

	// Update is called once per frame
	void Update () {

      //  if(GameObject.Find(""))
      

	
		//w6.text = puzzleWords [5];

	}

	//Sums up the letters of the puzzle words to calculate the size of the cells needed to
	//hold the puzzle
	public void GetPuzzleSize()
	{
		//First calculate the total number of letters
		int letterCount = 0;
		foreach (string str in puzzleWords) {
			letterCount += str.Length;
		}
		PlayerPrefs.SetInt ("count", letterCount);
		//Debug.Log ("Total letters : " + letterCount.ToString ());

		//For doing a square cell matrix we need to get the square that can hold these cells
		float sqRoot = Mathf.Sqrt((float)letterCount);
		//Extra one cell is added so we have enough room to move blocks around
		cellSize = Mathf.RoundToInt (sqRoot) + 1;

		//Debug.Log ("Matrix size : " + cellSize.ToString ());


	}

	//This will shuffle the letters for the puzzle

	 void RandomizeString(string[] puzzleStringArray)
	{
		//concatenate the string to make a big string of letters
		string bigstring = "";
		foreach (string str in puzzleStringArray) {
			bigstring +=  str;

		}

		//Debug.Log ("Big string is : " + bigstring);
		stringify = bigstring;

	
		//Randomize the string
		//make character array
		System.Random rnd = new System.Random();
		char [] strChars = bigstring.ToCharArray();
		//Debug.Log (strChars.Length);
		int i = strChars.Length;
		while (i>1) {
			i--;
			int j = rnd.Next (i+1);
			char val = strChars [j];
			strChars [j] = strChars [i];
			strChars [i] = val;
		}

		randString = new string (strChars);

		//Debug.Log ("Randomized String : " + randString);

	}


}
