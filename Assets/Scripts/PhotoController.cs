using System;
using UnityEngine;
using UnityEngine.UI;

public class PhotoController : MonoBehaviour
{
    private Sprite _image = null;
    public Sprite image {
        get { return this._image; }
        set {
            this._image = value;
            this.display();
        }
    }

    [SerializeField]
    private Image photoImage;
    
    public void Hide() { this.gameObject.SetActive(false); }
    public void Show() { this.gameObject.SetActive(true); }

    private void Start()
    {
        if (this.image != null) display();
    }

    private void display()
    {
        this.Show();
        this.photoImage.sprite = this.image;

        this.resize();

        int sign = UnityEngine.Random.Range(0, 2) * 2 - 1;
        float r = UnityEngine.Random.Range(8f, 15f);
        this.transform.eulerAngles = new Vector3(0, 0, sign * r);
    }

    private void resize()
    {
        float width = this.image.textureRect.width;
        float height = this.image.textureRect.height;
        float ratio = height / width;

        RectTransform parent = this.transform.parent.GetComponent<RectTransform>();
        RectTransform rectTransform = this.GetComponent<RectTransform>();

        float side = Mathf.Min(parent.rect.width, parent.rect.height);
        Vector2 size;

        if (ratio > 1) size = new Vector2(side / ratio, side);
        else           size = new Vector2(side, side * ratio);

        rectTransform.sizeDelta = size;
    }
}