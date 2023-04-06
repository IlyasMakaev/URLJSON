using UnityEngine;
using TMPro;


public class Chuck : MonoBehaviour
{
    public TextMeshProUGUI jokeText;
 
    public void NewJoke()
    {
        Joke j = APIHelper.GetNewJoke();
        jokeText.text = j.value;
    }
}
