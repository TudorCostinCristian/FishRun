using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
	public static void SavePlayer(Player player)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/player.bin";
		FileStream stream = new FileStream(path, FileMode.Create);
		
		PlayerData data = new PlayerData(player);
		formatter.Serialize(stream, data);
		stream.Close();
	}
	
	public static PlayerData LoadPlayer()
	{
		string path = Application.persistentDataPath + "/player.bin";
		if(File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);
			
			PlayerData data = formatter.Deserialize(stream) as PlayerData;
			stream.Close();
			
			return data;
		}
		else
		{
			//nu a fost gasita SAVE FILE. Construiesc unul nou.
			PlayerData data = new PlayerData();
			return data;
		}
	}
}
