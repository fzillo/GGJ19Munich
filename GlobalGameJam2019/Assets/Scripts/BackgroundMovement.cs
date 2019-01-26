﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{

    public List<GameObject> objectResoursceList;
    public List<GameObject> objectList;
    public float speed;
    public Vector3 startPos;

<<<<<<< HEAD
	float dT;
	// Use this for initialization
	void Start () {
		Reset ();
		dT = Time.time;
		speed = 2.5f;
		startPos=transform.position;
	}
=======
    float dT;
    // Use this for initialization
    void Start()
    {
        Reset();
        dT = Time.time;
        speed = 7.5f;
        startPos = transform.position;
    }
>>>>>>> 2e0ea51dec5a058689e926c8c50cca579a7b24ee

    // Update is called once per frame
    void Update()
    {

        transform.position += speed * (Time.time - dT) * Vector3.left;
        dT = Time.time;

        if (transform.position.x <= -24)
        {
            transform.position += 48 * Vector3.right;
            Reset();
        }
    }

    public void Reset()
    {

        foreach (GameObject go in objectList)
        {
            Destroy(go.gameObject);
        }
        objectList.Clear();

<<<<<<< HEAD
		for (int i = 0; i < objectPos.Count; i++) {
			int random = UnityEngine.Random.Range (0, objectResoursceList.Count);
			GameObject backgroundObject = Instantiate (objectResoursceList[random], gameObject.transform);
			backgroundObject.transform.position = 
				new Vector3 (24 * objectPos[i], objectResoursceList[random].transform.position.y, 0)
				+ gameObject.transform.position;
			objectList.Add (backgroundObject);
		}
=======
        List<float> objectPos = getPos();

        for (int i = 0; i < objectPos.Count; i++)
        {
            GameObject backgroundObject = Instantiate(objectResoursceList[0], gameObject.transform);
            backgroundObject.transform.position = new Vector3(24 * objectPos[i], 0, 0) + gameObject.transform.position;
            backgroundObject.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 45));
            backgroundObject.transform.localScale = new Vector3(0.0175f, 0.0175f, 0.5f);
            objectList.Add(backgroundObject);
>>>>>>> 2e0ea51dec5a058689e926c8c50cca579a7b24ee

        }

    }

    List<float> getPos()
    {
        List<float> posList = new List<float>();
        int random = UnityEngine.Random.Range(0, 1024);
        float pos = -0.4f;
        while (random != 0 && pos <= 0.4)
        {
            if (random % 2 != 0)
            {
                posList.Add(pos);
                pos += 0.2f;
            }
            else
                pos += 0.1f;
            random = random / 2;
        }
        return posList;
    }
}
