﻿using System.Collections;
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
                font  : "Traditional Arabic",
                comics: new Comic[] {
                    new Comic("00",
                        @"
Waiting long in the dark to be delivered to the recipient, I hold a dear child's memory. Two golden puppies delivered by Santa; ineptly named Bucket and Pail for playing in Mom's wash bucket. I hold my breath with satisfaction as I watched whoever reading smiling while tracing through these words.
                        "),
                    new Comic("01",
                        @"
One of the boy's puppies went missing. His spirit dampened together with the weather; I can still remember the strong winds and the rain outside the very day he took his pen and silently inked his worries down.
"),
                    new Comic("02",
                        @"
The end of a childhood comes swift and bitter. The boy's last dog was put to death after it fell sick. ""Why did this have to happen? Why would they allow this!"" The boy cried in anguish as he penned down his words. The once innocent, hopeful boy not understanding the adults' decision finally wrote his final line, a challenge, to this chain of letters, ""Will you ever do the same, my future self?"""),
                }
            )
        },

        {
            "test2",
            new Set
            (
                paper : "paper1",
                font  : "Traditional Arabic",
                comics: new Comic[] {
                    new Comic("10",
                        @"
Its going to be a long journey. I know im travelling far away. I hope I do not get sent to the wrong address, feeling pretty important today! At least I don’t forget stuff! I can remember these words for a long long time.

"),
                    new Comic("11", 
                        @"
I’m so excited that I get to tell her how he feel about her and convey such meaningful words. All these secret feelings are finally out in the open and I am tasked to carry this to the other side. How important I feel, what power I hold in my hands. 
"),
                    new Comic("12",
                        @"
These kind of emotions; so personal; but anyone can read me and I will unfortunately share everything. I hope I don’t convey this message to some one else. I hope I reach the right person. The fact that anyone can read these words is quite discomforting.
"),
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
                    new Comic("20",
                        @"
It is my duty to serve my country. My fellow brothers and sisters and I have been charged with the responsibility and authority to enlist new recruits for the army. We have instructions to send to them.

I am excited to do my duty.
"),
                    new Comic("21", 
                        @"
Today, I traveled with a group of other letters. I proudly told them of my duty and asked them about theirs. Some of them laughed and others looked confused. They told me that a message is more than a duty, and that they bear the weight of their writers as well.

Is duty not the utmost importance? How can one person be more important than a duty and the good of the many?
"),
                    new Comic("22", @"
I am torn between my duty and what I feel. I told him of his duty, the glory of battle and his enlistment. Yet when he read me, I saw a range of emotions I had never seen before. The shock, the disappointment, the worry, the fear.

I still think duty is the important, but when I look at his face, I find it difficult to say so with pride.
"),
                }
            )
        },

        {
            "test4",
            new Set
            (
                paper : "paper3",
                font  : "Traditional Arabic",
                comics: new Comic[] {
                    new Comic("30", 
                        @"
Tears, tears,
tears…

He cried, he scrunched his face up as his hand shook and wrote.
I felt the pain in each word, the fear between each pause as he wrote.
Each pause longer than the next, fearing and fearing that he would never see her again.

But I will see her again for him. I must convey his feelings to her.
"),
                    new Comic("31",
                        @"
The trip was long and arduous. I passed through worried courier after courier, and met with other letters each bearing the same pain and fear I did.
All worried men, all putting on strong fronts for their loved ones.
All fearful men, all concerned about their loved ones.

We strengthened our resolve to deliver our message.
"),
                    new Comic("32",
                        @"
When she saw his name, her mouth hung slightly open. Then closed.
Then opened again. Her hand pinched me gingerly.

She hesitated and released me, yet I insisted that she read me; she walked away. From her back she looked uncertain, and most definitely sad.

I was confused. Didn’t she love him as well?
"),
                    new Comic("33",
                        @"
She came back. A slight scowl, tear marks clear on her face. Hands shaking, she pulled me covering her mouth as she read. No more tears; her eyes already dried out from crying.

She pulled a piece of paper. A sibling letter, a reply. I cheered inside. Slowly, wringing her hands painfully, between each lengthening pause. Each word more resolute than the next, but more hesitant.

Then she crumbled it. And wrote again, and again. And again. Each time, slower and more painful than the next; the band of steel on her finger more constricting as she twisted it whenever she wrung her hands.

She never sent a reply. She couldn’t she said, as she collapsed into another man’s arms.
"),
                    new Comic("34",
                        @"
Lying on her desk, I felt cold.

Cold but never forgotten, as her eyes lingered on me every time she passed.

"),
                }
            )
        },


        {
            "test5",
            new Set
            (
                paper : "paper2",
                font  : "Traditional Arabic",
                comics: new Comic[] {
                    new Comic("40",
                        @"
Today was different
After a long wait, I finally got the response to Love Letter
The idea of young love always inspired me 

It is very hard to explain how much joy words written in a curvy feminine handwriting, long paragraphs about happier times and hope for a beautiful future can give a letter


I had heard from my friends that they were childhood sweetheart
And I was so sure this one would be a happy one, 
but one glance and my feelings are somewhat mixed

The tears on the paper and the scribbled words; I could feel the pain,
The harsh words were honest but heartbreaking. 

"),
                    new Comic("41", @"
“We have nothing common to talk about anymore, you are always busy with your life, and I no longer feel the warmth and connection that we once shared.”

Are Distances and Differences stronger than love?


“The pain will be intolerable, but only for a short while. In the long term things will definitely get better, trust me.”
How can she make such a big decision for the both of them?


“I don’t want to lose my first love and my best friend all in the same day.”

Is this sad and painful breakup letter what I was born to do?
"),
                }
            )
        },


        {
            "test6",
            new Set
            (
                paper : "paper3",
                font  : "Kindergarden",
                comics: new Comic[] {
                                        new Comic("50", @"Today I felt special again, I was given a very important task 
I felt blessed, I was able to deliver a child’s promises to his grandfather 

A mature poem in his large and immature handwriting 

It said:
Dear Grandad,

Dementia got inside your brain
Your personality is no longer the same
We know it’s not you when you shout and lash out
We’re here for you forever without a doubt

It’s hard to see you filled with so much anger 
When only 18 months ago you had moves like jagger!
When you tell us you’ve lost your mind
It hurts so much, could curl up and cry
"),
                    new Comic("51",
                        @"
Don’t worry we know it’s not your fault
Dementia took over, I’d call it assault!
We know behind the vacant look 
There’s something very special gentleman Dementia took

We’ll hold your hand and keep you safe
Dementia won’t beat this family that’s no mistake!
You’ve looked after your family and friends
Your whole life through

And now it’s our honor and duty 
to do the very same for you!

Your Favourute Grandson
"),
                }
            )
        },

    };

	public void DisplayTextOverlay(string name)
    {
        TextOverlayController.SetComicSet(this.comics[name]);
    }
}
