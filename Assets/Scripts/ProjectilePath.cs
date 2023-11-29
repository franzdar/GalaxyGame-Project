using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectilePath : MonoBehaviour
{
    public GameManager gameManager;

    public AudioSource audioSource;

    private Vector3 startPos;
    private Vector3 endPos;

    private Rigidbody2D rb;
    public Rigidbody2D hook;
    private Vector3 forceAtPlayer;
    public float forceFactor;

    public GameObject trajectoryDot; //the material that we are going to use for the dot
    private GameObject[] trajectoryDots; //the generated path model out of dots
    public int numberOfDots; //number of trajectory dots that will appear

    public GameObject nextProjectile; //reference the next/new active projectile game object 

    public float maxDragDistance = 2f; //max drag distance of the projectile from the hook

    public bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trajectoryDots = new GameObject[numberOfDots];
        this.gameObject.transform.position = new Vector3(hook.transform.position.x, hook.transform.position.y, hook.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.ballFell)
        {
            if (nextProjectile != null) //checks if there are still projectiles left
            {
                nextProjectile.SetActive(true);
            }
            else
            {
                gameManager.isGameRunning = false;
            }
            this.gameObject.SetActive(false);
            gameManager.ballFell = false;
        }

        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //checks the position of the mouse cursor on the screen 

            //sets the max drag distance of the projectile from the hook 
            if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
            {
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
            }
            else
            {
                rb.position = mousePos;
            }
        }

        if (Input.GetMouseButtonDown(0)) //left click
        {
            isPressed = true;
            rb.isKinematic = true;

            //on click
            startPos = gameObject.transform.position;
            for (int i = 0; i < numberOfDots; i++)
            {
                trajectoryDots[i] = Instantiate(trajectoryDot, gameObject.transform);
            }
        }

        if (Input.GetMouseButton(0))
        {
            //drag
            endPos = rb.position;
            gameObject.transform.position = endPos;
            forceAtPlayer = endPos - startPos;

            for (int i = 0; i < numberOfDots; i++)
            {
                trajectoryDots[i].transform.position = CalculatePosition(i * 0.1f);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isPressed = false;
            rb.isKinematic = false;

            //release
            rb.velocity = new Vector2(-forceAtPlayer.x * forceFactor, -forceAtPlayer.y * forceFactor);

            for (int i = 0; i < numberOfDots; i++)
            {
                Destroy(trajectoryDots[i]);
            }

            StartCoroutine(Release());
        }
    }

    private Vector2 CalculatePosition(float elapsedTime)
    {
        return new Vector2(endPos.x, endPos.y) +
            new Vector2(-forceAtPlayer.x * forceFactor, -forceAtPlayer.y * forceFactor) * elapsedTime +
            0.5f * Physics2D.gravity * elapsedTime * elapsedTime;
    }

    IEnumerator Release()
    {

        GetComponent<SpringJoint2D>().enabled = false;
        
        yield return new WaitForSeconds(4f);

        if (nextProjectile != null) //checks if there are still projectiles left
        {
            nextProjectile.SetActive(true);
        }
        else
        {
            gameManager.isGameRunning = false;
        }

        yield return new WaitForSeconds(1f);
        this.gameObject.SetActive(false);
    }

    public void OnCollisionEnter2D()
    {
        audioSource.Play();
    }
}








