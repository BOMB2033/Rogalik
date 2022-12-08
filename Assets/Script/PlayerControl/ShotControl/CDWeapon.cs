using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDWeapon : MonoBehaviour
{
    public float cd = 100;
    public bool isCd = false;
    public float delayShot = 0.5f; //��� ��� ���� ���� int,double ��� float
    private bool delayStatet = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    IEnumerator DelayShot()
    {
        delayStatet = false;
        cd--;
        yield return new WaitForSeconds(delayShot); //�� ����� ��������� ��������.
        
        delayStatet = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(!isCd)
            if(cd == 0) isCd = true;
            else StartCoroutine(DelayShot());
        transform.localScale = new Vector3(cd*0.002f, 0.01f ,0.3f);
        
    }
}
// 0.2 100
// 0.002    1