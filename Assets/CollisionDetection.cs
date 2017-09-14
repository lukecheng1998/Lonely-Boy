using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour
{

	int score;
	Collider[] friendColliders = new Collider[5];

	// Use this for initialization
	void Start ()
	{
		score = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag == "AI") {
			addElement(friendColliders, collider);
			if (!hasElement(friendColliders, collider)) {
				score += 1;
			}
		}
	}

	bool hasElement (Collider[] list, Collider c)
	{
		bool hasE = false;
		if (hasE == false) {
			for (int i = 0; i < list.Length; i++) {
				hasE = list [i] == c; 
			}
		}
		return hasE;
	}

	void addElement (Collider[] list, Collider c) {
		int currentLength = 0;
		for (int i = 0; i < list.Length; i++) {
			currentLength += list[i] != null ? 1 : 0;
		}
		list [currentLength] = c;
	}
}
