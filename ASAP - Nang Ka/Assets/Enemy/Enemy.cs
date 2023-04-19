using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float walkSpeed = 3f;

    Rigidbody2D rb;
    TouchingDirection touchingDirection;
    Animator animator;

    public EnemyDetection attackZone;


    public enum WalkableDirection{right, left}

    private WalkableDirection _walkDirection;
    private Vector2 walkDirectionVector = Vector2.right;
   public bool hasTarget
    {
        get
        {
            return _hasTarget;
        }
        private set
        {
            _hasTarget = value;
            animator.SetBool(AnimationStrings.hasTarget, value);
        }
    }
   

    public bool _hasTarget = false;
    
    public WalkableDirection WalkDirection
    {
        get { return _walkDirection; }
        set 
        {
            if (_walkDirection != value)
            {
                //direction flipped 
                gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x * -1, gameObject.transform.localScale.y);

                if(value == WalkableDirection.right)
                {
                    walkDirectionVector = Vector2.right;
                }
                else if(value == WalkableDirection.left)
                {
                    walkDirectionVector = Vector2.left;
                }
            }

            _walkDirection = value; 
        }

    }

    public void FlipDirection()
    {
        if (WalkDirection == WalkableDirection.right)
        {
            WalkDirection = WalkableDirection.left;
        }
        else if (WalkDirection == WalkableDirection.left)
        {
            WalkDirection = WalkableDirection.right;
        }
        else
        {
            Debug.LogError("current walkable direction is not with legal values"); 
        }
    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        touchingDirection = GetComponent<TouchingDirection>();
        animator = GetComponent<Animator>();
  
    }

    public void Update()
    {
       hasTarget = attackZone.detectedCollider.Count > 0;
        
    }


    public void FixedUpdate()
    {
        if (touchingDirection.IsGrounded && touchingDirection.IsOnWall)
        {
            FlipDirection();
        }
        rb.velocity = new Vector2(walkSpeed * walkDirectionVector.x, rb.velocity.y);
    }



}
