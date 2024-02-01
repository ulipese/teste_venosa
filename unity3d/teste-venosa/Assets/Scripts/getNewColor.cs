using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class getNewColor : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    private Renderer cubeRenderer;
    private Color newCubeColor;

    private float randomChannelOne, randomChannelTwo, randomChannelThree;

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        
        InvokeRepeating("ChangeCubeColor", 3, 1);
    }
    public void ChangeCubeColor() {
        StartCoroutine(callAPI.GetData());
        UserData userData = new UserData();

        randomChannelOne = userData.redCode; // R UnityEngine.Random.Range(0f, 1f)
        randomChannelTwo = userData.greenCode; // G
        randomChannelThree = userData.blueCode; // B

        newCubeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f); /* RGBA, pegamos as variações de RGB (cores) e passamos 
       o A (alpha component) máximo, que é o que define a opacidade  */ 
       cubeRenderer.material.SetColor("_Color", newCubeColor);
    }
}
