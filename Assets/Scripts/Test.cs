using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a, c = 5;
        a = c++;
        //System.out.println(a);
        //System.out.println(c);

        int j, k = 5;
        j = ++k;
        //System.out.println(a);
        //System.out.println(c);
        int d = 5;
        
        // Тернарный оператор
        if(d > a){
            j = a;
        } else {
            j = c;
        }

        j = d > a ? a : c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
