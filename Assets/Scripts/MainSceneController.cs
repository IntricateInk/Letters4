using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour {
    
    private Dictionary<string, Set> comics = new Dictionary<string, Set>()
    {

        {
            "test1",
            new Set
            (
                paper : "paper1",
                font  : "Admiration Pains",
                comics: new Comic[] {
                    new Comic("photo1", "Once upon a time, there was a piece of paper."),
                    new Comic("photo2", "A man wrote on the piece of paper."),
                    new Comic("photo1", "That piece of paper became a letter."),
                }
            )
        },

        {
            "test2",
            new Set
            (
                paper : "paper2",
                font  : "carbon",
                comics: new Comic[] {
                    new Comic("test2.1", "The letter was sent."),
                    new Comic("test2.2", "He took the mailman's bag."),
                    new Comic("test2.3", "The bag was really dark and stuffy."),
                }
            )
        },

        {
            "test3",
            new Set
            (
                paper : "paper3",
                font  : "Moms_typewriter",
                comics: new Comic[] {
                    new Comic("test3.1", "The letter reached its destination."),
                    new Comic("test3.2", "The letter got opened."),
                    new Comic("test3.3", "The letter got read."),
                }
            )
        },

    };

	public void DisplayTextOverlay(string name)
    {
        TextOverlayController.SetComicSet(this.comics[name]);
    }
}
