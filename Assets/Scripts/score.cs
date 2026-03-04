using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    void Update() {
        scoreText.text = (player.position.z + 45.26762).ToString("0");
    
    }
}
