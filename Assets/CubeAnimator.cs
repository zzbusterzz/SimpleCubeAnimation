using UnityEngine;

public class CubeAnimator : MonoBehaviour
{
    public Animator cube_animator;

    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cube_animator.SetBool("Up", true);
        }
        else
        {
            cube_animator.SetBool("Up", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            cube_animator.SetBool("Down", true);
        }
        else
        {
            cube_animator.SetBool("Down", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            cube_animator.SetBool("Left", true);
        }
        else
        {
            cube_animator.SetBool("Left", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            cube_animator.SetBool("Right", true);
        }
        else
        {
            cube_animator.SetBool("Right", false);
        }
    }
}
