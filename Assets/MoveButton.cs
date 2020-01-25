using UnityEngine;

public class MoveButton : MonoBehaviour
{

    RectTransform canvas;
    RectTransform button;
    Vector3 startingPosition;
    public float speed;
    public bool unzippnig = false;
    public MainRuntimeBehaviour unz;
   

    void Start()
    {
        button = gameObject.GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
        startingPosition = transform.position;
        speed = -5f;
        unz = GameObject.Find("ARCamera").GetComponent<MainRuntimeBehaviour>();
        
   
    }

    void Update()
    {
        unzippnig = unz.doThing;
        if (unzippnig)
        {
            transform.Translate(0f, speed, 0f);
            if (button.position.y < -button.rect.height)
                transform.position = new Vector3(startingPosition.x, canvas.rect.height + button.rect.height, startingPosition.z);
        }
    }
}