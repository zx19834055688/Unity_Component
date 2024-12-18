using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnabledChange : MonoBehaviour
{
        public List<GameObject> objects = new List<GameObject>();
        public bool closeOthers = true;
        public void ChangeObject(string objNum)
        {
            var num = int.Parse(objNum);
            if(closeOthers)
            {
                for (int i = 0; i < objects.Count; i++) 
                {
                    objects[i].SetActive(false);
                }
            }
            
            objects[num - 1].SetActive(true);    
        }
        
}
