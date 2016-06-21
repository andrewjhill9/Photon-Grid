﻿using UnityEngine;
using Constants;
using System.Collections;

namespace Controllers {
	public class PlayerController : MonoBehaviour {

        private float speed;
		public bool isAlive = true;
	    public float turningSpeed;
	    private bool wallReady;
	    public static int wallSpawnRate = 2;
		private static InputController inputController;
		private Rigidbody vehicle;
        public Transform walls;


		// Use this for initialization
		void Start () {
            speed = PlayerConstants.BASE_VEHICLE_SPEED;
			inputController = new InputController (this);
	        PlayerBehaviors.isBoostReady = true;
	        wallReady = true;

            vehicle = GetComponent<Rigidbody>();
            vehicle.velocity = Vector3.forward * speed;
	        
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		void FixedUpdate()	{

	
			/*int input = inputController.update ();


			if (input == InputConstants.INPUT_BOOST)
				StartCoroutine (activateSpeedBoost());
			else if (input == InputConstants.INPUT_LEFT)
				turnPlayer (InputConstants.INPUT_LEFT);
			else if (input == InputConstants.INPUT_RIGHT)
				turnPlayer (InputConstants.INPUT_RIGHT);*/
		}

		

	    void onCollisionEnter(Collision other)
	    {
	        if (other.collider.tag == "Wall")
	        {
	            Debug.Log("Collision");
	            gameObject.SetActive(false);
	        }
	    }

	    IEnumerator spawnWall()  // IEnumerators are basically coroutine signatures (methods)
	    {
	        wallReady = false;
	        yield return new WaitForSeconds(wallSpawnRate);

	        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
	        cube.AddComponent<Rigidbody>();
	        cube.tag = "Wall";
	        cube.name = "Player Wall";
	        cube.transform.position = vehicle.position - (new Vector3(0, 0, 5));

	        yield return new WaitForSeconds(wallSpawnRate);
	        wallReady = true;
	    }




		public bool isBoostReady {
			get { return PlayerBehaviors.isBoostReady; }
			set { PlayerBehaviors.isBoostReady = value;	}
		}

		public bool isWallReady {
			get {
				return wallReady;
			}
		}
	}
}

