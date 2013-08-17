using UnityEngine;
using System.Collections;

public class BehaviorHandler : MonoBehaviour
{
	public GameObject[] planets;
	public GameObject[] players;
	public float cutOffDistance;

	// Use this for initialization
	void Start ()
	{
		planets = GameObject.FindGameObjectsWithTag("Planet");
		players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		foreach(GameObject player in players)
		{
			GravityPull playerBehavior;
			GameObject closestPlanet = player;
			float minPlanetDist = 0;
			
			playerBehavior = player.AddComponent("GravityPull") as GravityPull;
			playerBehavior.cutOffDistance = cutOffDistance;
			
			foreach(GameObject planet in planets)
			{
				Vector3 planetPlayer = player.transform.position - planet.transform.position;
				if(planet != planets[0])
				{
					if(minPlanetDist > planetPlayer.magnitude)
					{
						minPlanetDist = planetPlayer.magnitude;
						closestPlanet = planet;
					}
				}
				else
				{
					minPlanetDist = planetPlayer.magnitude;
					closestPlanet = planet;
				}
			}
			
			playerBehavior.gravityCenter = closestPlanet.transform;
		}
	}
}
