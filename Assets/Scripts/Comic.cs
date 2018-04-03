using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Comic
{
    public string image;
    public string caption;
    
    public Comic(string image, string caption)
    {
        this.image = image;
        this.caption = caption;
    } 
}

public struct Set
{
    public string paper;
    public string font;
    public Comic[] comics;

    public Set(string paper, string font, Comic[] comics)
    {
        this.paper = paper;
        this.font = font;
        this.comics = comics;
    }
}