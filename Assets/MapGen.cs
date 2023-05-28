using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGen : MonoBehaviour
{
    public GameObject   m_Voxel;
    public Texture2D    m_Map;

    void Start()
    {
        for(int x = 0; x < m_Map.width; x++)        // X iteration
        {
            for(int z = 0; z < m_Map.height; z++)   // Y iteration
            {
                Color Sample = m_Map.GetPixel(x, z);
                
                if (Sample.r > 0)
                {
                    GameObject This = Instantiate(m_Voxel,
                                                  transform.position + new Vector3(x, 0, z),
                                                  Quaternion.identity);

                    This.transform.SetParent(transform);
                }
            }
        }
    }

    void Update()
    {
        
    }
}
