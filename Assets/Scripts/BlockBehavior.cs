using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class BlockBehavior : MonoBehaviour
{
    public GameObject BlockExplosion;
    public GameObject Block;
    float blockCondition;
    public string collisionTag;
    public TMP_Text Text;
    Material blockMaterial;
   
    private void Start()
    {
        Block = this.gameObject;
        blockCondition = Random.Range(0, 10);
        blockMaterial = Block.GetComponent<MeshRenderer>().material;
    }
    private void Update()
    {
        Text.text = blockCondition.ToString();
        blockMaterial.color = new Color(100/255f * 10/blockCondition , 40/255f, 80/255);
        if (blockCondition <= 0) { Destroy(gameObject); }
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == collisionTag)
        {
            blockCondition -= 1;
            blockMaterial = new Material(blockMaterial);
            FindObjectOfType<AudioManager>().Play("Shield Pickup");
        }
        if (blockCondition <= 0) 
        {
            BlockExplosion.transform.position = Block.transform.position;
            Instantiate(BlockExplosion);
            Destroy(gameObject); 
        }
    }
}   
