using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    [SerializeField]
    private int clicksToPop = 3;

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
        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

        if (clicksToPop == 0) {
            Destroy(gameObject);
        }
    }

}
