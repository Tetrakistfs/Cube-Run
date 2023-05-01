using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text socreText;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.z);
        socreText.text = player.position.z.ToString("0");
    }
}
