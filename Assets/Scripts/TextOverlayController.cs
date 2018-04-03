using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class TextOverlayController : MonoBehaviour
{

    [SerializeField]
    private Text text;

    [SerializeField]
    private Image paper;
    
    private AudioSource audioSource;

    [SerializeField]
    private PhotoController photoPrefab;

    [SerializeField]
    private Transform photoParent;

    private List<PhotoController> photos = new List<PhotoController>();

    private Comic[] comics { get { return CurrentSet.comics; } }
    private Comic comic { get { return this.comics[this.current]; } }
    private string paperImage { get { return "images/" + CurrentSet.paper; } }
    private string font { get { return "fonts/" + CurrentSet.font; } }

    private int _current;
    public int current
    {
        get { return this._current; }
        set {
            this._current = value;
            
            if (this.comics == null || this.current >= this.comics.Length)
            {
                this.SetHidden(true);
            }
            else
            {
                this.audioSource.Play();
                if (current != 0) this.photos[this.comics.Length - current].Hide();
                this.text.text = comic.caption;
            }
        }
    }

    public static void SetComicSet(Set set)
    {
        CurrentSet = set;
        if (OnComicSetChanged != null) OnComicSetChanged();
    }

    private static Set CurrentSet;
    private static Action OnComicSetChanged;

    private void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();

        if (this.comics != null) this.UpdateText();
        OnComicSetChanged += this.UpdateText;

        this.SetHidden(true);
	}

    public void SetHidden(bool isHide)
    {
        this.gameObject.SetActive(!isHide);
    }

    public void GoToNext()
    {
        this.current += 1;
    }

    private void UpdateText()
    {
        this.SetHidden(false);

        while (this.photos.Count < this.comics.Length)
        {
            PhotoController photo = Instantiate<PhotoController>(this.photoPrefab, this.photoParent);
            this.photos.Add(photo);
        }

        for (int i = 0; i < this.photos.Count; i++)
        {
            PhotoController photo = this.photos[i];

            if (i < this.comics.Length)
            {
                photo.image = Resources.Load<Sprite>("images/" + comics[this.comics.Length - 1 - i].image);
            } else
            {
                photo.Hide();
            }
        }

        this.current = 0;
        this.paper.sprite = Resources.Load<Sprite>(this.paperImage);
        this.text.font = Resources.Load<Font>(this.font);
    }
}
