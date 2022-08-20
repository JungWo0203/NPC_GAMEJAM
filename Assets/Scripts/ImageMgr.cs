using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageMgr : MonoBehaviour
{
    public Sprite[] m_images = new Sprite[5];
    public GameObject image_desc = null;
    public Image m_image = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeBackGround(int BGNumber) 
    {
        m_image.sprite = m_images[BGNumber];
    }
    // Update is called once per frame
    void Update()
    {
    }
}
