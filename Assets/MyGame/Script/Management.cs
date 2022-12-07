using UnityEngine;

public class Management : MonoBehaviour
{
    bool mpipeopen1 = false;
    bool mpipeopen2 = false;
    [SerializeField] GameObject mpipe1;
    [SerializeField] GameObject mpipe2;
    [SerializeField] GameObject mario;
    int click = 0;
    [SerializeField] Animator mstart;
    [SerializeField] Animator mpipe1open;
    [SerializeField] Animator mpipe2open;
   

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click++;
            
        }
        if (click % 2 != 0)
        {
            mpipeopen1 = true;
            mpipe1open.SetTrigger("Open1");
        }


        if (click % 2 == 0 && click != 0)
        {
            mpipeopen2 = true;
            mpipe2open.SetTrigger("Open2");
        }

        if (click % 3 == 0 && click != 0)
        {
        mstart.SetTrigger("Active");
            Debug.Log("You Won");
        }

       

        

    }
}
