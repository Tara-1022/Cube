using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Text scoretext;//'Text' is the type of the text
    public Transform player;//'Transform' indicates position vectors
    
    void Update()
    {
       scoretext.text = player.position.z.ToString("0");  //tostring conerts to string; 0 ensure only whole no.s
    }
}
