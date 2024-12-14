using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalinput;
    public float verticalinput;
    [SerializeField]
    private GameObject Laser_prefab;
    void Start()
    {
       //Take current position and give it another, using coordinates (x,y,z)
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(Laser_prefab, transform.position, Quaternion.identity);
        }
    }

    void movement(){
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalinput, verticalinput, 0);
        transform.Translate( direction * (10 * Time.deltaTime));
        if (transform.position.y >= 4.56f || transform.position.y <= -4.56f){
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        if (transform.position.x >= 8.46f || transform.position.x <= -8.52f){
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
    }
}
