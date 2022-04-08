using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour
{
  public int cubeCount = 100;
  public float timeInterval = .005f;
  public GameObject prefab;
  public Vector3 randomPosStart = new Vector3(-8f, 9f, -8);
  public Vector3 randomPosEnd = new Vector3(8f, 20f, 8f);

  void Start()
  {
    StartCoroutine(Generate());

    IEnumerator Generate()
    {
      for (int i = 0; i < cubeCount; i++)
      {
        yield return new WaitForSeconds(timeInterval);
        // Vector3 randomPos = new Vector3(Random.Range(randomPosStart.x, randomPosEnd.x), Random.Range(randomPosStart.y, randomPosEnd.y), Random.Range(randomPosStart.z, randomPosEnd.z));
        Vector3 randomPos = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(9.0f, 20.0f), Random.Range(-8.0f, 8.0f));
        Instantiate(prefab, randomPos, Quaternion.identity);
        Debug.Log("Cube " + i + " generated.");
      }
    }
  }
}


// ASSIGNMENTS
// 1. Make it possible to change the randomPos from editor
// Search google for
// 2. Aapply randomRot same like randomPos
// 2. Aapply randomScale same like randomPos
// 3. Apply randomColor to each prefab while generating
// 4. Try to run this without any delay in instantiation
// Bonus
// Apply variable for rotation and scale as well
// Experiment with all the properties in Inspector window