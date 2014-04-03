using UnityEngine;
using System.Collections;

public class HeavyShipMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	  iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("heavyPath"), "time", 5, "easetype", iTween.EaseType.easeInOutSine,
        "orienttopath", true));
	}
}
