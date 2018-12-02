using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class controller : MonoBehaviour {

  public float moveSpeed;

	// Use this for initialization
	void Start () {
    moveSpeed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
    // print("updating...");
    // float x = myObject.transform.position.x;
    // float y = myObject.transform.position.y;
    // float z = myObject.transform.position.z;
    // print("Object pos = " + x + ", " + y + ", " + z);
		
    transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 
                        0f,
                        0f);

    // print(Input.GetAxis("Horizontal"));

    // if (Input.GetKey(KeyCode.W))
    //   // print("W key was pressed");
    //   // int = ;
    //   // transform.Translate(0f, 1f*Time.deltaTime,0f);
    // if (Input.GetKey(KeyCode.A))
    //   // print("A key was pressed");
    // if (Input.GetKey(KeyCode.S))
    //   // print("S key was pressed");
    // if (Input.GetKey(KeyCode.D))
      // print("D key was pressed");
    if (Input.GetKeyDown(KeyCode.Space)){
      print("JUMP");
      GetComponent<Rigidbody>().velocity =  new Vector3(0,8,0);
    }
	}

  void OnCollisionEnter(Collision collision)
  {
    // foreach (ContactPoint contact in collision.contacts)
    // {
    //     Debug.DrawRay(contact.point, contact.normal, Color.white);
    // }
    if (collision.relativeVelocity.magnitude > 0.00001){
        // audioSource.Play();
      // print("COLLIDE! Time.deltaTime = " + Time.deltaTime);

      // END GAME!
      // enabled = false;
      // DIE POTATO!!
      Destroy(gameObject);
      EditorUtility.DisplayDialog("YOU DIED","YOU DIED","Ok","Ok");
    }
    // if(collision.transform.gameObject.name == "DeathMaster")
    // {
    //   //do stuff
      
    //   print("COLLIDE! Time.deltaTime = " + Time.deltaTime);

    //   // END GAME!
    //   // enabled = false;
    //   // DIE POTATO!!
    //   Destroy(gameObject);
    //   EditorUtility.DisplayDialog("YOU DIED","YOU DIED","A","B");
    // }

    // if( target.gameObject.name.Equals("DeathMaster") == true ){
    //   print("COLLIDE");
    // }
  }
}
