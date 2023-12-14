using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class testController : MonoBehaviour
{
    [SerializeField]
    Text randomNumberText, randomVectorText;

    [SerializeField]
    Image randomColorImage;
    [SerializeField]
    Image[] RandomSelectionIImagesArrayMulti;
    [SerializeField]
    List<Image> RandomSelectionIImagesListMulti = new List<Image>();
    [SerializeField]
    List<Image> RandomSelectionIImagesList = new List<Image>();
    [SerializeField]
    Image[] RandomSelectionIImagesArray;

    [SerializeField]
    int randomObjectsToSelect;

    [SerializeField]
    int randomNumberMin, randomNumberMax;

    [SerializeField]
    Vector3 randomVectorrMin, randomVectorMax;
    // Start is called before the first frame update

    public void selectRandomColor()
    {
        randomColorImage.color = selectRandom.SelectRandomColor(1)[0];
    }

    public void selectRandomObjectList()
    {
        for(int i = 0; i < RandomSelectionIImagesList.Count; i++)
        {
            RandomSelectionIImagesList[i].color = Color.white;
        }
        selectRandom.SelectRandomObjectFromList(RandomSelectionIImagesList).color = Color.green;
    }


    public void selectRandomObjectArray()
    {
        for (int i = 0; i < RandomSelectionIImagesArray.Length; i++)
        {
            RandomSelectionIImagesArray[i].color = Color.white;
        }
        selectRandom.SelectRandomObjectFromArray(RandomSelectionIImagesArray).color = Color.green;
    }

    public void selectRandomObjectsList()
    {
        for (int i = 0; i < RandomSelectionIImagesListMulti.Count; i++)
        {
            RandomSelectionIImagesListMulti[i].color = Color.white;
        }
        List<Image> images = new List<Image>();
        images = selectRandom.SelectRandomObjectsFromList(RandomSelectionIImagesListMulti, randomObjectsToSelect);

        for (int i = 0; i < images.Count; i++)
        {
            images[i].color = Color.green;
        }
    }


    public void selectRandomObjectsArray()
    {
        for (int i = 0; i < RandomSelectionIImagesArrayMulti.Length; i++)
        {
            RandomSelectionIImagesArrayMulti[i].color = Color.white;
        }

        Image[] images = selectRandom.SelectRandomObjectsFromArray(RandomSelectionIImagesArrayMulti, randomObjectsToSelect);

        for(int i = 0; i < images.Length; i++)
        {
            images[i].color = Color.green;
        }
    }

    public void selectRandomNumber()
    {
        randomNumberText.text = "";
        List<int> ints = selectRandom.SelectRandomNumbersFromRange(randomNumberMin,randomNumberMax,randomObjectsToSelect);
        for(int i = 0; i < ints.Count; i++)
        {
            if (i > 0)
                randomNumberText.text += " , ";

            randomNumberText.text += ints[i].ToString();
        }

    }

    public void selectRandomVector()
    {
        randomVectorText.text = "";
        List<Vector3> vector3s = new List<Vector3>();

        vector3s = selectRandom.SelectRandomVector3sFromRange(randomVectorrMin, randomVectorMax, randomObjectsToSelect);

        for (int i = 0; i < vector3s.Count; i++)
        {
            if (i > 0)
                randomVectorText.text += " , ";

            randomVectorText.text += vector3s[i].ToString();
        }
    }
}
