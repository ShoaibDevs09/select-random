using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class selectRandom : MonoBehaviour
{
    public static List<T> SelectRandomObjectsFromList<T>(List<T> originalList, int objectsToSelect)
    {
        if (originalList.Count == 0)
        {
            return null;
            throw new ArgumentOutOfRangeException("List is empty");
        }

        else if (objectsToSelect > originalList.Count)
        {
            return null;
            throw new ArgumentOutOfRangeException("Objects to select can not be greater then the list of the length");
        }

        List<T> templist = new List<T>();
        for (int i = 0; i < originalList.Count; i++)
        {
            templist.Add(originalList[i]);
        }

        List<T> toReturn = new List<T>();

        for (int i = 0; i < objectsToSelect; i++)
        {
            int r = Random.Range(0, templist.Count);
            toReturn.Add(templist[r]);
            templist.Remove(templist[r]);
        }

        return toReturn;
    }

    public static T[] SelectRandomObjectsFromArray<T>(T[] originalArray, int objectsToSelect)
    {
        if (originalArray.Length == 0)
        {
            return null;
            throw new ArgumentOutOfRangeException("Array is empty");
        }

        else if (objectsToSelect > originalArray.Length)
        {
            return null;
            throw new ArgumentOutOfRangeException("Objects to select can not be greater then the length of the original array");
        }

        List<T> templist = new List<T>();
        for (int i = 0; i < originalArray.Length; i++)
        {
            templist.Add(originalArray[i]);
        }

        List<T> toReturn = new List<T>();

        for (int i = 0; i < objectsToSelect; i++)
        {
            int r = Random.Range(0, templist.Count);
            toReturn.Add(templist[r]);
            templist.Remove(templist[r]);
        }

        return toReturn.ToArray();
    }

    public static T SelectRandomObjectFromList<T>(List<T> originalList)
    {
        if (originalList.Count == 0)
        {
            throw new ArgumentOutOfRangeException("Array is empty");
        }

        int r = Random.Range(0, originalList.Count);
        T toReturn = originalList[r];

        return toReturn;
    }

    public static T SelectRandomObjectFromArray<T>(T[] originalArray)
    {
        if (originalArray.Length == 0)
        {
            throw new ArgumentOutOfRangeException("Array is empty");
        }

        int r = Random.Range(0, originalArray.Length);
        T toReturn = originalArray[r];

        return toReturn;
    }

    [Tooltip("Select length number of unique int between min(inclusice) and max(exclusive)")]
    public static List<int> SelectRandomNumbersFromRange(int min, int max, int length)
    {
        if (length == 0)
        {
            throw new ArgumentOutOfRangeException("length cannot be zero");
        }

        if (length >= max - min)
        {
            throw new ArgumentOutOfRangeException("length cannot be greater then range");
        }

        List<int> temp = new List<int>();
        for(int i = min; i < max; i++)
        {
            temp.Add(i); 
        }

        List<int> result = new List<int>();
        while(result.Count < length)
        {
            int r = Random.Range(0, temp.Count);
            result.Add(temp[r]);
            temp.Remove(temp[r]);
        }

        return result;
    }

    [Tooltip("Select length number of Vector3 between min(inclusice) and max(exclusive)")]
    public static List<Vector3> SelectRandomVector3sFromRange(Vector3 min, Vector3 max, int length)
    {
        if (length == 0)
        {
            throw new ArgumentOutOfRangeException("length cannot be zero");
        }

        List<Vector3> result = new List<Vector3>();
        while (result.Count < length)
        {
            result.Add(new Vector3(Random.Range((float)min.x, (float)max.x), Random.Range((float)min.y, (float)max.y), Random.Range((float)min.z, (float)max.z)));
        }

        return result;

    }


    [Tooltip("Select length number of Colors")]
    public static List<Color> SelectRandomColor(int length)
    {
        if (length == 0)
        {
            throw new ArgumentOutOfRangeException("length cannot be zero");
        }

        List<Color> result = new List<Color>();
        while (result.Count < length)
        {
            float r = Random.Range(0.00f, 1.00f);
            float g = Random.Range(0.00f, 1.00f);
            float b = Random.Range(0.00f, 1.00f);

            Color color = new Color(r, g, b, 1);

            result.Add(color);
        }

        return result;

        // Print "RGBA(1.000, 0.000, 1.000, 1.000)"
    }
}
