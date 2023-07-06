using UnityEngine;

class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    [SerializeField] private KeyCode SpawnKey = KeyCode.E;

    private Transform playerTransform;
    private GameObject lastSpawn;

    void Spawn()
    {
        // ~ gets the position for the object
        Vector3 position = playerTransform.forward;           
        // ~ spawns the object forward to the player with the same rotation of the object itself
        lastSpawn = GameObject.Instantiate(Prefab, position, Prefab.transform.rotation);
    }

    void Update(){
        //  ~ Checks whether the spawn's key is pressed & if pressed it spawns the object 'prefab'
        if(Input.GetKeyDown(SpawnKey)){
            Spawn();
        }
    }
}
