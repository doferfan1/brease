using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class puntajePersis : ScriptableObject
{
  public void guardar(string NameArch = null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(ObtRut(NameArch));
        var json= JsonUtility.ToJson(this);
        bf.Serialize(file, json);
        file.Close();   
    }
    public virtual void cargar(string NameArch = null)
    {

        if (File.Exists(ObtRut(NameArch)))
        {
            var bf = new BinaryFormatter();
            var file = File.Open(ObtRut(NameArch), FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), this);
            file.Close();
        }
    }

    public string ObtRut(string NameArch=null)
    {
        var NameArchCom= string.IsNullOrEmpty(NameArch) ? name: NameArch;
        return string.Format("{0}/{1}.ebac", Application.persistentDataPath, NameArchCom);
    }
}
