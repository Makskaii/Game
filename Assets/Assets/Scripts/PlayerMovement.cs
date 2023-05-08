using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask _obstacleMask;
    [SerializeField] private float _step;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            GetComponent<Player>().Kill();
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            TryMove(Vector3.forward);
            
        }
        
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            TryMove(Vector3.back);
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        { 
            TryMove(Vector3.right);
            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { 
            TryMove(Vector3.left);
            
        }
        if (transform.position.y < -10f)
        {
            GetComponent<Player>().Kill();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
    private void TryMove(Vector3 direction)
    {
        var forwardRay = new Ray(transform.position, direction);

        if (Physics.Raycast(forwardRay, _step, _obstacleMask))
            return;

        transform.forward = direction;
        transform.Translate(direction * _step, Space.World);
    }
}
