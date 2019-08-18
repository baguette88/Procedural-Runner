using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
//REMOVE ABOVE?

public class DataManagement : MonoBehaviour
{
	public static DataManagement datamanagement;

	public int currentScore;
	public int highScore;
	public int coinsCollected;

	void Awake()
	{
		if (datamanagement == null)
            // == changed to !=
		{
			DontDestroyOnLoad(gameObject);
			datamanagement = this;
		}

		//ifbrackets
		else if (datamanagement != this)
		{
			Destroy(gameObject);
		}
	}
	public void SaveData ()
	{
		BinaryFormatter binForm = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/gameinfo.dat");
		gameData data = new gameData();
		data.highScore = highScore;
		data.coinsCollected = coinsCollected;
		binForm.Serialize (file, data);
		file.Close ();
	}

	public void LoadData()
	{
		if (File.Exists(Application.persistentDataPath + "/gameInfo.dat"))
		{
			BinaryFormatter binForm = new BinaryFormatter();
			FileStream file = File.Open (Application.persistentDataPath + "/gameInfo.dat", FileMode.Open);
			gameData data = (gameData)binForm.Deserialize (file);
			file.Close();
			highScore = data.highScore;
			coinsCollected = data.coinsCollected;
		}
	}
}
//System.SerializableAttribute
    [SerializableAttribute]
  class gameData
    //public can be removed
	{ 
    public int highScore;
    public int coinsCollected;
	}
