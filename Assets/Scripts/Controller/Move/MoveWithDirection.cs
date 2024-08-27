using UnityEngine;

public class MoveWithDirection : MonoBehaviour ,iMove
{

    [SerializeField]
    protected Rigidbody rb;

    [SerializeField]
    protected Transform target;

    protected float moveSpeed;
    protected string tagOfTarget;
    protected float distanceToStop;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        if(target == null)
        {
            target = GameObject.FindWithTag(tagOfTarget).transform;
        }
        if(rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }

    public void Move()
    {
        // Calculate the direction to the target
        Vector3 direction = (target.position - transform.position).normalized;

        
        // Move towards the target directly by setting the position
        if(Vector3.Distance(target.position , transform.position) > distanceToStop)
        {
            rb.velocity = direction * moveSpeed;
            //transform.position += direction * speedMove * Time.deltaTime;
        }  else
        {
            rb.velocity = Vector3.zero;
        }
       

        Debug.Log(rb.velocity.magnitude);
    }

}
