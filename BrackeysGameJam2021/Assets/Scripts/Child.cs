using UnityEngine;

public class Child : MonoBehaviour
{
    private Rigidbody2D rb;
    private int speed = 70;
    private bool isLeft;
    private Animator anim;
    [SerializeField] private GameObject hammer;

    private bool key1 = false, key2 = false, key3 = false, key4 = false, key5 = false;
    [SerializeField] private GameObject item1, item2, item3, item4, item5, item6;
    [SerializeField] private GameObject particle;
    
    [SerializeField] private GameObject FadeEndOfGame;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = GameObject.Find("ChildBody").GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(speed * rb.mass * Vector2.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(speed * rb.mass * Vector2.left);
            isLeft = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(speed * rb.mass * Vector2.down);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed * rb.mass * Vector2.right);
            isLeft = false;
        }

        if (isLeft == false)
        {
            this.transform.right = new Vector2(-1, 0);
        }
        else
        {
            this.transform.right = new Vector2(1, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PickUpHammer")
        {
            Destroy(other.gameObject);
            item1.SetActive(true);
            hammer.SetActive(true);
        }
        if (other.name == "Key 1")
        {
            GameObject spawnParticle = Instantiate(particle);
            spawnParticle.transform.position = other.transform.position;
            Destroy(spawnParticle.gameObject, 1);
            Destroy(other.gameObject);
            key1 = true;
            item2.SetActive(true);
        }
        if (other.name == "Key 2")
        {
            GameObject spawnParticle = Instantiate(particle);
            spawnParticle.transform.position = other.transform.position;
            Destroy(spawnParticle.gameObject, 1);
            Destroy(other.gameObject);
            key2 = true;
            item3.SetActive(true);
        }
        if (other.name == "Key 3")
        {
            GameObject spawnParticle = Instantiate(particle);
            spawnParticle.transform.position = other.transform.position;
            Destroy(spawnParticle.gameObject, 1);
            Destroy(other.gameObject);
            key3 = true;
            item4.SetActive(true);
        }
        if (other.name == "Key 4")
        {
            GameObject spawnParticle = Instantiate(particle);
            spawnParticle.transform.position = other.transform.position;
            Destroy(spawnParticle.gameObject, 1);
            Destroy(other.gameObject);
            key4 = true;
            item5.SetActive(true);
        }
        if (other.name == "Key 5")
        {
            GameObject spawnParticle = Instantiate(particle);
            spawnParticle.transform.position = other.transform.position;
            Destroy(spawnParticle.gameObject, 1);
            Destroy(other.gameObject);
            key5 = true;
            item6.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Door0")
        {
            other.GetComponent<Door>().ShowHint(1);
            if (Input.GetKey(KeyCode.E))
            {
                other.GetComponent<Door>().OpenDoor();
            }
        }
        if (other.name == "Door1" && key1 == true)
        {
            other.GetComponent<Door>().ShowHint(1);
            if (Input.GetKey(KeyCode.E))
            {
                other.GetComponent<Door>().OpenDoor();
            }
        }
        if (other.name == "Door2" && key2 == true)
        {
            other.GetComponent<Door>().ShowHint(1);
            if (Input.GetKey(KeyCode.E))
            {
                other.GetComponent<Door>().OpenDoor();
            }
        }
        if (other.name == "Door3" && key3 == true)
        {
            other.GetComponent<Door>().ShowHint(1);
            if (Input.GetKey(KeyCode.E))
            {
                other.GetComponent<Door>().OpenDoor();
            }
        }
        if (other.name == "Door4" && key4 == true)
        {
            other.GetComponent<Door>().ShowHint(1);
            if (Input.GetKey(KeyCode.E))
            {
                other.GetComponent<Door>().OpenDoor();
            }
        }
        if (other.name == "Door5" && key5 == true)
        {
            other.GetComponent<Door>().ShowHint(1);
            if (Input.GetKey(KeyCode.E))
            {
                other.GetComponent<Door>().OpenDoor();
                FadeEndOfGame.SetActive(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name.Contains("Door"))
        {
            other.GetComponent<Door>().ShowHint(0);
        }
    }
}
