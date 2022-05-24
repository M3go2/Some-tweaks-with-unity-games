using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    [SerializeField]
    private int clicksToPop = 3;

    [SerializeField]
    private float scaleIncreasePerClick = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        clicksToPop += -1;
        //transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        transform.localScale += Vector3.one * scaleIncreasePerClick;

        if (clicksToPop == 0) {
            Destroy(gameObject);
        }
    }

}
