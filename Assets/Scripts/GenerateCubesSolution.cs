using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubesSolution : MonoBehaviour
{
  public int cubeCount = 100;
  public float timeInterval = .005f;
  public GameObject prefab;
  public Vector3 randomPosStart = new Vector3(-8f, 9f, -8);
  public Vector3 randomPosEnd = new Vector3(8f, 20f, 8f);
  public Vector3 randomRotStart = new Vector3(0f, 0f, 0f);
  public Vector3 randomRotEnd = new Vector3(360f, 360f, 360f);
  public Vector3 randomScaleStart = new Vector3(.5f, .5f, .5f);
  public Vector3 randomScaleEnd = new Vector3(2f, 2f, 2f);

  void Start()
  {
    StartCoroutine(Generate());

    IEnumerator Generate()
    {
      for (int i = 0; i < cubeCount; i++)
      {
        yield return new WaitForSeconds(timeInterval);
        Vector3 randomPos = new Vector3(Random.Range(randomPosStart.x, randomPosEnd.x), Random.Range(randomPosStart.y, randomPosEnd.y), Random.Range(randomPosStart.z, randomPosEnd.z));
        Quaternion randomRot = Quaternion.Euler(new Vector3(Random.Range(randomRotStart.x, randomRotEnd.x), Random.Range(randomRotStart.y, randomRotEnd.y), Random.Range(randomRotStart.z, randomRotEnd.z)));

        GameObject prefabInstance = Instantiate(prefab, randomPos, randomRot);

        prefabInstance.GetComponent<Renderer>().material.color = GetRandomColor();
        prefabInstance.transform.localScale = new Vector3(Random.Range(randomScaleStart.x, randomScaleEnd.x), Random.Range(randomScaleStart.y, randomScaleEnd.y), Random.Range(randomScaleStart.z, randomScaleEnd.z));

        Debug.Log("Cube " + i + " generated.");
      }
    }
  }

  private Color GetRandomColor()
  {
    return new Color(
        r: UnityEngine.Random.Range(0f, 1f),
        g: UnityEngine.Random.Range(0f, 1f),
        b: UnityEngine.Random.Range(0f, 1f)
    );
  }
}